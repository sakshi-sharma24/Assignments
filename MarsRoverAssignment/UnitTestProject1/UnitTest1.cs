using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverAssignment;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void If_In_North_Turn_Left()
        {
            North direction = new North();
            Assert.AreEqual("East",direction.TurnLeft());
        }
        public void If_in_North_Turn_Right()
        {
            North direction = new North();
            Assert.AreEqual("West", direction.TurnRight());
        }
        public void If_In_South_Turn_Left()
        {
            South direction = new South();
            Assert.AreEqual("West", direction.TurnLeft());
        }
        public void If_In_South_Turn_Right()
        {
            South direction = new South();
            Assert.AreEqual("East", direction.TurnLeft());
        }
        public void If_In_East_Turn_Left()
        {
            East direction = new East();
            Assert.AreEqual("North", direction.TurnLeft());
        }
        public void If_In_East_Turn_Right()
        {
            East direction = new East();
            Assert.AreEqual("South", direction.TurnLeft());
        }
        public void If_In_West_Turn_Left()
        {
            West direction = new West();
            Assert.AreEqual("South", direction.TurnLeft());
        }
        public void If_In_West_Turn_Right()
        {
            West direction = new West();
            Assert.AreEqual("North", direction.TurnLeft());
        }


    }
}
