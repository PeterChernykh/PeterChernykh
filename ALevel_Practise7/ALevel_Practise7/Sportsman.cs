using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Practise7
{
    class VisitorsKeeper
    {
        public static List<Sportsman> Visitor = new List<Sportsman>();
        public static void Add(Sportsman visitors)
        {
            Visitor.Add(visitors);
        }
        public static void Remove(Sportsman visitor)
        {
            Visitor.Remove(visitor);
        }
    }

    class Sportsman
    {
        public string name { get; set; }
        public int amountOfExcersices { get; set; }
        public string reaction { get; set; }
        public int exercisesLeft { get; set; }

        public Sportsman(string name, int amountOfExcersices)
        {
            this.name = name;
            this.amountOfExcersices = amountOfExcersices;
            this.exercisesLeft = exercisesLeft = amountOfExcersices;
            this.reaction = reaction;

        }

        public override string ToString()
        {
            if (exercisesLeft > 0)
            {
                reaction = "Why so long?";
            }
            else
            {
                reaction = "The client finished the exersices";

            }
                return $" Sportsman: {name} \n" +
                       $"Total amount of the exercises {amountOfExcersices}\n" +
                       $"Exercises left {exercisesLeft} \n" +
                       $"{reaction} \n";
        }
    }
}