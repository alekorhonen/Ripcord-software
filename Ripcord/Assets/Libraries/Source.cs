using System;
using System.Linq;

namespace Ripcord.Assets.Libraries
{
    public class Source
    {
        public string url { get; set; }

        public long response_time { get; set; }

        public int proxies_gathered { get; set; }

        public bool alive { get; set; }

        public Source(string _source)
        {
            this.url = _source;
            this.response_time = 0;
            this.proxies_gathered = 0;
            this.alive = true;
        }
    }

    public static class SourceBank
    {
        public static void Save(string _src)
        {
        }
    }
}
