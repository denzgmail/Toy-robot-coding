using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;
using ToyRobot.App;
using ToyRobot.App.Entities;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestTurn
    {
        [TestMethod]
        public void TurnLeftWhenFacingNorth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "north" } };
            robot.Left();
            Assert.AreEqual("west", robot.Location.Direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingNorth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "north" } };
            robot.Right();
            Assert.AreEqual("east", robot.Location.Direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingEast()
        {
            Robot robot = new Robot { Location = new Location { Direction = "east" } };
            robot.Left();
            Assert.AreEqual("north", robot.Location.Direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingEast()
        {
            Robot robot = new Robot { Location = new Location { Direction = "east" } };
            robot.Right();
            Assert.AreEqual("south", robot.Location.Direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingSouth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "south" } };
            robot.Left();
            Assert.AreEqual("east", robot.Location.Direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingSouth()
        {
            Robot robot = new Robot { Location = new Location { Direction = "south" } };
            robot.Right();
            Assert.AreEqual("west", robot.Location.Direction);
        }

        [TestMethod]
        public void TurnLeftWhenFacingWest()
        {
            Robot robot = new Robot { Location = new Location { Direction = "west" } };
            robot.Left();
            Assert.AreEqual("south", robot.Location.Direction);
        }

        [TestMethod]
        public void TurnRightWhenFacingWest()
        {
            Robot robot = new Robot { Location = new Location { Direction = "west" } };
            robot.Right();
            Assert.AreEqual("north", robot.Location.Direction);
        }

    }
}
