using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            int[] second_column = {0, 0, 0, 0, 0};
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j == 1)
                    {
                        second_column[count] = matrix[i, j];
                        count++;
                    }
                }
            }
            Array.Sort(second_column);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j == 1)
                    {
                        matrix[i, j] = second_column[i];
                    }
                }
            }
            return matrix;
        }
    }
}
