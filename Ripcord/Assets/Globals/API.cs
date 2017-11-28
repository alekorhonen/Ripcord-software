using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Ripcord.Assets.Globals
{
    public static class API
    {
        private static string server = "http://api.proxy.supplies/";
        private static string version = Application.ProductVersion;

        public static string HWID = "";
        public static string License = "";


        public static string Process(string cmd, string postData = "")
        {
            postData = postData.Replace("<LICENSE>", License);
            postData = postData.Replace("<HWID>", HWID);
            var request = (HttpWebRequest)WebRequest.Create(server + cmd);
            if(postData != "")
            {
                postData = postData.Replace("+", "%2B");
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            var response = (HttpWebResponse)request.GetResponse();
            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

        public static byte[] Concat(params byte[][] arrays)
        {
            using (var mem = new MemoryStream(arrays.Sum(a => a.Length)))
            {
                foreach (var array in arrays)
                {
                    mem.Write(array, 0, array.Length);
                }
                return mem.ToArray();
            }
        }

        public static string encryptString(string text)
        {
            string IV = GetUniqueKey(32);

            Encoding gEnc = Encoding.GetEncoding(1252);

            RijndaelManaged aes = new RijndaelManaged()
            {
                KeySize = 256,
                BlockSize = 256,
                Padding = PaddingMode.Zeros,
                Mode = CipherMode.CBC,
                Key = gEnc.GetBytes(HWID),
                IV = gEnc.GetBytes(IV)
            };

            ICryptoTransform AESEncrypt = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] buffer = gEnc.GetBytes(text);

            return Convert.ToBase64String(AESEncrypt.TransformFinalBlock(buffer, 0, buffer.Length)) + "-[--IV-[-" + IV;
        }

        public static string decryptString(string text)
        {
            Encoding gEnc = Encoding.GetEncoding(1252);

            string IV = text;
            IV = IV.Substring(IV.IndexOf("-[--IV-[-") + 32);
            text = text.Replace("-[--IV-[-" + IV, "");

            RijndaelManaged aes = new RijndaelManaged()
            {
                KeySize = 256,
                BlockSize = 256,
                Padding = PaddingMode.Zeros,
                Mode = CipherMode.CBC,
                Key = gEnc.GetBytes(HWID),
                IV = gEnc.GetBytes(IV)
            };

            ICryptoTransform AESDecrypt = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] buffer = Convert.FromBase64String(text);

            return gEnc.GetString(AESDecrypt.TransformFinalBlock(buffer, 0, buffer.Length));
        }

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
    }
}