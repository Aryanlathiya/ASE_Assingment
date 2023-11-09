using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Applicatiom_1;


namespace ASE_Assingment_Unittest
{
    [TestClass]
    public class UnitTest1
    {
        Shape_Control control = new Shape_Control();


        [TestMethod]
        public void TestSquare()
        {
            control.DrawSquare(50);
            Assert.IsTrue(Shape_Values.isUnitTestValid);
        }

        [TestMethod]
        public void TestTriangle()
        {
            control.DrawTriangle(50, 100, 150);
            Assert.IsTrue(Shape_Values.isUnitTestValid);
        }

        [TestMethod]
        public void TestRectangle()
        {
            control.DrawRectangle(50, 100);
            Assert.IsTrue(Shape_Values.isUnitTestValid);
        }

        [TestMethod]
        public void TestCircle()
        {
            control.DrawCircle(100);
            Assert.IsFalse(Shape_Values.isUnitTestValid);
        }

        [TestMethod]
        public void TestDrawLine()
        {
            control.DrawLine(50, 100);
            Assert.IsTrue(Shape_Values.isUnitTestValid);
        }

        [TestMethod]
        public void TestMove()
        {
            control.MovePointer(50, 200);
            Assert.IsTrue(Shape_Values.isUnitTestValid);
        }

    }
}
