using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
    public class East : IDirection
    {
        public string Name { get; }
        public East()
        {
            this.Name = "East";
        }
        public IDirection TurnLeft()
        {
            return new North();
        }

        public IDirection TurnRight()
        {
            return new South();
        }
    }
}