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
using Tyuiu.RedikultsevaAA.Sprint6.Task4.V17.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task4.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            try
            {
                int StartValue = Convert.ToInt32(textBoxStartValue_RAA.Text);
                int StopValue = Convert.ToInt32(textBoxStopValue_RAA.Text);

                int len = ds.GetMassFunction(StartValue, StopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(StartValue, StopValue);

                this.chartFunction_RAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_RAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_RAA.Text = "";
                chartFunction_RAA.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_RAA.Series[0].Points.AddXY(StartValue, valueArray[i]);
                    textBoxResult_RAA.AppendText(valueArray[i] + Environment.NewLine);
                    StartValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_RAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V17";
                File.WriteAllText(path, textBoxResult_RAA.Text);

                DialogResult dialogResult = MessageBox.Show("" + path + "Файл сохранен успешно!\n Открыть его в блакноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохраненнии файлв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы АСОиУб-23-1 Редикульцева Анастасия Алексеевна", "Сообщение");
        }
    }
}
