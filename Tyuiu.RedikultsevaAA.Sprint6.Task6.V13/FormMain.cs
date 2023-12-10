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

using Tyuiu.RedikultsevaAA.Sprint6.Task6.V13.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonFile_RAA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOut_RAA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_RAA.ShowDialog();
                openFilePath = openFileDialogTask_RAA.FileName;
                textBoxIn_RAA.Text = File.ReadAllText(openFilePath);
                groupBoxIn_RAA.Text = groupBoxIn_RAA.Text + " " + openFileDialogTask_RAA.FileName;
                buttonDone_RAA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
