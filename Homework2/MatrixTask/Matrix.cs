using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class Matrix<T>
    {
        private T[] DiagonalNumbers { get; set; }
        public int Size { get; private set; }


        public Matrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                Size = size;

            }
        }



        //Adding Indexer
        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (i != j)
                {
                    return default(T);
                }
                else
                {
                    return DiagonalNumbers[i];
                }
            }

            set
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (i != j)
                {
                    // do nothing
                }
                else
                {
                    DiagonalNumbers[i] = value;
                }
            }



        }
    }
}
