using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var diagonalNumbers = new Matrix(1, 2, 3, 4, 5);
            var diagonalNumbers2 = new Matrix(1, 2, 3, 4, 5);


            diagonalNumbers.Track();

            //Testing function to display Matrix on the console

            diagonalNumbers.print();


            //Testing equals
            Console.WriteLine(diagonalNumbers.Equals(diagonalNumbers2));
            Console.WriteLine(diagonalNumbers.ToString(diagonalNumbers2));
            Console.WriteLine("Size is {0}", diagonalNumbers.Size);


           // int[,] DiagonalMatrix = new int[5, 5];
            //DiagonalMatrix.Tracker(diagonalNumbers2);

            Matrix.Equals(diagonalNumbers2, diagonalNumbers);
           var resultasvienas = Matrix.SumOfMatrix(diagonalNumbers.DiagonalMatrix, diagonalNumbers2.DiagonalMatrix);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(resultasvienas[i, j] + " ");
                }

                Console.WriteLine();
            }


        }
    }

}

