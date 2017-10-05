using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Test
    {
        static void Main()
        {
            IHasVolume i = new Sphere(10);
            Console.WriteLine(i.calcVolume());
            Console.Read();
        }
    }
}
