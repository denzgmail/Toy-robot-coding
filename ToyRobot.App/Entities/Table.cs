using System;
using System.Reflection;
using ToyRobot.App.Extenssions;

namespace ToyRobot.App.Entities
{
    public class Table
    {
        public int width;
        public int length;
        public bool IsValidLocation(int east, int north, string direction )
        {
            bool isValid = false;
            var location = new Location { East = east, North = north, Direction = direction };
            Type type = location.GetType();
            //USED REFLECTION TO AVOID THE USED OF SWITCH CASE OR IF ELSE.. FOR FLEXIBILITY PURPOSES
            MethodInfo methodInfo = type.GetMethod("Move" + direction.FirstCharToUpper());
            methodInfo.Invoke(location, null);
            if (location.East >= 0 && location.East < width && location.North >= 0 && location.North < length)
                isValid = true;
            return isValid;
        }
        public bool IsValidLocation(int east, int north)
        {
            bool isValid = false;
            if (east >= 0 && east < width && north >= 0 && north < length)
                isValid = true;
            return isValid;
        }
        public Table(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
    }
}
