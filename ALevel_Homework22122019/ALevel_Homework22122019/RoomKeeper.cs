using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{

    public class RoomKeeper
    {
        public List<Room4> newPersonForth = new List<Room4>();
        public List<Room3> newPersonThird = new List<Room3>();
        public List<Room2> newPersonSecond = new List<Room2>();
        public List<Room1> newPersonFirst = new List<Room1>();

        public void Add(Room4 person)
        {
            newPersonForth.Add(person);
        }
        public void Add(Room3 person)
        {
            newPersonThird.Add(person);
        }
        public void Add(Room2 person)
        {
            newPersonSecond.Add(person);
        }
        public void Add(Room1 person)
        {
            newPersonFirst.Add(person);
        }
    }

}
