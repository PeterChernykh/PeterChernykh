using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_Upd_Library
{
    public class Homework1_Library
    {
        public string Message { get; set; }
        public double Value { get; set; }

        public bool InputValidation(string input)
        {
            bool result;

            if (NotNullValidation(input).Equals(false) || CheckIsNumber(input).Equals(false))
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        private bool NotNullValidation(string input)
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(input) == true)
            {
                Message = "Input cannot be null or white space";
                return false;
            }
            return result;
        }

        private bool CheckIsNumber(string input)
        {
            bool result = true;
            double value;

            if (!double.TryParse(input, out value))
            {
                Message = "This is not a number!";
                result = false;
            }
            Value = value;
            return result;
        }

        public double ParseToDouble(string input)
        {
            Double.TryParse(input, out double value);

            return value;
        }

        public (double x1, double x2, double d) DiscriminantCalc(double a, double b, double c)
        {
            double d, x1, x2;

            d = (Math.Pow(b, 2) - 4 * a * c);

            if (d < 0 || a == 0)
            {
                Message = "There are no square roots";
                x1 = 0;
                x2 = 0;
            }
            else if (d == 0)
            {
                Message = "There is only one square root x1";
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = 0;
            }
            else
            {
                Message = "There are two square roots";
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }

            var disc = (
                _x1: x1,
                _x2: x2,
                _d: d
                );

            return disc;
        }
    }
}
