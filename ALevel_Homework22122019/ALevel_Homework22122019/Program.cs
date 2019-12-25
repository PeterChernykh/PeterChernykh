using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddPeople LearningProcess = new AddPeople();

            LearningProcess.AddToRoomFour();
            LearningProcess.AddToRoomThree();
            LearningProcess.AddToRoomTwo();
            LearningProcess.AddToRoomOne();
        }
    }
}
