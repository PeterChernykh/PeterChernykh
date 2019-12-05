using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hometask_2Library;

namespace TaskAboutSkier_1
{
    class TaskAboutSkier
    {
         static void Main(string[] args)
        {  

            bool check = false;
            int menuChoise; 

            while (!check)
            {
                Console.WriteLine("\n 1.View result table \n 2.Add new result \n 3.Exit");

                while (!int.TryParse(Console.ReadLine(), out menuChoise) || menuChoise < 1 || menuChoise >3)
                    Console.WriteLine("Incorrect number. Please use numbers from 1 to 3");

                switch (menuChoise)
                {
                    case 1:
                        Console.WriteLine();
                        PrintResults();
                        break;
                    case 2:
                        var addNewResult = SportResult();
                        ResultKeeper.Add(addNewResult);
                        break;
                    case 3:
                        return;
                } 
            }
        }
        static TrainingProcess SportResult()
        {
            Console.WriteLine("Please enter the name of the sportsman");
            string sportsmanName = Console.ReadLine();
            Console.WriteLine("Please enter the total distance that the sportsman should overcome");
            double finalDistance = Hometask_2Library.HW2Library.InValidation(Console.ReadLine());
            Console.WriteLine("Please enter the value of the distance that the sportsman overcame on the first day");
            double firstDay = Hometask_2Library.HW2Library.InValidation(Console.ReadLine());
            Console.WriteLine("Please enter the number of percent the athlete's performance increased in comparison to the previous day");
            double progressPerDay = Hometask_2Library.HW2Library.InValidation(Console.ReadLine());

            var result = new TrainingProcess(firstDay, progressPerDay, finalDistance, sportsmanName);
            // Console.WriteLine("Start again? y/n");
            // if (Console.ReadKey(true).Key != ConsoleKey.Y)

            return result;
        }


        static void PrintResults()
        {
            if (ResultKeeper.Results.Any())
            {
                foreach (var result in ResultKeeper.Results)
                    Console.WriteLine(result.ToString());
            }
        }
    }
}
