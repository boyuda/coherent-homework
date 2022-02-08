using System;


namespace MatrixTask
{
    class Matrix<T>
    {
        private T[] DiagonalElements { get; set; }
        public T OldObject { get; private set; }
        public int ObjectIndex { get; private set; }
        public int Size { get; private set; }
        public event EventHandler<T> ElementChanged;

        //Ctor accepting only Size
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
                    // No Implementation
                }
                else
                {
                    if(!(value.Equals(this.DiagonalElements[i])))
                    {
                        this.ElementChanged?.Invoke(this, this.DiagonalElements[i]);
                    }
                    //Storing Old Value and Index
                    OldObject = DiagonalElements[i];
                    ObjectIndex = i;

                    DiagonalElements[i] = value;

                }
            }
        }
    }
}
