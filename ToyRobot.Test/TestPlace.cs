using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.App.Entities;

namespace ToyRobot.Test
{
    [TestClass]
    public class TestPlace
    {
        [TestMethod]
        public void ValidLocationsForFiveByFiveTable()
        {
            Table table = new Table(5, 5);
            Assert.IsTrue(table.IsValidLocation(0, 0), "(0, 0) is Valid");
            Assert.IsTrue(table.IsValidLocation(4, 4), "(4, 4) is Valid");
            Assert.IsFalse(table.IsValidLocation(5, 5), "(5, 5) is Not Valid");
            Assert.IsFalse(table.IsValidLocation(-1, -1), "(-1, -1) Not Valid");
        }
    }
}
