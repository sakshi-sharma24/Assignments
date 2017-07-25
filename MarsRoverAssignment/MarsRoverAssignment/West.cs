using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
    public class West : IDirection
    {
       public string Name { get; }
       public West()
        {
            this.Name = "West";
        }

        public IDirection TurnLeft()
        {
            return new South ();
        }

        public IDirection TurnRight()
        {
            return new North();
        }
    }
}
