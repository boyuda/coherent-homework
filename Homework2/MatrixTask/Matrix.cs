using System;


namespace MatrixTask
{
    public class Matrix<T>
    {
        private T[] DiagonalElements { get; set; }

        public int Size { get; private set; }

        public event EventHandler<ElementChangedEventArgs> ElementChanged;



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
                    //Invoking Event and passing values as per task request
                    if(!(value.Equals(this.DiagonalElements[i])))
                    {
                        this.ElementChanged?.Invoke(this, new ElementChangedEventArgs { ObjectIndex = i, OldElement = DiagonalElements[i], NewElement = value });
                       
                    }

                    DiagonalElements[i] = value;

                }
            }
        }
    }
}
