using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App;
using ToyRobot.App.Entities;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestMove
    {
        [TestMethod]
        public void MoveTwoTimesEast()
        {
            Robot robot = new Robot { Location = new Location { Direction = "east" } };
            robot.Move();
            robot.Move();
            Assert.AreEqual(2, robot.Location.East);
        }

        [TestMethod]
        public void MoveThreeTimesEast()
        {
            Robot robot = new Robot { Location = new Location {Direction = "east" } };
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(3, robot.Location.East);
        }

        [TestMethod]
        public void MoveFourTimesEast()
        {
            Robot robot = new Robot { Location = new Location { Direction = "east" } };
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(4, robot.Location.East);
        }

        [TestMethod]
        public void MoveTwoTimesWest()
        {
            Robot robot = new Robot { Location = new Location { Direction = "west" } };
            robot.Move();
            robot.Move();
            Assert.AreEqual(-2, robot.Location.East);
        }

        [TestMethod]
        public void MoveThreeTimesWest()
        {
            Robot robot = new Robot { Location = new Location { Direction = "west" } };
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-3, robot.Location.East);
        }

        [TestMethod]
        public void MoveFourTimesWest()
        {
            Robot robot = new Robot { Location = new Location { Direction = "west" } };
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-4, robot.Location.East);
        }

        [TestMethod]
        public void MoveTwoTimesNorth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "north" } };
            robot.Move();
            robot.Move();
            Assert.AreEqual(2, robot.Location.North);
        }

        [TestMethod]
        public void MoveThreeTimesNorth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "north" } };
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(3, robot.Location.North);
        }

        [TestMethod]
        public void MoveFourTimesNorth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "north" } };
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(4, robot.Location.North);
        }

        [TestMethod]
        public void MoveTwoTimesSouth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "south" } };
            robot.Move();
            robot.Move();
            Assert.AreEqual(-2, robot.Location.North);
        }

        [TestMethod]
        public void MoveThreeTimesSouth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "south" } };
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-3, robot.Location.North);
        }

        [TestMethod]
        public void MoveFourTimesSouth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "south" } };
            robot.Move();
            robot.Move();
            robot.Move();
            robot.Move();
            Assert.AreEqual(-4, robot.Location.North);
        }
    }
}
