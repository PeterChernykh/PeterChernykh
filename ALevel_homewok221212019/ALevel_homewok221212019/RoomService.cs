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
                return room.Capasity;//рум капасити пустой
            }

            throw new System.Exception($"User with role {person.GetType()} can make room revision");
        }

        public void AddPersonToRoom(Person person, Room room)//может изменить на рум киппер
        {
            var checkCapasity = new RoomKeeper();

            if (person.CanBeInRoom)
            {
                if (checkCapasity.rooms.Count< room.Capasity)//сравниваем значение капасити, которое мы указали и колличество айтемов в листе//откуда брать значение для сравнивания? room.Capasity пустой
                {

                    checkCapasity.rooms.Add(room);
                    Console.WriteLine($"Currently in room - {checkCapasity.rooms.Count} and can be up to {room.Capasity}");
                }
                else
                {
                    Console.WriteLine("There are no free places ");
                }
            }
            else
            {
               Console.WriteLine($"User with role {person.GetType()} cannot be in the room");
            }
        }

        //public int Capasity()
        //{
        //    Random rnd = new Random();
        //    int capasity = rnd.Next(7, 15);

        //    return capasity;
        //}
    }
}
