using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App;
using ToyRobot.App.Entities;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestReport
    {
        [TestMethod]
        public void ReportLocation()
        {
            Robot robot = new Robot
            {
                Location = new Location
                {
                    Direction = "north",
                    East = 4,
                    North = 3
                }
            };

            string expected = "4,3,NORTH";

            string position = robot.Report();
            
            Assert.AreEqual(expected, position);
        }
    }
}
