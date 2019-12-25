using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{
    public class Teacher
    {
        public void NewTeacher()
        {
         Random rnd = new Random();
         int newTeacher = rnd.Next(0, 1);

        }
        public void IsTeacherHere(int newTeacher)
        {
            RoomKeeper teacher = new RoomKeeper();

            if (newTeacher == 1)
            {
                var addTeacher = new Room4();
                teacher.Add(addTeacher);

                Console.WriteLine("The teacher is already in the room");
            }
            else
            {
                Console.WriteLine("There is no teacher in the room");
            }
        }
    }
}
