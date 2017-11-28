using System;
using System.Linq;

namespace Ripcord.Assets.Libraries
{
    public class License
    {
        public static String VERSION = "1.0";

        public int premium { get; set; }
        public string active { get; set; }
        public int banned { get; set; }
    }
}
