using System;

namespace MatrixTask
{
    class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            var matrixOne = new Matrix<int>(5);
            var matrixTwo = new Matrix<string>(5);
            var matrixTracker = new MatrixTracker<int>(matrixOne);

            matrixTwo[0, 0] = "Test";
            matrixOne[0, 0] = 5;
            matrixOne[0, 0] = 6;





            Console.WriteLine(matrixOne.Size);

        }

    }
}
