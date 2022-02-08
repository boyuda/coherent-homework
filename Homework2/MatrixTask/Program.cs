using System;

namespace MatrixTask
{
    class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            var matrixOne = new Matrix<int>(5);
            matrixOne[0, 0] = 5;
            matrixOne[1, 1] = 5;
            matrixOne[2, 2] = 5;
            matrixOne[3, 3] = 5;
            matrixOne[4, 4] = 5;

            Console.WriteLine(matrixOne.Size);

        }
    }
}
