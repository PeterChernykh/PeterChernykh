using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_homewok221212019
{
    public class RoomService
    {
        public int GetRoomCapasityByRole(Person person, Room room)
        {
            if (person.CanMakeRoomRevision)
            {
                return room.Capasity;
            }

            throw new System.Exception($"User with role {person.GetType()} can make room revision");
        }

        public void AddPersonToRoom(Person person, Room room)
        {
            var checkCapasity = new RoomKeeper();

            if (person.CanBeInRoom)
            {
                if (room.Capasity< checkCapasity.rooms.Count)
                {

                    checkCapasity.rooms.Add(person);
                }
                else
                {
                    Console.WriteLine("There are no free places ");
                }
            }
            throw new System.Exception($"User woth role {person.GetType()} cannot be in the room");
        }

        //public int Capasity()
        //{
        //    Random rnd = new Random();
        //    int capasity = rnd.Next(7, 15);

        //    return capasity;
        //}
    }
}
