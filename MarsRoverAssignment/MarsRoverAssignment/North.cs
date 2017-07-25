using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
    public class North :IDirection
    {
        public string Name { get; }
       public North()
        {
            this.Name = "North";
        }
        public IDirection TurnLeft()
        {
            return new West();
        }

        public IDirection TurnRight()
        {
            return new East();
        }
    }
}
