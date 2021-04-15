using System;

namespace Geometry3D
{
    public class Sphere : I3DObject
    {
        private double radiusSphere;

        private const double piNumber = 3.14159;

        public Sphere(double radiusSphere)
        {
            this.radiusSphere = radiusSphere;
        }

        public double GetVolume()
        {
            return (4f / 3f) * piNumber * Math.Pow(radiusSphere, 3);
        }

        public string DebugVolume()
        {
            return "VOLUME = " + GetVolume().ToString("0.000");
        }
    }

    
}

