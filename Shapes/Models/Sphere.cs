using System;

namespace Shapes.Models
{
    public class Sphere
    {
        public Circle Slice {get; set;}

        public Sphere(Circle circleBoy)
        {
            Slice = circleBoy;
        }

        public double GetArea()
        {
            return Math.Round(4 * Slice.GetArea(), 2);
        }

        public double GetVolume()
        {
            int radius = Slice.Radius;
            return Math.Round((4*(Math.PI*(Math.Pow(radius, 3))))/3, 2);
        }
    }
}