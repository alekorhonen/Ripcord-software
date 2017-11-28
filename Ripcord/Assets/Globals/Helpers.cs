using System;
using System.Linq;
using System.Net;

namespace Ripcord.Assets.Globals
{
    public static class Helpers
    {
        public static long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

        public static string logfile = "";
        public static void Log(string message)
        {

        }

        public static bool CheckJudge(string judge)
        {
            try
            {
                WebClient wc = new WebClient();
                string src = wc.DownloadString(judge);
                if (src.Contains("HTTP_X_FORWARDED_FOR"))
                    return true;
            } catch
            {
            }
        return false;
        }

        public static string GetIP()
        {
            WebClient wc = new WebClient();
            return wc.DownloadString("http://bot.whatismyipaddress.com/");
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
