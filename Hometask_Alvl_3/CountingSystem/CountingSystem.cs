using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesLibrary;

namespace CountingSystem
{
    class CountingSystem
    {

        private static readonly IEnumerable<object> Expenses;

        static void Main(string[] args)
        {
            bool check = false;
            int menuChoice;

            while (!check)
            {
                Console.WriteLine("\n 1.View statistic \n 2.Add new item \n 3.Delete an item");

                while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 3)
                    Console.WriteLine("Incorrect number. Please use numbers from 1 to 3");

                switch (menuChoice)
                {
                    case 1:
                        PrintExpenses();
                        break;

                    case 2:
                        var addToList = ExpensesCalculation();
                        ExpensesKeeper.Add(addToList);
                        break;

                    case 3:
                        Console.WriteLine("Input value to be deleted");

   
                        Console.WriteLine("Input number of the record that should be delete");
                        int inputedNumber = int.Parse(Console.ReadLine()) - 1;

                        if (!(inputedNumber <= 0) && inputedNumber <= ExpensesKeeper.Expenses.Count)
                            ExpensesKeeper.Remove(ExpensesKeeper.Expenses[inputedNumber]);

                        else
                            Console.WriteLine("This number record does not exist!");

                        break;
                }
            }
        }

        static ExpensesPerMonthCalculation ExpensesCalculation()
        {
            Console.WriteLine("Please enter the number of month");
            var monthOfTheYear = ExpensesPerMonthCalculation.MonthOfTheYear(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Please enter value of your salary per month");
            var salaryPerMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, your salary per month is {0}", salaryPerMonth);

            Console.WriteLine("Please enter the expenses for each point \t 1.Food \t 2.Sport \t 3.CommunalPayments");
            var expToFood = Convert.ToDouble(Console.ReadLine());
            var expToSport = Convert.ToDouble(Console.ReadLine());
            var expToCommPay = Convert.ToDouble(Console.ReadLine());

            var expenses = new ExpensesPerMonthCalculation(expToFood, expToSport, expToCommPay, salaryPerMonth);

            return expenses;
        }

        static void PrintExpenses()
        {
            if (ExpensesKeeper.Expenses.Any())
            {
                foreach (var month in ExpensesKeeper.Expenses)
                    Console.WriteLine(month.ToString());
            }
        }

        private static bool IsNumber(string input)
        {
            foreach (var symbol in input)
                if (!char.IsNumber(symbol))
                    return false;
            return true;
        }
    }
}