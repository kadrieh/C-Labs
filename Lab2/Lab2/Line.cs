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
    public class Line : Shape
    {
        //public int a;
        //public int b;
        private Vertex v1;
        private Vertex v2;

        public Line(int x1, int y1, int x2, int y2, string color) : base(color)
        {
            v1 = new Vertex(x1, y1);
            v2 = new Vertex(x2, y2);
        }

        //public Vertex V1
        //{
        //    //get { return v1.X; }
        //    get => v1.X;  set { v1 = value; }
        //}

        //public Vertex V2
        //{
        //    get { return v2; }
        //    set { v2 = value; }
        //}
        public int X1
        {
            get
            {
                return v1.X;
            }

            set
            {
                v1.X = value;
            }
        }


        public int Y1
        {
            get
            {
                return v1.Y;
            }

            set
            {
                v1.Y = value;
            }
        }

        public int X2
        {
            get
            {
                return v2.X;
            }

            set
            {
                v2.X = value;
            }
        }

        public int Y2
        {
            get
            {
                return v2.Y;
            }

            set
            {
                v2.Y = value;
            }
        }
        public override string ToString()
        {
            return "A " + Color + " Line from "+  X1 + " and " + Y2 + " to " + X2 + Y2+ "\n";
        }

        public override void Translate(Vertex amount)
        {
            v1.X += amount.X;
            v2.X += amount.X;
            v1.Y += amount.Y;
            v2.Y += amount.Y;
        }
    }
}

