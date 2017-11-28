using Ripcord.Assets.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ripcord.Assets.Globals
{
    public static class Lists
    {
        public static List<ProxyLib> Proxies = new List<ProxyLib>().Distinct().ToList();
        public static List<ProxyLib> Checked_proxies = new List<ProxyLib>().Distinct().ToList();
        public static List<Source> Sources = new List<Source>().Distinct().ToList();
        public static List<Engine> Engines = new List<Engine>().Distinct().ToList();
        public static List<string> Logs = new List<string>().Distinct().ToList();

        public static List<string> Ports = new List<string>().Distinct().ToList();
        public static List<string> Keywords = new List<string>().Distinct().ToList();
    }
}
