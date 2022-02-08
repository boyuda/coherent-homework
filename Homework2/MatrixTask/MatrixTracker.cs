using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class MatrixTracker<T>
    {
        public int MyProperty { get; set; }
        public MatrixTracker(Matrix<T> matrix)
        {
            matrix.ElementChanged += Matrix_ElementChanged;
        }

        private void Matrix_ElementChanged(object sender, T e)
        {
            Console.WriteLine("Element changed");
        }
    }
}
