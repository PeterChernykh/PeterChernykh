using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{
    public class AddPeople
    {
        public void AddToRoom()
        {
            RoomKeeper currentlyInRoom = new RoomKeeper();

            MaxStudent availablePlaces = new MaxStudent();

            var maxStudents = availablePlaces.MaxStudents();

            while (currentlyInRoom.newPerson.Count < maxStudents)
            {
                var addPerson = new MaxStudent();
                currentlyInRoom.newPerson.Add(addPerson);

                Console.WriteLine($"Currently in room {currentlyInRoom.newPerson.Count} people");
            }
        }
    }
}
