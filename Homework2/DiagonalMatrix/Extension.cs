using System;

namespace DiagonalMatrix
{
    public static class Extension
    {
        public static Matrix DiagonalMatrixSum(this Matrix matrixOne, Matrix matrixTwo)
        {
            int newMatrixSize = matrixOne.Size >= matrixTwo.Size ? matrixOne.Size : matrixTwo.Size;
            int[] matrixSumDiagonal = new int[newMatrixSize];

            for (int i = 0; i < newMatrixSize; i++)
            {
                matrixSumDiagonal[i] = matrixOne[i, i] + matrixTwo[i, i];
            }

            return new Matrix(matrixSumDiagonal);
        }
        
    }
}
