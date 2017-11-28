using System.Net;
using System.IO;

namespace Ripcord.Assets.Libraries
{
    public static class NET
    {
        public static string GetSource(string url)
        {
            string src = "";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Timeout = Globals.Globals.timeout * 1000;
            httpWebRequest.KeepAlive = false;

            try
            {
                using (WebResponse response = httpWebRequest.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader streamReader = new StreamReader(responseStream))
                        {
                            src = streamReader.ReadToEnd();
                            streamReader.Close();
                        }
                        responseStream.Flush();
                        responseStream.Close();
                        response.Close();
                    }
                }
            }
            catch
            {
                return src;
            }

            return src;
        }

    }
}
