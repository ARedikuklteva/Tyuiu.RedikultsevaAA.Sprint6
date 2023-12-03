
namespace Tyuiu.RedikultsevaAA.Sprint6.Task2.V17
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxResult_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_RAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_RAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_RAA = new System.Windows.Forms.Label();
            this.groupTask_RAA = new System.Windows.Forms.GroupBox();
            this.labelTask_RAA = new System.Windows.Forms.Label();
            this.groupBoxInPut_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxStartValue_RAA = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_RAA = new System.Windows.Forms.TextBox();
            this.labelStartValue_RAA = new System.Windows.Forms.Label();
            this.labelStopValue_RAA = new System.Windows.Forms.Label();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.groupBoxResult_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_RAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).BeginInit();
            this.groupTask_RAA.SuspendLayout();
            this.groupBoxInPut_RAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult_RAA
            // 
            this.groupBoxResult_RAA.Controls.Add(this.dataGridViewFunction_RAA);
            this.groupBoxResult_RAA.Controls.Add(this.chartFunction_RAA);
            this.groupBoxResult_RAA.Controls.Add(this.labelResult_RAA);
            this.groupBoxResult_RAA.Location = new System.Drawing.Point(547, 12);
            this.groupBoxResult_RAA.Name = "groupBoxResult_RAA";
            this.groupBoxResult_RAA.Size = new System.Drawing.Size(516, 426);
            this.groupBoxResult_RAA.TabIndex = 0;
            this.groupBoxResult_RAA.TabStop = false;
            this.groupBoxResult_RAA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_RAA
            // 
            this.dataGridViewFunction_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_RAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Function});
            this.dataGridViewFunction_RAA.Location = new System.Drawing.Point(9, 32);
            this.dataGridViewFunction_RAA.Name = "dataGridViewFunction_RAA";
            this.dataGridViewFunction_RAA.RowHeadersVisible = false;
            this.dataGridViewFunction_RAA.RowHeadersWidth = 25;
            this.dataGridViewFunction_RAA.Size = new System.Drawing.Size(161, 380);
            this.dataGridViewFunction_RAA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 75;
            // 
            // Function
            // 
            this.Function.HeaderText = "F(X)";
            this.Function.Name = "Function";
            this.Function.Width = 75;
            // 
            // chartFunction_RAA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_RAA.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_RAA.Legends.Add(legend5);
            this.chartFunction_RAA.Location = new System.Drawing.Point(176, 32);
            this.chartFunction_RAA.Name = "chartFunction_RAA";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_RAA.Series.Add(series5);
            this.chartFunction_RAA.Size = new System.Drawing.Size(334, 380);
            this.chartFunction_RAA.TabIndex = 2;
            // 
            // labelResult_RAA
            // 
            this.labelResult_RAA.AutoSize = true;
            this.labelResult_RAA.Location = new System.Drawing.Point(6, 16);
            this.labelResult_RAA.Name = "labelResult_RAA";
            this.labelResult_RAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_RAA.TabIndex = 0;
            this.labelResult_RAA.Text = "Результат:";
            // 
            // groupTask_RAA
            // 
            this.groupTask_RAA.Controls.Add(this.labelTask_RAA);
            this.groupTask_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupTask_RAA.Name = "groupTask_RAA";
            this.groupTask_RAA.Size = new System.Drawing.Size(529, 355);
            this.groupTask_RAA.TabIndex = 1;
            this.groupTask_RAA.TabStop = false;
            this.groupTask_RAA.Text = "Условие";
            // 
            // labelTask_RAA
            // 
            this.labelTask_RAA.AutoSize = true;
            this.labelTask_RAA.Location = new System.Drawing.Point(6, 16);
            this.labelTask_RAA.Name = "labelTask_RAA";
            this.labelTask_RAA.Size = new System.Drawing.Size(338, 26);
            this.labelTask_RAA.TabIndex = 0;
            this.labelTask_RAA.Text = "Протабулировать sin(x) на заданном диапозоне.\r\nРезультат вывести в DataGindView и" +
    " построить график функции.\r\n";
            // 
            // groupBoxInPut_RAA
            // 
            this.groupBoxInPut_RAA.Controls.Add(this.textBoxStartValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.textBoxStopValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.labelStartValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.labelStopValue_RAA);
            this.groupBoxInPut_RAA.Location = new System.Drawing.Point(12, 373);
            this.groupBoxInPut_RAA.Name = "groupBoxInPut_RAA";
            this.groupBoxInPut_RAA.Size = new System.Drawing.Size(280, 65);
            this.groupBoxInPut_RAA.TabIndex = 2;
            this.groupBoxInPut_RAA.TabStop = false;
            this.groupBoxInPut_RAA.Text = "Ввод данных";
            // 
            // textBoxStartValue_RAA
            // 
            this.textBoxStartValue_RAA.Location = new System.Drawing.Point(9, 32);
            this.textBoxStartValue_RAA.Name = "textBoxStartValue_RAA";
            this.textBoxStartValue_RAA.Size = new System.Drawing.Size(131, 20);
            this.textBoxStartValue_RAA.TabIndex = 1;
            this.textBoxStartValue_RAA.Text = "-5";
            // 
            // textBoxStopValue_RAA
            // 
            this.textBoxStopValue_RAA.Location = new System.Drawing.Point(146, 32);
            this.textBoxStopValue_RAA.Name = "textBoxStopValue_RAA";
            this.textBoxStopValue_RAA.Size = new System.Drawing.Size(128, 20);
            this.textBoxStopValue_RAA.TabIndex = 1;
            this.textBoxStopValue_RAA.Text = "5";
            // 
            // labelStartValue_RAA
            // 
            this.labelStartValue_RAA.AutoSize = true;
            this.labelStartValue_RAA.Location = new System.Drawing.Point(6, 16);
            this.labelStartValue_RAA.Name = "labelStartValue_RAA";
            this.labelStartValue_RAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_RAA.TabIndex = 1;
            this.labelStartValue_RAA.Text = "Старт шага:";
            // 
            // labelStopValue_RAA
            // 
            this.labelStopValue_RAA.AutoSize = true;
            this.labelStopValue_RAA.Location = new System.Drawing.Point(143, 16);
            this.labelStopValue_RAA.Name = "labelStopValue_RAA";
            this.labelStopValue_RAA.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_RAA.TabIndex = 0;
            this.labelStopValue_RAA.Text = "Конец шага:";
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(298, 373);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(69, 65);
            this.buttonHelp_RAA.TabIndex = 3;
            this.buttonHelp_RAA.Text = "Справка";
            this.buttonHelp_RAA.UseVisualStyleBackColor = false;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_RAA.Location = new System.Drawing.Point(373, 373);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(168, 65);
            this.buttonDone_RAA.TabIndex = 4;
            this.buttonDone_RAA.Text = "Выполнить";
            this.buttonDone_RAA.UseVisualStyleBackColor = false;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            this.buttonDone_RAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone_RAA.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone_RAA.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.buttonDone_RAA);
            this.Controls.Add(this.buttonHelp_RAA);
            this.Controls.Add(this.groupBoxInPut_RAA);
            this.Controls.Add(this.groupTask_RAA);
            this.Controls.Add(this.groupBoxResult_RAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 17 | Редикульцева А.А.";
            this.groupBoxResult_RAA.ResumeLayout(false);
            this.groupBoxResult_RAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_RAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).EndInit();
            this.groupTask_RAA.ResumeLayout(false);
            this.groupTask_RAA.PerformLayout();
            this.groupBoxInPut_RAA.ResumeLayout(false);
            this.groupBoxInPut_RAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult_RAA;
        private System.Windows.Forms.GroupBox groupTask_RAA;
        private System.Windows.Forms.Label labelTask_RAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_RAA;
        private System.Windows.Forms.Label labelStartValue_RAA;
        private System.Windows.Forms.Label labelStopValue_RAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_RAA;
        private System.Windows.Forms.Label labelResult_RAA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_RAA;
        private System.Windows.Forms.TextBox textBoxStartValue_RAA;
        private System.Windows.Forms.TextBox textBoxStopValue_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
    }
}

