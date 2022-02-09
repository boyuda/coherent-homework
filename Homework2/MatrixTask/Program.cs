using System;

namespace MatrixTask
{
    class Program
    {


        //Entry Point
        static void Main(string[] args)
        {
            var matrixOne = new Matrix<int>(5);
            var matrixTwo = new Matrix<int>(5);
            var matrixTracker = new MatrixTracker<int>(matrixOne);

            matrixTwo[0, 0] = 5;
            matrixOne[0, 0] = 5;
            matrixOne[0, 0] = 7;
            matrixTracker.Undo();
            matrixOne[0, 0] = 8;

            //Sum of two integer Matrixes + passing instruction IntSum. 
            matrixOne.MatrixSum(matrixTwo, IntSum);
        }

        //Instructions on how to SUM two INT matrixes. 
        public static Matrix<int> IntSum(Matrix<int> matrixOne, Matrix<int> matrixTwo)
        {
            int Size = matrixOne.Size >= matrixTwo.Size ? matrixOne.Size : matrixTwo.Size;
            var matrixSumDiagonal = new Matrix<int>(Size);

            for (int i = 0; i < Size; i++)
            {
                matrixSumDiagonal[i, i] = matrixOne[i, i] + matrixTwo[i, i];
            }
            return matrixSumDiagonal;
        }
    }
}
