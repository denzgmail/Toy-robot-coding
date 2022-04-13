using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App.BL;
using ToyRobot.App.Entities;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestCommand
    {
        [TestMethod]
        public void PlaceCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5,5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 3,2,WEST");

            Assert.IsNotNull(command.movementSimulation.robot);
        }

        [TestMethod]
        public void InvalidPlaceCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 6,3,NORTH");

            Assert.AreSame(command._invalidInputText, command._message);
        }

        [TestMethod]
        public void MoveCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 2,3,EAST");
            command.ProcessCommand("MOVE");

            Robot expected = new Robot { Location = new Location { East = 3, North = 3, Direction = "east" } };

            Assert.AreEqual(expected.Location.East, command.movementSimulation.robot.Location.East);
        }

        [TestMethod]
        public void MoveWallIgnoreCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 4,4,EAST");
            command.ProcessCommand("MOVE");

            Robot expected = new Robot { Location = new Location { East = 4, North = 4, Direction = "east" } };

            Assert.AreEqual(expected.Location.East, command.movementSimulation.robot.Location.East);
        }

        [TestMethod]
        public void LeftCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 2,3,EAST");
            command.ProcessCommand("LEFT");

            Robot expected = new Robot { Location = new Location { East = 2, North = 3, Direction = "north" } };

            Assert.AreEqual(expected.Location.Direction, command.movementSimulation.robot.Location.Direction);
        }

        [TestMethod]
        public void RightCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 2,3,EAST");
            command.ProcessCommand("RIGHT");

            Robot expected = new Robot { Location = new Location { East = 2, North = 3, Direction = "south" } };

            Assert.AreEqual(expected.Location.Direction, command.movementSimulation.robot.Location.Direction);
        }

 
        [TestMethod]
        public void ReportCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("PLACE 3,3,EAST");
            command.ProcessCommand("REPORT");

            string expected = "3,3,EAST";

            Assert.AreEqual(expected, command._message);
        }

        [TestMethod]
        public void InvalidCommand()
        {
            RoboCommand command = new RoboCommand();
            Table table = new Table(5, 5);
            command.movementSimulation = new MovementSimulator(table);
            command.ProcessCommand("TESTING");

            string expected = command._invalidInputText;

            Assert.AreEqual(expected, command._message);
        }
    }
}
