using System;

namespace DiagonalMatrix
{
    public static class Extension
    {
        public static void DiagonalMatrixSum(this Matrix matrixOne, Matrix matrixTwo)
        {
            var matrixOneSize = matrixOne.Size;
            var matrixTwoSize = matrixTwo.Size;

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
