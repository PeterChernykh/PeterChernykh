using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ALevel_SOLID
{
    public class FormulaCircle_Correct
    {
        private const double p = 3.14;
        private double S;
        private double L;
        private double D;

        public double CircleArea(double r)
        {
            double S = p * Math.Pow(r, 2);

            return S;
        }

        public double CircumferenceLength(double r)
        {
            double L = 2 * (p * r);

            return L;
        }

        public double CircleDiameter(double r)
        {
            D = Math.Pow(r, 2);

            return D;
        }
    }

    public class Draw
    {
        public string DrawCircle()
        {
            return "Circle";
        }
    }
}
