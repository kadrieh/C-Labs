using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Sphere : ThreeDShape
    {
        public double radius { get; set; }

        public double Radius()
        {
            return radius;
        }

        public Sphere(string type, double radius) : base(type)
        {
            if(radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                Console.WriteLine("Radius value must be positive.");
            }
        }
        public override double CalVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
