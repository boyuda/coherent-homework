using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
    class Matrix
    {
        public int[] DiagonalNumbers { get; set; }
        public int Size { get; private set; }
        public int[,] DiagonalMatrix { get; set; }


        public Matrix(params int[] diagonalNumbers)
        {
            //Storing numbers in one-dimmensional array and applying Size for the Matrix
            this.DiagonalNumbers = diagonalNumbers;

            if (diagonalNumbers == null)
            {
                Size = 0;
            }
            else
            {
                foreach (var n in diagonalNumbers)
                {
                    Size++;
                }

                //Creating Matrix with Diagonal Numbers   
                int[,] DiagonalMatrix = new int[Size, Size];

                for (int row = 0; row < Size; row++)
                {
                    for (int column = 0; column < Size; column++)
                    {
                        if (row == column)
                        {
                            DiagonalMatrix[row, column] = DiagonalNumbers[row];
                        }
                    }
                }
                this.DiagonalMatrix = DiagonalMatrix;

            }   

        }

        //Displays Matrix -- For testing purposes. 
        public void print()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(DiagonalMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }





        //Calculating the sum of the diagonal numbers
        public int Track()
        {
            var sum = 0;
            foreach (var number in DiagonalNumbers)
            {
                sum += number;
            }

            return sum;
        }

        //Overriding Equals method to compare 2 matrixes
        public override bool Equals(object obj)
        {
            if ((Size == ((Matrix)obj).Size))
            {
                for (int i = 0; i < Size; i++)
                {
                    if (DiagonalNumbers[i] == ((Matrix)obj).DiagonalNumbers[i])
                    {
                        continue;   
                    } 
                    else
                    {
                        return false;
                    }

                }
                return true;
            }

            return false;

        }

        //Adding ToString Overload to compare 2 matrixes
        public string ToString(object obj)

        {
            if ((Size == ((Matrix)obj).Size))
            {
                for (int i = 0; i < Size; i++)
                {
                    if (DiagonalNumbers[i] == ((Matrix)obj).DiagonalNumbers[i])
                    {
                        continue;
                    }
                    else
                    {
                        return "False";
                    }

                }
                return "True";
            }

            return "False";

        }



       
        //Adding extension method to sum up two matrixes
        public static void SumOfMatrix(int[,] matrixOne, int[,] matrixTwo)
        {
            var matrixOneSize = matrixOne.GetLength(1);
            var matrixTwoSize = matrixTwo.GetLength(1);

            if (matrixOneSize < matrixTwoSize)
            {
                int[,] MatrixSum = new int[matrixTwoSize, matrixTwoSize];

                for (int row = 0; row < matrixTwoSize; row++)
                {
                    for (int column = 0; column < matrixTwoSize; column++)
                    {
                        MatrixSum[row, column] += matrixTwo[row, column];
                        
                        Console.Write(MatrixSum[row, column] + " ");
                    }
                    Console.WriteLine();
                }
            } 
            else if (matrixOneSize>matrixTwoSize)
            {
                int[,] MatrixSum = new int[matrixOneSize, matrixOneSize];

                for (int row = 0; row < matrixOneSize; row++)
                {
                    for (int column = 0; column < matrixOneSize; column++)
                    {
                        MatrixSum[row, column] += matrixOne[row, column];

                        Console.Write(MatrixSum[row, column] + " ");
                    }
                    Console.WriteLine();
                }
            } 
            else
            {
                int[,] MatrixSum = new int[matrixOneSize, matrixOneSize];

                for (int row = 0; row < matrixOneSize; row++)
                {
                    for (int column = 0; column < matrixOneSize; column++)
                    {
                        MatrixSum[row, column] = matrixOne[row, column] + matrixTwo[row, column];

                        Console.Write(MatrixSum[row, column] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
        
    }

}
