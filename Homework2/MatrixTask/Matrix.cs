using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class Matrix<T>
    {
        private T[] DiagonalElements { get; set; }
        public T OldObject { get; set; }
        public T NewObject { get; set; }
        public int ObjectIndex { get; set; }
        public int Size { get; private set; }

        public event EventHandler<T> ElementChanged;


        public Matrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                Size = size;
                DiagonalElements = new T[Size];
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
                    return DiagonalElements[i];
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
                    // doing nothing
                }
                else
                {
                    if(!(value.Equals(this.DiagonalElements[i])))
                    {
                        this.ElementChanged?.Invoke(this, this.DiagonalElements[i]);
                    }

                    OldObject = DiagonalElements[i];
                    NewObject = value;
                    ObjectIndex = i;

                    DiagonalElements[i] = value;

                }
            }



        }

    }
}
