using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
    public class Shape
    {

        private string color;

        public Shape(string color)
        {
            this.color = color;
        }
        public String Color
        {
            get { return color; }
            set { color = value; }
        }
        public override string ToString()
        {
            return "Colour is: " + Color + "\n";
        }

        public virtual void Translate(Vertex amount)
        { }
    }
}
