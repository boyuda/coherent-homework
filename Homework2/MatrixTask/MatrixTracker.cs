using System;


namespace MatrixTask
{
    class MatrixTracker<T>
    {
        public Matrix<T> Matrix { get; set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            matrix.ElementChanged += Matrix_ElementChanged;
            this.Matrix = matrix;
        }

        private void Matrix_ElementChanged(object sender, T e)
        {
            //No Implementation
        }

        //Returning previous value
        public void Undo()
        {
            var Index = this.Matrix.ObjectIndex;
            this.Matrix[Index, Index] = this.Matrix.OldObject;
        }
    }
}
