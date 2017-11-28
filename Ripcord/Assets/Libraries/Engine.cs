using System;
using System.Linq;

namespace Ripcord.Assets.Libraries
{
    public class Engine
    {
        public string File_name { get; set; }
        public string Display_name { get; set; }
        public string Query_string { get; set; }
        public int Page_start { get; set; }
        public int Page_increment { get; set; }
        public int Page_end { get; set; }
        public string Regex { get; set; }
        public int RegexValueType { get; set; }
        public int GroupsNum { get; set; }
        public string URLMustContain { get; set; }
        public string URLMustNotContain { get; set; }
        public string AddBeforeURL { get; set; }
        public bool EnableKeywords { get; set; }
        public int Harvested { get; set; }
        public bool Enabled { get; set; }

        public Engine(string _engine)
        {
            this.Display_name = _engine;
        }
    }
}
