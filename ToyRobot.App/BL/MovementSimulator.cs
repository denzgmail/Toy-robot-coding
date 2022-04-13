using System;
using System.Reflection;
using ToyRobot.App.Entities;
using ToyRobot.App.Extenssions;

namespace ToyRobot.App.BL
{
    public class MovementSimulator
    {
        public Robot robot;
        public Table Table;

        public MovementSimulator(Table _table)
        {
            Table = _table;
        }

        public void Place(int east, int north, string direction)
        {
            if (Table.IsValidLocation(east, north))
            {
                robot = new Robot
                {
                    Location = new Location { East = east, North = north, Direction = direction.ToLower() }
                };
            }
        }
        public void Move(string movement)
        {
            try
            {
                Type type = robot.GetType();
                if (movement == "move")//ONLY MOVE NEEDS TO BE CHECKED FOR VALID LOCATION
                {
                    //IF NOT VALID LOCATION THEN SKIP
                    if (!Table.IsValidLocation(robot.Location.East, robot.Location.North, robot.Location.Direction))
                    {
                        return;
                    }
                }
                //USED REFLECTION TO AVOID THE USED OF SWITCH CASE OR IF ELSE.. FOR FLEXIBILITY PURPOSES
                MethodInfo methodInfo = type.GetMethod(movement.FirstCharToUpper());
                methodInfo.Invoke(robot, null);
            }
            catch(Exception ex)
            {

            }

        }
        public string Report()
        {
            return robot.Report();
        }
    }
}
