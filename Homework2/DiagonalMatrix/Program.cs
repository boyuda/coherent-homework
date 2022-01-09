using System;

namespace DiagonalMatrix
{
    class Program
    {
        //Starting point
        static void Main(string[] args)
        {

            //Creating two diagonal matrixes
            var firstMatrix = new Matrix(1, 5, 3, 9, 5);
            var secondMatrix = new Matrix(1, 7, 8, 4, 5);

            

            //Sum of diagonal numbers
            firstMatrix.Track();

            //Equal and ToString Override
            Matrix.Equals(firstMatrix, secondMatrix);
            firstMatrix.ToString(secondMatrix);

            //Diagonal Matrix extension
            firstMatrix.DiagonalMatrix.DiagonalMatrixSum(secondMatrix.DiagonalMatrix);

        }
    }

}

