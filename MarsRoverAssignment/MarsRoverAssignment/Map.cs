using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
    public class Map : IDirection
    {
        public int XCordinate
        {
            get
            {
                return XCordinate;
            }
            set
            {
                XCordinate = value;

            }
        }
        public int YCordinate
        {
            get
            {
                return YCordinate;
            }
            set
            {
                YCordinate = value;
            }
        }

        public string Name => this.Name;

        public object Direction { get; private set; }

        public List<int> get_coordinates(int X, int Y)
        {
            XCordinate = X;
            YCordinate = Y;
            return new List<int> { X, Y };
        }
        public IDirection TurnLeft()
        {
            return this.TurnLeft();
        }

        public IDirection TurnRight()
        {
            return this.TurnRight();
        }
    }
}
