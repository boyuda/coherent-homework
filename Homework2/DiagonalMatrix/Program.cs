using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var diagonalNumbers = new DiagonalMatrix(8, 1, 2, 3, 6);
                Console.WriteLine(diagonalNumbers.Track());

                Console.WriteLine(diagonalNumbers.Size);


                //Testing the code to change Diagonal Values

                var newArray = new int[diagonalNumbers.Size, diagonalNumbers.Size];
                int[] num = { 8, 1, 2, 3, 6 };


                for (int row = 0; row < diagonalNumbers.Size; row++)
                {
                    for (int column = 0; column < diagonalNumbers.Size; column++)
                    {
                        if (row == column)
                        {
                            newArray[row, column] = num[row];

                        }
                    }

                }

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

                print(newArray, diagonalNumbers.Size);
            }
        }
    }
}

