using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
    class DiagonalMatrix
    {
        public int[] DiagonalNumbers;
        public int Size { get; private set; }
        //var newArray = new int[diagonalNumbers.Size, diagonalNumbers.Size];

        public DiagonalMatrix(params int[] diagonalNumbers)
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
