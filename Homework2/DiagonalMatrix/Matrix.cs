using System;

namespace DiagonalMatrix
{
    class Matrix
    {
        private int[] DiagonalNumbers { get; set; }
        public int Size { get; private set; }
        public int[,] DiagonalMatrix { get; set; }


        public Matrix(params int[] diagonalNumbers)
        {
            //Storing numbers in one-dimmensional array and applying Size for the Matrix
            this.DiagonalNumbers = diagonalNumbers;

            if (diagonalNumbers == null)
            {
                Size = 0;
            }
            else
            {
                Size = diagonalNumbers.Length;

                //Creating Matrix with Diagonal Numbers   
                int[,] DiagonalMatrix = new int[Size, Size];

                for (int row = 0; row < Size; row++)
                {
                    for (int column = 0; column < Size; column++)
                    {
                        if (row == column)
                        {
                            DiagonalMatrix[row, column] = DiagonalNumbers[row];
                        }
                    }
                }
                this.DiagonalMatrix = DiagonalMatrix;

            }   

        }

        //Calculating the sum of the diagonal numbers
        public int Track()
        {
            var sum = 0;
            foreach (var number in DiagonalNumbers)
            {
                sum += number;
            }

            return sum;
        }

        //Overriding Equals method to compare 2 matrixes
        public override bool Equals(object obj)
        {
            if ((Size == ((Matrix)obj).Size))
            {
                for (int i = 0; i < Size; i++)
                {
                    if (DiagonalNumbers[i] == ((Matrix)obj).DiagonalNumbers[i])
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
            if ((Size == ((Matrix)obj).Size))
            {
                for (int i = 0; i < Size; i++)
                {
                    if (DiagonalNumbers[i] == ((Matrix)obj).DiagonalNumbers[i])
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
