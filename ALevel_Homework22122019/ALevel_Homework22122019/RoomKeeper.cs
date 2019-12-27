using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{

    public class RoomKeeper
    {
        public List<MaxStudent> newPerson = new List<MaxStudent>();
       
        public void Add(MaxStudent person)
        {
            newPerson.Add(person);
        }
    }
}
