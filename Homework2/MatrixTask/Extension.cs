using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    public delegate Matrix<T> add<T>(Matrix<T> matrixOne, Matrix<T> matrixTwo);

    public static class Extension
        {

        public static Matrix<T> MatrixSum<T>(this Matrix<T> matrixOne, Matrix<T> matrixTwo, add<T> delegates)
        {
            return delegates(matrixOne, matrixTwo);
        }
    }

}