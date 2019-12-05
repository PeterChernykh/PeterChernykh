using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantCalculation
{
    public class DiscriminantCalculation
    {
        private static double inputValidation(string input)
        {
            {
                double result;
                while (!double.TryParse(input, out result))
                {
                    Console.WriteLine("This is not a number!");
                    input = Console.ReadLine();
                }

                return result;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value of a");
            var a = inputValidation(Console.ReadLine());

            Console.WriteLine("Please enter the values of b");
            var b = inputValidation(Console.ReadLine());

            Console.WriteLine("Please enter the values of c");
            var c = inputValidation(Console.ReadLine());

            discriminantCalculation(a, b, c);
        }
        static void discriminantCalculation(double a, double b, double c)
        {
            double D;
            D = (Math.Pow(b, 2) - 4 * a * c);

            Console.WriteLine("discriminant = {0} ", D);
            double x1, x2;

            if (D < 0)
            {
                Console.WriteLine("There are no square roots");
            }
            else if (D == 0)
            {
                Console.WriteLine("There is only one square root x1");
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"The correct answer is x1 = {x1}");
            }
            else
            {
                Console.WriteLine("There are two square roots");
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"The correct answer is x1 = {x1} x2 = {x2}");

                Console.WriteLine("{0}*x*x+{1}*x+{2}={0}*(x-{3})*(x-{4})", a, b, c, x1, x2);
            }
        }
    }
}
