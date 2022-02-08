using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class MatrixTracker<T>
    {
        public Matrix<T> Matrix { get; set; }


        public int MyProperty { get; set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            matrix.ElementChanged += Matrix_ElementChanged;
            this.Matrix = matrix;
        }

        private void Matrix_ElementChanged(object sender, T e)
        {
            Console.WriteLine("Element changed");
        }

        public void Undo()
        {
            var Index = this.Matrix.ObjectIndex;
            this.Matrix[Index, Index] = this.Matrix.OldObject;
        }
    }
}
