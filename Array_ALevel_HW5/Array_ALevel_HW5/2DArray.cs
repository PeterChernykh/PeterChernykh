using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayClassLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the matrix size");
            int massiveSize = (Convert.ToInt32(Console.ReadLine()));
            int[,] randomMassive = new int[massiveSize, massiveSize];
            ArrayLibrary.MassiveCreator(randomMassive, massiveSize);

            bool check = false;
            int menuChoice;

            while (!check)
            {
                Console.WriteLine("\n 1.View massive \n 2.Add new massive \n 3.Upper matrix triangle \n 4.Lower matrix triangle \n 5.Transporate the matrix \n 6.Exit");

                while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 6)
                    Console.WriteLine("Incorrect number. Please use numbers from 1 to 6");

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine();
                        ArrayLibrary.DisplyMatrix(randomMassive, massiveSize);
                        break;


                    case 2:
                        Console.WriteLine("Please enter new N to create a new matrix");
                        massiveSize = Convert.ToInt32(Console.ReadLine());
                        randomMassive = new int[massiveSize, massiveSize];
                        ArrayLibrary.MassiveCreator(randomMassive, massiveSize);
                        break;

                    case 3:
                        ArrayLibrary.UpperMatrixTri(randomMassive, massiveSize, massiveSize);
                        break;

                    case 4:
                        ArrayLibrary.LowerMatrixTri(randomMassive, massiveSize, massiveSize, massiveSize);
                        break;

                    case 5:
                        ArrayLibrary.MatrixTransporation(randomMassive, massiveSize);
                        break;

                    case 6:
                        return;
                }

            }

        }
    }
}
