using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_homewok221212019
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Student student = new Student();

            student.Name = "Alex";

            RoomService actionInRoom = new RoomService();

            Room currentRoom = new Room();

            actionInRoom.GetRoomCapasityByRole(admin, currentRoom);



        }
    }
}
