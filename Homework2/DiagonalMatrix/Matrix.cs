using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
    class Matrix
    {
        public int[] DiagonalNumbers;
        public int Size { get; private set; }

        //Passing list of parameters to the constructor and creating size of an array;
        public Matrix(params int[] diagonalNumbers)
        {
            this.DiagonalNumbers = diagonalNumbers;

            if (diagonalNumbers == null)
            {
                Size = 0;
            }
            else
            {
                foreach (var n in diagonalNumbers)
                {
                    Size++;
                }
            }


        }

        //Creating empty Matrix and assigning diagonal values to it
        public int[,] CreateDiagonalMatrix()
        {
            int[,] DiagonalMatrix = new int[Size,Size];
            for (int row = 0; row < Size; row++)
            {
                for (int column = 0; column < Size; column++)
                {
                    if (row == column)
                    {
                        DiagonalMatrix[row, column] = DiagonalNumbers[row];

                    }
                }

            }
            return DiagonalMatrix;
        }




        //Calculating the sum of the diagonal numbers
        public int Track()
        {
            var sum = 0;
            foreach (var number in DiagonalNumbers)
            {
                sum += number;
            }

            return sum;
        }

        //Ovveriding method Equals
        public override bool Equals(object obj)
        {
            if (Size== ((Matrix)obj).Size)
            {
                return true;
            }
            return false;

        }


    }
}
