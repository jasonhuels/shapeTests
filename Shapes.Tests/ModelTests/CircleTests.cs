using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetDiameter_GetDiameter_4()
        {
            Circle newCircle = new Circle(2);
            int result = newCircle.GetDiameter();
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void GetArea_GetArea_113()
        {
            Circle newCircle = new Circle(6);
            double result = newCircle.GetArea();
            Assert.AreEqual(result, 113.10);
        }
        [TestMethod]
        public void GetCircumference_GetCircumference_25()
        {
            Circle newCircle = new Circle(4);
            double result = newCircle.GetCircumference();
            Assert.AreEqual(result, 25.13);
        }
    }
}