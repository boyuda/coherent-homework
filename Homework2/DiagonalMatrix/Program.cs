using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var diagonalNumbers = new Matrix(1,2,3,4,5,6,7,8);
                var diagonalNumbers2 = new Matrix(8, 1, 2, 3, 6, 7 );

               // var myMatrix = diagonalNumbers.CreateDiagonalMatrix();
                diagonalNumbers.Track();

                //Testing function to display Matrix on the console
                
                diagonalNumbers.print();
                //diagonalNumbers2.print();

                //Testing equals
                Console.WriteLine(diagonalNumbers.Equals(diagonalNumbers2));
                Console.WriteLine(diagonalNumbers.ToString(diagonalNumbers2));
              // diagonalNumbers.
            }
        }
    }
}

