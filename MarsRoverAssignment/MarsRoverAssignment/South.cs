using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
    public class South : IDirection
    {
        public string Name { get; }
       public South()
        {
            this.Name = "South";
        }
        public IDirection TurnLeft()
        {
           return new East();
        }

        public IDirection TurnRight()
        {
            return new West();
        }
    }
}
