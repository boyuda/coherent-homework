using System;

namespace DiagonalMatrix
{
    public class Matrix
    {
        private int[] diagonalNumbers { get; set; }
        public int Size { get; private set; }

        //Adding Indexer
        public int this [int i, int j]
        {
            get
            {
                if (i != j || i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    return 0;
                }
                else
                {
                    return diagonalNumbers[i];
                }
            }
        }
  

        public Matrix(params int[] elements)
        {
            //Storing numbers in one-dimmensional array and applying Size for the Matrix

            if (elements == null)
            {
                Size = 0;
            }
            else
            {
                this.diagonalNumbers = elements;
                Size = diagonalNumbers.Length;
            }   
        }

        //Calculating the sum of the diagonal numbers
        public int Track()
        {
            var sum = 0;
            foreach (var number in diagonalNumbers)
            {
                sum += number;
            }
            return sum;
        }

        //Overriding Equals method to compare 2 matrixes
        public override bool Equals(object obj)
        {
            Matrix secondMatrix = obj as Matrix;

            if (Size == secondMatrix.Size || obj != null)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (diagonalNumbers[i] == secondMatrix[i,i])
                    {
                        continue;   
                    } 
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        //Adding ToString Overload to compare 2 matrixes
        public string ToString(object obj)
        {
            Matrix secondMatrix = obj as Matrix;

            if (Size == secondMatrix.Size)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (diagonalNumbers[i] == secondMatrix[i, i])
                    {
                        continue;
                    }
                    else
                    {
                        return "False";
                    }
                }
                return "True";
            }
            return "False";
        }
    }
}
