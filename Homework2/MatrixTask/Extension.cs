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

        public static T MatrixSum<T>(this Matrix<T> matrixOne,int firstElementPosition, Matrix<T> matrixTwo, int secondElementPosition, Add<T> delegates)
        {
            return delegates(matrixOne[firstElementPosition, firstElementPosition], matrixTwo[secondElementPosition, secondElementPosition]);
        }
    }

}