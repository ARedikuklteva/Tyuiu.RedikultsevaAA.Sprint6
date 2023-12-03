using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.RedikultsevaAA.Sprint6.Task2.V17.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_RAA.BackColor = Color.Blue;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_RAA.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_RAA.BackColor = Color.Green;
        }

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_RAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_RAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_RAA.Titles.Add("График функции cos(x) + 4x/2 - sin(x)*3x");
                this.chartFunction_RAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_RAA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_RAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_RAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы АСОиУб-23-1 Редикульцева Анастасия Алексеевна", "Сообщение");
        }
    }
}
