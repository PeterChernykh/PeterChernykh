using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{
    class Admin
    {

        public int Revision(int availablePlaces)
        {
            Random rnd = new Random();
            availablePlaces = rnd.Next(7, 15);
            return availablePlaces;
        }
    }
}
