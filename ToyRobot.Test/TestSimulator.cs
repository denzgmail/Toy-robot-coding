using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App.BL;
using ToyRobot.App.Entities;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestSimulator
    {
        [TestMethod]
        public void PlaceRobotValidLocation()
        {
            Table tableTop = new Table(4, 4);
            MovementSimulator instance = new MovementSimulator(tableTop);
            instance.Place(0, 0, "EAST");
            Robot validrobotInstance = new Robot
            {
                Location = new Location
                {
                    East = 0,
                    North = 0,
                    Direction = "east",
                }
            };

            Assert.AreEqual(validrobotInstance.Location.East, instance.robot.Location.East);
            Assert.AreEqual(validrobotInstance.Location.North, instance.robot.Location.North);
            Assert.AreEqual(validrobotInstance.Location.Direction, instance.robot.Location.Direction);
        }

        [TestMethod]
        public void PlaceRobotNotValidLocation()
        {
            Table tableTop = new Table(4, 4);
            MovementSimulator instance = new MovementSimulator(tableTop);
            instance.Place(5, 5, "WEST");

            Assert.IsNull(instance.robot);
        }
    }
}
