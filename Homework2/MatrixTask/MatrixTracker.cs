using System;


namespace MatrixTask
{
    class MatrixTracker<T>
    {
        public T OldObject { get; private set; }
        public int ElementIndex { get; private set; }

        public Matrix<T> Matrix { get; set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            matrix.ElementChanged += Matrix_ElementChanged;
            this.Matrix = matrix;
        }

        private void Matrix_ElementChanged(object sender, ElementChangedEventArgs e)
        {
            OldObject = (T)e.OldElement;
            ElementIndex = e.ObjectIndex;
        }


        //Returning previous value
        public void Undo()
        {
            Matrix[ElementIndex, ElementIndex] = OldObject;
        }
    }
}
