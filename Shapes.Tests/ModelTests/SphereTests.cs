using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void GetArea_GetArea_50ish()
        {
            Circle newCircle = new Circle(2);
            Sphere newSphere = new Sphere(newCircle);
            double result = newSphere.GetArea();
            Assert.AreEqual(result, 50.28);
        }
        [TestMethod]
        public void GetVolume_GetVolume_33ish()
        {
            Circle newCircle = new Circle(2);
            Sphere newSphere = new Sphere(newCircle);
            double result = newSphere.GetVolume();
            Assert.AreEqual(result, 33.51);
        }

    }
}