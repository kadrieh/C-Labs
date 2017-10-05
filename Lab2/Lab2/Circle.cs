/**
 * X00114185
 * Kadrieh Mohamadzadeh
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Circle : Shape
    {
        private int radius;
        private Vertex origin;

        public Circle(int x1, int y1, int radius, string colour) : base(colour)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public int X
        {
            get
            {
                return origin.X;
            }

            set
            {
                origin.X = value;
            }
        }


        public int Y
        {
            get
            {
                return origin.Y;
            }

            set
            {
                origin.Y = value;
            }
        }
        public override string ToString()
        {
            return "A" + Color + " Circle at " + X + "," + Y + " radius " + Radius + " area " + this.Area();
        }


        public double Area()
        {
            return Math.PI * (radius * radius);
        }
        public override void Translate(Vertex v)
        {
            origin.X += v.X;
            origin.Y += v.Y;
        }

    }
}
