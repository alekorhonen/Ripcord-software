using Ripcord.Assets.Libraries;
using Ripcord.Assets.Libraries.Enums;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ripcord.Assets.Tasks
{
    public static class Checker
    {
        public static ProxyLib GetGeo(ProxyLib prx)
        {
            prx.Country = "N/A";
            prx.Region = "N/A";
            prx.City = "N/A";

            string end = Libraries.NET.GetSource(Globals.Globals.Geolocation.Replace("<IP>", prx.Proxy.Split(':')[0]).Replace("<PORT>", prx.Proxy.Split(':')[1]));

            if (end != "")
            {
                prx.Country = new Regex(Globals.Globals.Geolocation_country).Match(end).Groups[1].Value;
                prx.Region = new Regex(Globals.Globals.Geolocation_region).Match(end).Groups[1].Value;
                prx.City = new Regex(Globals.Globals.Geolocation_city).Match(end).Groups[1].Value;
            }

            if (prx.Region == "")
                prx.Region = "N/A";
            if (prx.City == "")
                prx.City = "N/A";

            return prx;
        }

        private static readonly HashSet<string> EliteHeaders = new HashSet<string>
        {
            "HTTP_HOST",
            "HTTP_X_FORWARDED_FOR",
            "REMOTE_ADDR",
            "REMOTE_PORT",
            "REQUEST_METHOD",
            "REQUEST_URI",
            "REQUEST_TIME_FLOAT",
            "REQUEST_TIME"
        };

        private static bool EliteHeadersOnly(string text)
        {
            var keys = Regex.Matches(text, "(?<key>\\w+) ?= ?(?<value>.+)")
                .OfType<Match>()
                .Select(m => m.Groups["key"].Value);
            return EliteHeaders.SetEquals(keys);
        }

        public static ProxyLib Judge(ProxyLib proxy)
        {
            proxy.Alive = false;
            proxy.Anonymity_type = Anonymity.Unknown;

            List<string> MustContain = new List<string>();
            MustContain.Add("HTTP_X_FORWARDED_FOR");
            MustContain.Add("REMOTE_ADDR");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string end = Libraries.NET.GetSource(Globals.Globals.Judge.Replace("<IP>", proxy.Proxy.Split(':')[0]).Replace("<PORT>", proxy.Proxy.Split(':')[1]));
            stopwatch.Stop();
            if (end != "")
            {
                if (MustContain.Any(s => end.Contains(s)))
                {
                    string str1 = new Regex("HTTP_X_FORWARDED_FOR = (.*?)\n").Match(end).Groups[1].Value;
                    string str2 = new Regex("REMOTE_ADDR = (.*?)\n").Match(end).Groups[1].Value;
                    if (end.Contains(Globals.Globals.IPAddress))
                    {
                        proxy.Anonymity_type = Anonymity.Transparent;
                    }
                    else if (EliteHeadersOnly(end))
                    {
                        proxy.Anonymity_type = Anonymity.Elite;
                    }
                    else if (!end.Contains(Globals.Globals.IPAddress))
                    {
                        proxy.Anonymity_type = Anonymity.Anonymous;
                    }
                }
            }

            if (proxy.Anonymity_type != Anonymity.Unknown)
                proxy.Alive = true;

            return proxy;
        }
    }
}