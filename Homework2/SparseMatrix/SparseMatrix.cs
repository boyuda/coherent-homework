using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrixTask
{
    class SparseMatrix
    {
        public int RowSize { get; set; }
        public int ColumnSize { get; set; }

        public int Size { get; set; }

        private Dictionary<int, Dictionary<int, int>> Matrix;

        public SparseMatrix(int rowSize, int columnSize)
        {
            if (rowSize > 0 && columnSize > 0)
            {
                RowSize = rowSize;
                ColumnSize = columnSize;
                Size = RowSize * ColumnSize;
                Matrix = new Dictionary<int, Dictionary<int, int>>(Size);

            }
        }
    }
}
