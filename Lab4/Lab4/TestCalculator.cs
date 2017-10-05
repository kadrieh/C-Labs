using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class TestCalculator
    {
        public static void Main()
        {
            bool check = true;
            double number1 = 0;
            double number2 = 0;
            do
            {
                try
                {
                    Console.Write("Enter  number 1 ");
                    number1 = Double.Parse(Console.ReadLine());
                    check = true;
                }
                catch (FormatException)
                {
                    check = false;
                    Console.WriteLine("Enter a valid number");
                }
                catch (OverflowException)
                {
                    check = false;
                }
            } while (!check);

            do
            {
                try
                {
                    Console.Write("Enter the number 2 ");
                    number2 = Double.Parse(Console.ReadLine());
                    check = true;
                }
                catch (FormatException)
                {
                    check = false;
                }
                catch (OverflowException)
                {
                    check = false;
                }
            } while (!check);
            Console.WriteLine(Calculator.DivideFloat(number1, number2));
            Console.Read();
        }

    }
}
