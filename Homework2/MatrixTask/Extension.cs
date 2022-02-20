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

        public static T MatrixSum<T>(this Matrix<T> matrixOne, Matrix<T> matrixTwo, Add<T> addition)
        {
            var Size = matrixOne.Size > matrixTwo.Size ? matrixOne.Size : matrixTwo.Size;

            var newMatrix = new Matrix<T>(Size);

            for (int i = 0; i < matrixOne.Size; i++)
            {
               newMatrix[i, i] = addition(matrixOne[i, i], matrixTwo[i, i]);
            }

            return (T)Convert.ChangeType(newMatrix, typeof(T));

        }
    }

}