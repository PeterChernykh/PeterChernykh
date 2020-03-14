using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ALevel_SOLID.O.O_Correct
{
    public class DrawFigure
    {
        private readonly IDraw _draw;

        public DrawFigure(IDraw draw)
        {
            _draw = draw;
        }

        public void Draw()
        {
            _draw.Draw();
        }
    }
}
