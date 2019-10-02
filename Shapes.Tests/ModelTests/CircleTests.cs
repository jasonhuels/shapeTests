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
    }
}