using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_homewok221212019
{
    public class RoomKeeper
    {
        public List<Room> rooms = new List<Room>()
        {
            new Room
            {
                Name = "Room 1",
                Capasity = 15
            },
            new Room
            {
                Name = "Room 2",
                Capasity = 7
            }
        };
    }
}
