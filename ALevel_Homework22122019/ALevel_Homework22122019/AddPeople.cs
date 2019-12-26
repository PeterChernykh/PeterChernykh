using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{
    class AddPeople
    {
        public void AddToRoomFour()
        {
            Room availablePlacesFour = new Room();

            var maxStudentsFour = availablePlacesFour.MaxStudents();

            var isTeacher = new Teacher();

            isTeacher.NewTeacher();

            RoomKeeper currentlyInRoom = new RoomKeeper();

            while (currentlyInRoom.newPerson.Count < maxStudentsFour)
            {
                var addPerson = new Room();
                currentlyInRoom.newPerson.Add(addPerson);

                Console.WriteLine($"Currently in room {currentlyInRoom.newPerson.Count} people");
            }
        }

    }
}
