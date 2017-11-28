using Ripcord.Assets.Libraries.Enums;

namespace Ripcord.Assets.Libraries
{
    public class ProxyLib
    {
        public string Proxy { get; set; }

        public Anonymity Anonymity_type { get; set; }

        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        
        public long Response_time { get; set; }
        public bool URL_passed { get; set; }
        public bool Alive { get; set; }
        
        public string Time_initiated { get; set; }
        public string Date_initiated { get; set; }

        public ProxyLib(string _proxy)
        {
            this.Proxy = _proxy;
        }
    }
}
