using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sphere : IHasVolume
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value >= radius)
                {
                    radius = value;
                }
                else
                {
                    throw new AccessViolationException("Radius must be positive");
                }
            }
        }
        public double calcVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }

        public override String ToString()
        {
            return "Radius is" + Radius + "Volume is" + calcVolume();
        }
    }
}
