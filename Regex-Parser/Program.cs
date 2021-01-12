using System;
using System.Text.RegularExpressions;

namespace Regex_Parser
{
    class Program
    {
        public static string Parsing(string from, string one, string two)
        {
            Match val = Regex.Match(from, "(?<=" + one + ")(.*?)(?=" + two + ")");
            return val.ToString();
        }
    }
}
