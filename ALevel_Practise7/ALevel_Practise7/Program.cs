using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Practise7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            int menuChoice;

            while (!check)
            {
                Console.WriteLine("Please choose the required option \n 1.Add new sportsman \n 2. Show process \n 3. Exit");
                while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 3)
                    Console.WriteLine("Incorrect number. Please use numbers from 1 to 3");

                switch (menuChoice)
                {
                    case 1:
                    var addPerson =AddNewVisitors();
                    VisitorsKeeper.Add(addPerson);
                        

                        break;
                    case 2: 
                       ShowProcess();
                        break;
                    case 3:
                        return;
                }
            }

        }
        static Sportsman AddNewVisitors()
        {
            Console.WriteLine("Please enter the name of the person");
            var personName = Console.ReadLine();
            Console.WriteLine("Please enter the amount of the exersices");
            var amountOfExercises = int.Parse(Console.ReadLine());

            var sportsmanKeeper = new Sportsman(personName, amountOfExercises);

            return sportsmanKeeper;
        }

        static void ShowProcess()
        {
            if (VisitorsKeeper.Visitor.Any())
            {
                foreach (var sportsman in VisitorsKeeper.Visitor)
                {
                    sportsman.exercisesLeft--;

                }
                VisitorsKeeper.Visitor.RemoveAll(sportsman => sportsman.exercisesLeft.Equals(-1));//RemoveAll удаляет все, в скобках мы задаем условия при которых эти "все" будут удалены Equals(-1)
                //(значит, что когда значение exercisesLeft будет -1, то этот элемент будет удален с листа)
                foreach (var sportsman in VisitorsKeeper.Visitor)
                {
                    Console.WriteLine(sportsman.ToString());

                }
            }
        }

    }
}
