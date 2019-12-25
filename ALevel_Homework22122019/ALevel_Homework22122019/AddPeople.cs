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
            Room4 availablePlacesFour = new Room4();

            var maxStudentsFour = availablePlacesFour.MaxStudents();

            var isTeacher = new Teacher();

            isTeacher.NewTeacher();

            RoomKeeper currentlyInRoom = new RoomKeeper();

            while (currentlyInRoom.newPersonForth.Count < maxStudentsFour)
            {
                var addPerson = new Room4();
                currentlyInRoom.newPersonForth.Add(addPerson);

                Console.WriteLine($"Currently in room #4 {currentlyInRoom.newPersonForth.Count} people");
            }
        }

        public void AddToRoomThree()
            {
            Room3 availablePlacesThree = new Room3();

            var maxStudentsThree = availablePlacesThree.MaxStudents();

            var isTeacher = new Teacher();

            isTeacher.NewTeacher();

            RoomKeeper currentlyInRoom = new RoomKeeper();

            while (currentlyInRoom.newPersonThird.Count < maxStudentsThree)
            {
                var addPerson = new Room3();
                currentlyInRoom.Add(addPerson);

                Console.WriteLine($"Currently in room #4 {currentlyInRoom.newPersonThird.Count} people");
            }
        }

        public void AddToRoomTwo()
        {
            Room2 availablePlaceSecond = new Room2();

            var maxStudentsTwo = availablePlaceSecond.MaxStudents();

            var isTeacher = new Teacher();

            isTeacher.NewTeacher();

            RoomKeeper currentlyInRoom = new RoomKeeper();

            while (currentlyInRoom.newPersonSecond.Count < maxStudentsTwo)
            {
                var addPerson = new Room2();
                currentlyInRoom.Add(addPerson);

                Console.WriteLine($"Currently in room #4 {currentlyInRoom.newPersonSecond.Count} people");
            }
        }
        public void AddToRoomOne()
        {
            Room1 availablePlaceFirst = new Room1();

            var maxStudentsOne = availablePlaceFirst.MaxStudents();

             var isTeacher = new Teacher();

            isTeacher.NewTeacher();

            RoomKeeper currentlyInRoom = new RoomKeeper();

            while (currentlyInRoom.newPersonSecond.Count < maxStudentsOne)
            {
                var addPerson = new Room1();
                currentlyInRoom.Add(addPerson);

                Console.WriteLine($"Currently in room #4 {currentlyInRoom.newPersonFirst.Count} people");
            }
        }
    }
}
