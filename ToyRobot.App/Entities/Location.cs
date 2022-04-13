using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.App.Entities
{
    public class Location
    {
        public int East =0;
        public int North = 0;
        public string Direction;

        public void MoveEast()
        {
            this.East += 1;
        }
        public void MoveWest()
        {
            this.East -= 1;
        }
        public void MoveNorth()
        {
            this.North += 1;
        }
        public void MoveSouth()
        {
            this.North -= 1;
        }
    }
}
