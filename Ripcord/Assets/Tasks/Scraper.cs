using Ripcord.Assets.Libraries;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Ripcord.Assets.Tasks
{
    public static class Scraper
    {
        public static string Proxy_Pattern = "[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}:(8080|443|3128|8888|8101|8123|9000|8118|84|8008|3129|81|9090|9999|8090|4444|5007|8828|5070|8081|808|9797|8089|8088|5601|8000|1080|88|8083|8909|8082|800|3127|3124|8998|4000|7004|9145|3125|80)";

        public static List<ProxyLib> Scrape(Source _source) {
            List<ProxyLib> Proxies = new List<ProxyLib>();
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", User_Agents.GetRandomAgent());
                    string src = client.DownloadString(_source.url);

                    //Stop and set the response time
                    stopwatch.Stop();
                    _source.response_time = stopwatch.ElapsedMilliseconds;

                    MatchCollection matches = Regex.Matches(src, Proxy_Pattern);
                    Proxies.AddRange(matches.Cast<Match>().Select(match => new ProxyLib(match.Value)).ToList());

                    _source.proxies_gathered = Proxies.Count;
                }
            } catch
            {
                _source.alive = false;
            }
            return Proxies;
        }
    }
}
