using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.RedikultsevaAA.Sprint6.Task7.V16.Lib;

namespace Tyuiu.RedikultsevAA.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_RAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_RAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        string openPathFile;
        static int rows, colums;
        DataService ds = new DataService();

        private void buttonTask_RAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_RAA.ShowDialog();
            openPathFile = openFileDialogTask_RAA.FileName;


            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openPathFile);


            dataGridViewIn_RAA.ColumnCount = colums;
            dataGridViewIn_RAA.RowCount = rows;
            dataGridViewOut_RAA.ColumnCount = colums;
            dataGridViewOut_RAA.RowCount = rows;


            for (int i = 0; i < colums; i++)
            {
                dataGridViewOut_RAA.Columns[i].Width = 25;
                dataGridViewIn_RAA.Columns[i].Width = 25;
            }


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewIn_RAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openPathFile);
            buttonDone_RAA.Enabled = true;
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            int[,] valueArray = new int[rows, colums];
            valueArray = ds.GetMatrix(openPathFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOut_RAA.Rows[r].Cells[c].Value = valueArray[r, c];
                }
            }

            buttonSave_RAA.Enabled = true;
        }

        private void buttonSave_RAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_RAA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_RAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_RAA.ShowDialog();

            string path = saveFileDialogMatrix_RAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewIn_RAA.RowCount;
            int columns = dataGridViewIn_RAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewIn_RAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewIn_RAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
