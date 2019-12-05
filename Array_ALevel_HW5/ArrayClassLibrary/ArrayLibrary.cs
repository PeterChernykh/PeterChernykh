using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassLibrary
{
    public class ArrayLibrary
    {
        public static void MassiveCreator(int[,] nerRandomMassive, int newMassiveSize)
        {
            Random Ram = new Random();

            for (int i = 0; i < newMassiveSize; i++)
            {
                for (int j = 0; j < newMassiveSize; j++)
                {
                    nerRandomMassive[i, j] = Ram.Next(10, 99);
                }
            }
        }
        public static void DisplyMatrix(int[,] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void UpperMatrixTri(int[,] array, int length1, int length2)
        {
            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
                length2--;
            }

        }
        public static void LowerMatrixTri(int[,] array, int length1, int length2, int additionalLenght)
        {
            for (int i = 0; i < length1; i++)
            {
                for (int j = 0; j < length2; j++)
                {
                    if (j < additionalLenght)
                        Console.Write("  " + " ");
                    else
                        Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
                additionalLenght--;
            }
            Console.WriteLine();
        }
        public static void MatrixTransporation (int [,] array, int massiveSize)
        {
            {
                for (int j = 0; j < massiveSize; j++)
                {
                    for (int i = 0; i < massiveSize; i++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
