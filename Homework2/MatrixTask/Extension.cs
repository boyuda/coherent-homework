using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{

    public static class Extension
        {
        public delegate T add<T>(Matrix<T> param1, Matrix<T> param2);

        /// <summary>
        /// Need to pass instruction for example ADDINT, ADDDOUBLE, ADDFLOAT, ADDSTRING AND HE WILL MAKE calculation based on that 
        /// <returns></returns>

        public static Matrix<T> MatrixSum<T>(this Matrix<T> matrixOne, Matrix<T> matrixTwo, add<T> delegates)
        {
            return null;
        }

    }
}




/*
    public static Matrix<T> DiagonalMatrixSum(this Matrix<T> matrixOne, Matrix<T> matrixTwo)
    {
        int newMatrixSize = matrixOne.Size >= matrixTwo.Size ? matrixOne.Size : matrixTwo.Size;
        int[] matrixSumDiagonal = new int[newMatrixSize];

        for (int i = 0; i < newMatrixSize; i++)
        {
            matrixSumDiagonal[i] = matrixOne[i, i] + matrixTwo[i, i];
        }

        return new Matrix<T>(matrixSumDiagonal);
    }


        public static Stack<T> Reverse<T>(this IStack<T> obj)
        {
            var convertedStack = obj as Stack<T>;
            var Size = convertedStack.StackArray.Count() - 1;


            var stack = new Stack<T>(10);

            for (int i = 0; i <= Size; i++)
            {
                stack.Push(obj.Pop());
            }

            return stack;     
        }










*/