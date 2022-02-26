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
        public int Size { get; private set; }
        public int RowSize { get; private set; }
        public int ColumnSize { get; private set; }

        private Dictionary<(int, int), int> Matrix; //int,int is row/column


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
                Matrix = new Dictionary<(int, int), int>(Size);
            }
        }

        public int this[int i, int j]
        {
            get
            {
                return Matrix.TryGetValue((i, j), out int value) ? Matrix[(i, j)] : 0;
            }

            set
            {
                if(value == 0)
                {
                    //Doing nothing
                } 
                else
                {
                    Matrix[(i, j)] = value;
                }
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
                for (int i = 0; i < RowSize; i++)
                {
                    for (int j = 0; j < ColumnSize; j++)
                    {
                        if (this[i, j] != 0)
                            yield return (i, j, this[i, j]);
                    }
                }
            }
        }

        
        
        //Counter of an element
        public int GetCount(int x)
        {
            var counter = 0;
            {
                if (x == 0)
                {
                    counter = Size - Matrix.Count;
                } 
                else
                {
                    foreach (var n in Matrix)
                    {
                        if (n.Value == x)
                        {
                            counter++;
                        }
                    }

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
            Console.WriteLine(Matrix.Count);
            return Convert.ToString(builder);
        }
        
    }
}
