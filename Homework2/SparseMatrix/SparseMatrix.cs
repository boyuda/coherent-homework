using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseMatrixTask
{
    class SparseMatrix
    {
        public int Size { get; set; }
        public int RowSize { get; set; }
        public int ColumnSize { get; set; }

        private Dictionary<int, Dictionary<int, int>> Matrix;


        //Constructor
        public SparseMatrix(int rowSize, int columnSize)
        {
            if (rowSize <= 0 && columnSize <= 0)
            {
                throw new ArgumentException("Wrong Size");
            }
            else
            {
                RowSize = rowSize;
                ColumnSize = columnSize;
                Size = rowSize * columnSize;
                Matrix = new Dictionary<int, Dictionary<int, int>>();
            }
        }


        //Indexer
        public int this[int i, int j]
        {
            get
            {
                Dictionary<int, int> columns;

                if (Matrix.TryGetValue(i, out columns))
                {
                    int value = default;
                    if (columns.TryGetValue(j, out value))
                        return value;
                }
                return default;
            }

            set
            {
                if (i >= RowSize || j >= ColumnSize)
                {
                    throw new ArgumentOutOfRangeException();
                }


                Dictionary<int, int> columns;

                if (!Matrix.TryGetValue(i, out columns))
                {
                    columns = new Dictionary<int, int>();
                    Matrix.Add(i, columns);
                }
                columns[j] = value;
            }
        }

        //Return all elements
        public IEnumerable<int> GetAllElements()
        {
            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    yield return this[i, j];
                }
            }
        }

        //Returning only non zero elements
        public IEnumerable<(int, int, int)> GetNozeroElements()
        {
            foreach (var kvp in Matrix)
            {
                foreach (var innerKvp in kvp.Value)
                {
                    yield return (kvp.Key, innerKvp.Key, innerKvp.Value);
                }
            }

        }

        //Counter of an element
        public int GetCount(int x)
        {
            var counter = 0;
            {
                if(x == 0)
                {
                    counter = Size - (Matrix.Values.Sum(i => i.Count));
                } 
                else
                {
                    counter = Matrix.Count(i => i.Value.ContainsValue(x));
                }
                return counter;
            }
        }

        //Override to display sparse matrix
        public override string ToString()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < RowSize; i++)
            {
                for (int j = 0; j < ColumnSize; j++)
                {
                    builder.Append(this[i, j]);

                    if (j == ColumnSize - 1)
                    {
                        builder.Append('\n');
                    }
                }
            }
            return Convert.ToString(builder);
        }
    }
}
