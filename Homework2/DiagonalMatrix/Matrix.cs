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

        //var newArray = new int[diagonalNumbers.Size, diagonalNumbers.Size];

        public Matrix(params int[] diagonalNumbers)
        {
            this.DiagonalNumbers = diagonalNumbers;

            //Calculating the size of the Matrix
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
    }
}
