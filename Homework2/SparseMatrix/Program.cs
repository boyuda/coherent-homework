using System;
using System.Collections.Generic;

namespace SparseMatrixTask
{
    class Program
    {

        //Entry point
        static void Main(string[] args)
        {
            var matrix = new SparseMatrix(5, 5);
            matrix[0,0] = 1;
            matrix[0, 2] = 3;
            matrix[0, 3] = 4;
            matrix[0, 4] = 5;
            matrix[1, 4] = 3;
            matrix.GetAllElements();
        }
    }
}
