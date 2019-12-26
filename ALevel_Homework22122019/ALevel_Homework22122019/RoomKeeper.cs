using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{

    public class RoomKeeper
    {
        public List<Room> newPerson = new List<Room>();
       

        public void Add(Room person)
        {
            newPerson.Add(person);
        }
    }
}
