﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RedikultsevaAA.Sprint6.Task5.V13.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task5.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V13.txt";

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_RAA.ColumnCount = 2;
            dataGridViewOutPut_RAA.Columns[0].Width = 20;
            dataGridViewOutPut_RAA.Columns[1].Width = 50;

            this.chartFunction_RAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_RAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_RAA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_RAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_RAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_RAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }


        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы АСОиУб-23-1 Редикульцева Анастасия Алексеевна", "Сообщение");
        }
    }
}
