using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    public delegate T Add<T>(T elementOne, T elementTwo);

    public static class Extension
        {

        public static Matrix<T> MatrixSum<T>(this Matrix<T> matrixOne, Matrix<T> matrixTwo, Add<T> addition)
        {
            var size = matrixOne.Size > matrixTwo.Size ? matrixOne.Size : matrixTwo.Size;

            var newMatrix = new Matrix<T>(size);

            for (int i = 0; i < newMatrix.Size; i++)
            {
                if (i > matrixOne.Size)
                {
                    newMatrix[i, i] = addition(default(T), matrixTwo[i, i]);
                } else if (i > matrixTwo.Size)
                {
                    newMatrix[i, i] = addition(matrixOne[i, i], default(T));
                } else
                {
                    newMatrix[i, i] = addition(matrixOne[i, i], matrixTwo[i, i]);
                }
            }

            return newMatrix;
        }
    }

}