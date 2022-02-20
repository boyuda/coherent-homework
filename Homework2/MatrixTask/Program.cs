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
            matrixOne.MatrixSum(matrixTwo, matrixOne);
        }

        private static int IntSum(int elementOne, int elementTwo)
        {
            return elementOne + elementTwo;
        }
    }
}
