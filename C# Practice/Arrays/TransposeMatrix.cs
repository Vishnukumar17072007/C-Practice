using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Array
{
    class TransposeMatrix
    {
        public int[,] Transpose(int[,] matrix)
        {
            int lenMatRow = matrix.GetLength(0);
            int lenMatCol = matrix.GetLength(1);
            int[,] transMatrix = new int[lenMatCol, lenMatRow];
            for(int i = 0; i< lenMatRow; i++)
            {
                for(int j = 0; j< lenMatCol; j++)
                {
                    transMatrix[j, i] = matrix[i, j];
                }
            }

            return transMatrix;
        }
    }
}
