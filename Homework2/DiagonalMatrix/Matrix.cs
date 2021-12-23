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
        public static int[,] SumOfMatrix(int[,] matrixOne, int[,] matrixTwo)
        {
            if (matrixOne.Length < matrixTwo.Length)
            {
                for (int row = 0; row < matrixOne.Length; row++)
                {
                    for (int column = 0; column < matrixOne.Length; column++)
                    {
                        matrixOne[row, column] = 0;
                    }
                }
            } 
            else if (matrixTwo.Length>matrixOne.Length)
            {
                for (int row = 0; row < matrixOne.Length; row++)
                {
                    for (int column = 0; column < matrixOne.Length; column++)
                    {
                        matrixTwo[row, column] = 0;
                    }
                }
            }

            int[,] MatrixSum = new int[matrixOne.Length, matrixOne.Length];
            for (int row = 0; row < matrixOne.Length; row++)
            {
                for (int column = 0; column < matrixOne.Length; column++)
                {
                    MatrixSum[row, column] = matrixOne[row, column] + matrixTwo[row, column];
                }
            }
            return MatrixSum;
        }
        
    }

}
