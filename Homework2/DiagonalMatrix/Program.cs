using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var diagonalNumbers = new Matrix(8, 1, 2, 3, 6);
                Console.WriteLine(diagonalNumbers.Track());

                Console.WriteLine(diagonalNumbers.Size);


                //Testing the code to change Diagonal Values

                var newArray = new int[diagonalNumbers.Size, diagonalNumbers.Size];
                int[] num = { 8, 1, 2, 3, 6 };



                //Testing function to display Matrix on the console

                static void print(int[,] matrix, int size)
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }

                        Console.WriteLine();
                    }
                }


                print(diagonalNumbers.CreateDiagonalMatrix(),5);


                //print(newArray, diagonalNumbers.Size);
            }
        }
    }
}

