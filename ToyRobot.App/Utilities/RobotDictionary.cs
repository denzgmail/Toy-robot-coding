using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.App.Utilities
{
    public static class RobotDictionary
    {
        public static Dictionary<string, string> Left()
        {
            return new Dictionary<string, string>()
            {
                { "north","west" },
                { "east","north" },
                { "south","east" },
                { "west","south" }
            };
        }
        public static Dictionary<string, string> Right()
        {
            return new Dictionary<string, string>()
            {
                { "north","east" },
                { "east","south" },
                { "south","west" },
                { "west","north" }
            };
        }
        public static string GetValueByName(this Dictionary<string, string> dictionary, string key)
        {
            return dictionary[key];
        }
    }
}
