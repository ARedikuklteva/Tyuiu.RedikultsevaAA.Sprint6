using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;
            int[,] mtrx = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    mtrx[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (i == 4)
                    {
                        if (mtrx[i, j] % 2 != 0)
                        {
                            mtrx[i, j] = -1;
                        }
                    }
                }
            }

            return mtrx;
        }
    }
}
