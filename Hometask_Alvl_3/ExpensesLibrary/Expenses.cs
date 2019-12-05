using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesLibrary
{
    public class ExpensesKeeper
    {
        public static List<ExpensesPerMonthCalculation> Expenses = new List<ExpensesPerMonthCalculation>();

        public static void Add(ExpensesPerMonthCalculation expenses)
        {
            Expenses.Add(expenses);
        }
        public static void Remove(ExpensesPerMonthCalculation expenses)
        {
            Expenses.Remove(expenses);
        }
    }
    public class ExpensesPerMonthCalculation
    {
        public double SalaryPerMonth { get; set; }
        public double ExpensesToFood { get; set; } // In percent already
        public double ExpensesToSport { get; set; } // In percent already
        public double ExpensesToCommunalPayments { get; set; } // In percent already
        public double TotalExpensesPerMonth { get; set; }

        public ExpensesPerMonthCalculation(double expensesToFood, double expensesToSport, double expensesToCommunalPayments, double salaryPerMonth)
        {
            this.TotalExpensesPerMonth = expensesToFood + expensesToCommunalPayments + expensesToSport;

            this.ExpensesToCommunalPayments = 100 / (this.TotalExpensesPerMonth / expensesToCommunalPayments);
            this.ExpensesToFood = 100 / (this.TotalExpensesPerMonth / expensesToFood);
            this.ExpensesToSport = 100 / (this.TotalExpensesPerMonth / expensesToSport);
            this.SalaryPerMonth = salaryPerMonth;
        }

        public override string ToString()
        {
            return $"Total expenses per month : {TotalExpensesPerMonth} " +
                   $"expenses to food : {ExpensesToFood:F2} %;" +
                   $"expenses to sport : {ExpensesToSport:F2} %;" +
                   $"expenses to communal payments : {ExpensesToCommunalPayments:F2}. %" +
                   $"Rest of salary: {SalaryPerMonth - TotalExpensesPerMonth:F2}";
        }

        public static int MonthOfTheYear(int monthOfTheYear)
        {
            if (monthOfTheYear < 1)
                monthOfTheYear = 1;
            else if (monthOfTheYear > 12)
                monthOfTheYear = 12;
            switch (monthOfTheYear)
            {
                case 1:
                    {
                        Console.WriteLine("January");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("February");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("March");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("April");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("May");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("June");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Jule");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("August");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("September");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("October");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("November");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("December");
                        break;
                    }
            }

            return monthOfTheYear;
        }
    }
}
