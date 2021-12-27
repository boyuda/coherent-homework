using System;

namespace DiagonalMatrix
{
    public static class Extension
    {
        public static void DiagonalMatrixSum(this int[,] matrixOne, int[,] matrixTwo)
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
                    }
                }
            }
            else if (matrixOneSize > matrixTwoSize)
            {
                int[,] MatrixSum = new int[matrixOneSize, matrixOneSize];

                for (int row = 0; row < matrixOneSize; row++)
                {
                    for (int column = 0; column < matrixOneSize; column++)
                    {
                        MatrixSum[row, column] += matrixOne[row, column];
                    }
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
                    }
                }
            }

        }

    }
}
