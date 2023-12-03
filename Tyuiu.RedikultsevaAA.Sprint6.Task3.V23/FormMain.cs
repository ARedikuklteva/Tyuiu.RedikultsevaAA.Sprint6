using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RedikultsevaAA.Sprint6.Task3.V23.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task3.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int[,] mtrx = new int[5, 5] { { 0, -19, 25, 34, 0, },
                                          { -19, -16, 1, -5, 34, },
                                          { 1, 13, -5, -17, -5, },
                                          { 3, -9, -15, -1, 0, },
                                          { 1, 20, 15, -5, 31, } };
        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] res = ds.Calculate(mtrx);

            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            dataGridViewResult_RAA.ColumnCount = cols;
            dataGridViewResult_RAA.RowCount = rows;
 
            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult_RAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_RAA.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы АСОиУб-23-1 Редикульцева Анастасия Алексеевна", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewInPut_RAA.ColumnCount = columns;
            dataGridViewInPut_RAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_RAA.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewInPut_RAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
