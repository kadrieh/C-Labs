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
    class Test
    {
        static void Main()
        {
            Shape [] shapes = { new Line(1, 3, 5, 7, "Red"), new Circle(2,4,6,"Pink")};
            //Console.WriteLine(v.ToString());
            foreach(Shape s in shapes)
            {
                Console.WriteLine(s);
                s.Translate(new Vertex(10,10));
                Console.WriteLine(s.ToString());
                Console.Read();
            }
        }
    }
}
