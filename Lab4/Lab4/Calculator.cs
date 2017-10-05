using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Calculator
    {
        public static double DivideFloat(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new AccessViolationException("cannot divide by 0");
            }
            else
            {
                return num1 / num2;
            }
        }
    }

}

