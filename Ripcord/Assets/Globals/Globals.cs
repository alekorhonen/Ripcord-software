using System;
using System.Linq;

namespace Ripcord.Assets.Globals
{
    public static class Globals
    {
        public static int Bots = 50;
        public static int timeout = 5;
        public static int retries = 1;

        public static bool Disable_listview = false;

        //Start: Checker settings

        public static string Judge = "http://proxy.supplies/azenv.php";
        public static bool SSL_check = false;
        public static string SSL = "https://accounts.google.com/ServiceLogin";
        public static string SSL_keyword = "Google";

        public static string Geolocation = "http://freegeoip.net/json/<IP>";
        public static string Geolocation_country = "country_name\":\"(.*?)\",";
        public static string Geolocation_region = "region_name\":\"(.*?)\",";
        public static string Geolocation_city = "city\":\"(.*?)\",";

        //End: Checker settings

        public static string IPAddress = "";
        public static string Hwid = "";
    }
}
