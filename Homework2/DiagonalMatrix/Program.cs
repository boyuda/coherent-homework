using System;

namespace DiagonalMatrix
{
    class Program
    {
        //Starting point
        static void Main(string[] args)
        {

            //Creating two diagonal matrixes
            var firstMatrix = new Matrix(1, 2, 3, 4, 5);
            var secondMatrix = new Matrix(1, 2, 3, 4, 5);

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

