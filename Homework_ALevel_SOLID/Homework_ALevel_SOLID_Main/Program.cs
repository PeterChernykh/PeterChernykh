using Homework_ALevel_SOLID.O.O_Correct;
using System;
using System.Collections.Generic;

using Homework_ALevel_SOLID.L;

namespace Homework_ALevel_SOLID_Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            var drawCircle = new DrawCircle();
            var drawSquare = new DrawSquare();

            var draw = new DrawFigure(drawCircle);
            draw.Draw();
            var draw1 = new DrawFigure(drawSquare);
            draw1.Draw();


           
        }
    }
}
