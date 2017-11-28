using Ripcord.Assets.Libraries;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace Ripcord.Assets.Tasks
{
    public static class Harvester
    {
        public static string Config_file = "";

        public static List<Source> Harvest(Engine engine, string keyword, int pagenum)
        {
            List<Source> urls = new List<Source>();

            string query = engine.Query_string.Replace("{KEYWORD}", keyword).Replace("{PAGENUM}", pagenum.ToString());
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("User-Agent", User_Agents.GetRandomAgent());
                string src = client.DownloadString(query);

                MatchCollection matches = Regex.Matches(src, engine.Regex);
                foreach (Match m in matches)
                {
                    string url = engine.AddBeforeURL;
                    if (engine.RegexValueType == 1)
                    {
                        url += m.Groups[engine.GroupsNum].Value;
                    }
                    else
                    {
                        url += m.Value;
                    }

                    url = HttpUtility.UrlDecode(url).Replace("&amp;", "&");
                    if (url.Contains(engine.URLMustContain))
                    {
                        if (engine.URLMustContain.Contains("|"))
                        {
                            string[] keys = engine.URLMustNotContain.Split('|');
                            int found = 0;
                            foreach (string key in keys)
                            {
                                if (url.Contains(key))
                                    found++;
                            }
                            if (found == 0)
                            {
                                urls.Add(new Source(HttpUtility.UrlDecode(url)));
                            }
                            /*
                            if (keys.Any(s => !url.Contains(s)))
                            {
                                urls.Add(new Source(HttpUtility.UrlDecode(url)));
                            }
                            */
                        }
                        else
                        {
                            if (!url.Contains(engine.URLMustNotContain))
                            {
                                urls.Add(new Source(HttpUtility.UrlDecode(url)));
                            }
                        }
                    }
                }
            }
        return urls;
        }
    }
}
