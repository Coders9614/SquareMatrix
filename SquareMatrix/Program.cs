
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMaxtric
{
    internal class Program
    {
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int size = matrix1.GetLength(0);
            int[,] resultMatrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return resultMatrix;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("====Assigment 3.2.1 2D array=======");
            Console.WriteLine("Enter the number of square Matrix(less than 5):");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[size, size];// size * size = square. 
            int[,] matrix2 = new int[size, size];
            Console.WriteLine("Enter the number of 1 st Matrix: ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($" element  [{i}], [{j}] : ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine($"Enter the number of 1 st Matrix:");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($" element  [{i}], [{j}] : ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());

                }

            }

            int[,] resultMatrix = AddMatrices(matrix1, matrix2);



            Console.WriteLine("\nThe First matrix is:");
            DisplayMatrix(matrix1);

            Console.WriteLine("\nThe Second matrix is:");
            DisplayMatrix(matrix2);

            Console.WriteLine("\nThe Addition of two matrices is:");
            Console.ReadKey();

        }
        static void DisplayMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}

