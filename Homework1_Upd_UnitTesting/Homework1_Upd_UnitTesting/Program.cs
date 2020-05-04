using Homework1_Upd_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_Upd_UnitTesting
{
    public class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            Homework1_Library library = new Homework1_Library();

            Console.WriteLine("Please enter the value of a");
            double a = program.InputChecker(Console.ReadLine());
            
            Console.WriteLine("Please enter the values of b");
            double b = program.InputChecker(Console.ReadLine());

            Console.WriteLine("Please enter the values of c");
            double c = program.InputChecker(Console.ReadLine());

            var disc = library.DiscriminantCalc(a, b, c);

            Console.WriteLine(library.Message);
            Console.WriteLine($"Square roots: {disc.x1}, {disc.x2}. Discriminant: {disc.d}");

            Console.ReadKey();
        }

        public double InputChecker(string input)
        {
            Homework1_Library inputValidation = new Homework1_Library();

            while (inputValidation.InputValidation(input).Equals(false))
            {
                var message = inputValidation.Message;
                Console.WriteLine(message);
                input = Console.ReadLine();
            }

            double value = inputValidation.ParseToDouble(input);

            return value;
        }
    }
}
