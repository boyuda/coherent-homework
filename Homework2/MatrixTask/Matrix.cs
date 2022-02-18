using System;


namespace MatrixTask
{
    public class Matrix<T>
    {
        private T[] DiagonalElements { get; set; }
        public int Size { get; private set; }

        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;
        public T OldElement { get; set; }

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
                    DiagonalElements[i] = value;

                    //Invoking Event and passing values as per task request
                    if (!(value.Equals(OldElement)))
                    {
                        this.ElementChanged?.Invoke(this, new ElementChangedEventArgs<T> { ObjectIndex = i, OldElement = OldElement, NewElement = value });
                    }

                    OldElement = value;
                }
            }
        }
    }
}
