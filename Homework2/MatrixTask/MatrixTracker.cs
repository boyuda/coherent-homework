using System;


namespace MatrixTask
{
    public class MatrixTracker<T>
    {
        public T OldObject { get; private set; }
        public int ElementIndex { get; private set; }

        public Matrix<T> Matrix { get; private set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            matrix.ElementChanged += Matrix_ElementChanged;
            this.Matrix = matrix;
        }

        private void Matrix_ElementChanged(object sender, ElementChangedEventArgs<T> e)
        {
            OldObject = (T)e.OldElement;
            ElementIndex = e.ObjectIndex;
        }


        //Returning previous value
        public void Undo()
        {
            if (OldObject.Equals(default(T)))
            {
                throw new ArgumentException("Can't Undo the default value");
            }

            Matrix[ElementIndex, ElementIndex] = OldObject;
        }
    }
}
