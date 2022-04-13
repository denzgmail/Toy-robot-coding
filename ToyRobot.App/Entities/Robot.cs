using System;
using System.Reflection;
using ToyRobot.App.Extenssions;
using ToyRobot.App.Utilities;

namespace ToyRobot.App.Entities
{
    public class Robot
    {
        public Location Location = new Location { East = 0, North = 0 , Direction ="" };


        public Robot()
        {
            
        }
        public void Move()
        {
            Type type = Location.GetType();
            //USED REFLECTION TO AVOID THE USED OF SWITCH CASE OR IF ELSE.. FOR FLEXIBILITY PURPOSES
            MethodInfo methodInfo = type.GetMethod("Move" + Location.Direction.FirstCharToUpper());
            methodInfo.Invoke(Location, null);
        }

        public void Right()
        {
            //USE DICTIONARY TO AVOID USING SWITCH CASE OR IF ELSE. FOR FLEXIBILITY PURPOSES
            Location.Direction = RobotDictionary.Right().GetValueByName(Location.Direction);
        }
        public void Left()
        {
            //USE DICTIONARY TO AVOID USING SWITCH CASE OR IF ELSE. FOR FLEXIBILITY PURPOSES
            Location.Direction = RobotDictionary.Left().GetValueByName(Location.Direction);
        }
        public string Report()
        {
            return Location.East + "," + Location.North + "," + Location.Direction.ToUpper();
        }
    }
}
