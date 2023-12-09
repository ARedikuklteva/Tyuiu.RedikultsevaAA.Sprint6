
namespace Tyuiu.RedikultsevaAA.Sprint6.Task4.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTask_RAA = new System.Windows.Forms.Panel();
            this.buttonSave_RAA = new System.Windows.Forms.Button();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.groupBoxInPut_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxStopValue_RAA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_RAA = new System.Windows.Forms.TextBox();
            this.labelStopValue_RAA = new System.Windows.Forms.Label();
            this.labelStartValue_RAA = new System.Windows.Forms.Label();
            this.groupBoxTask_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_RAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.panelOutPut_RAA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_RAA = new System.Windows.Forms.TextBox();
            this.panelFunction_RAA = new System.Windows.Forms.Panel();
            this.chartFunction_RAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter_RAA = new System.Windows.Forms.Splitter();
            this.panelTask_RAA.SuspendLayout();
            this.groupBoxInPut_RAA.SuspendLayout();
            this.groupBoxTask_RAA.SuspendLayout();
            this.panelOutPut_RAA.SuspendLayout();
            this.groupBoxOutPut_RAA.SuspendLayout();
            this.panelFunction_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_RAA
            // 
            this.panelTask_RAA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTask_RAA.Controls.Add(this.buttonSave_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonDone_RAA);
            this.panelTask_RAA.Controls.Add(this.groupBoxInPut_RAA);
            this.panelTask_RAA.Controls.Add(this.groupBoxTask_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonHelp_RAA);
            this.panelTask_RAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_RAA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_RAA.Name = "panelTask_RAA";
            this.panelTask_RAA.Size = new System.Drawing.Size(1032, 156);
            this.panelTask_RAA.TabIndex = 0;
            // 
            // buttonSave_RAA
            // 
            this.buttonSave_RAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_RAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_RAA.Location = new System.Drawing.Point(849, 12);
            this.buttonSave_RAA.Name = "buttonSave_RAA";
            this.buttonSave_RAA.Size = new System.Drawing.Size(90, 53);
            this.buttonSave_RAA.TabIndex = 4;
            this.buttonSave_RAA.Text = "Сохранить";
            this.buttonSave_RAA.UseVisualStyleBackColor = false;
            this.buttonSave_RAA.Click += new System.EventHandler(this.buttonSave_RAA_Click);
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_RAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_RAA.Location = new System.Drawing.Point(752, 12);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(95, 53);
            this.buttonDone_RAA.TabIndex = 3;
            this.buttonDone_RAA.Text = "Выполнить";
            this.buttonDone_RAA.UseVisualStyleBackColor = false;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            // 
            // groupBoxInPut_RAA
            // 
            this.groupBoxInPut_RAA.Controls.Add(this.textBoxStopValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.textBoxStartValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.labelStopValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.labelStartValue_RAA);
            this.groupBoxInPut_RAA.Location = new System.Drawing.Point(489, 6);
            this.groupBoxInPut_RAA.Name = "groupBoxInPut_RAA";
            this.groupBoxInPut_RAA.Size = new System.Drawing.Size(257, 147);
            this.groupBoxInPut_RAA.TabIndex = 2;
            this.groupBoxInPut_RAA.TabStop = false;
            this.groupBoxInPut_RAA.Text = "Ввод даных";
            // 
            // textBoxStopValue_RAA
            // 
            this.textBoxStopValue_RAA.Location = new System.Drawing.Point(146, 68);
            this.textBoxStopValue_RAA.Name = "textBoxStopValue_RAA";
            this.textBoxStopValue_RAA.Size = new System.Drawing.Size(105, 22);
            this.textBoxStopValue_RAA.TabIndex = 3;
            this.textBoxStopValue_RAA.Text = "5";
            // 
            // textBoxStartValue_RAA
            // 
            this.textBoxStartValue_RAA.Location = new System.Drawing.Point(6, 68);
            this.textBoxStartValue_RAA.Name = "textBoxStartValue_RAA";
            this.textBoxStartValue_RAA.Size = new System.Drawing.Size(105, 22);
            this.textBoxStartValue_RAA.TabIndex = 2;
            this.textBoxStartValue_RAA.Text = "-5";
            // 
            // labelStopValue_RAA
            // 
            this.labelStopValue_RAA.AutoSize = true;
            this.labelStopValue_RAA.Location = new System.Drawing.Point(144, 42);
            this.labelStopValue_RAA.Name = "labelStopValue_RAA";
            this.labelStopValue_RAA.Size = new System.Drawing.Size(89, 17);
            this.labelStopValue_RAA.TabIndex = 1;
            this.labelStopValue_RAA.Text = "Конец шага:";
            // 
            // labelStartValue_RAA
            // 
            this.labelStartValue_RAA.AutoSize = true;
            this.labelStartValue_RAA.Location = new System.Drawing.Point(6, 42);
            this.labelStartValue_RAA.Name = "labelStartValue_RAA";
            this.labelStartValue_RAA.Size = new System.Drawing.Size(87, 17);
            this.labelStartValue_RAA.TabIndex = 0;
            this.labelStartValue_RAA.Text = "Старт шага:";
            // 
            // groupBoxTask_RAA
            // 
            this.groupBoxTask_RAA.Controls.Add(this.textBoxTask_RAA);
            this.groupBoxTask_RAA.Location = new System.Drawing.Point(6, 6);
            this.groupBoxTask_RAA.Name = "groupBoxTask_RAA";
            this.groupBoxTask_RAA.Size = new System.Drawing.Size(477, 147);
            this.groupBoxTask_RAA.TabIndex = 1;
            this.groupBoxTask_RAA.TabStop = false;
            this.groupBoxTask_RAA.Text = "Условие:";
            // 
            // textBoxTask_RAA
            // 
            this.textBoxTask_RAA.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_RAA.Multiline = true;
            this.textBoxTask_RAA.Name = "textBoxTask_RAA";
            this.textBoxTask_RAA.ReadOnly = true;
            this.textBoxTask_RAA.Size = new System.Drawing.Size(454, 120);
            this.textBoxTask_RAA.TabIndex = 0;
            this.textBoxTask_RAA.Text = resources.GetString("textBoxTask_RAA.Text");
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_RAA.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHelp_RAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_RAA.FlatAppearance.BorderSize = 3;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(944, 12);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(78, 53);
            this.buttonHelp_RAA.TabIndex = 0;
            this.buttonHelp_RAA.Text = "Справка";
            this.buttonHelp_RAA.UseVisualStyleBackColor = false;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // panelOutPut_RAA
            // 
            this.panelOutPut_RAA.BackColor = System.Drawing.SystemColors.Control;
            this.panelOutPut_RAA.Controls.Add(this.groupBoxOutPut_RAA);
            this.panelOutPut_RAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_RAA.Location = new System.Drawing.Point(0, 156);
            this.panelOutPut_RAA.Name = "panelOutPut_RAA";
            this.panelOutPut_RAA.Size = new System.Drawing.Size(151, 347);
            this.panelOutPut_RAA.TabIndex = 0;
            // 
            // groupBoxOutPut_RAA
            // 
            this.groupBoxOutPut_RAA.Controls.Add(this.textBoxResult_RAA);
            this.groupBoxOutPut_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_RAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_RAA.Name = "groupBoxOutPut_RAA";
            this.groupBoxOutPut_RAA.Size = new System.Drawing.Size(151, 347);
            this.groupBoxOutPut_RAA.TabIndex = 1;
            this.groupBoxOutPut_RAA.TabStop = false;
            this.groupBoxOutPut_RAA.Text = "Вывод:";
            // 
            // textBoxResult_RAA
            // 
            this.textBoxResult_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_RAA.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_RAA.Multiline = true;
            this.textBoxResult_RAA.Name = "textBoxResult_RAA";
            this.textBoxResult_RAA.ReadOnly = true;
            this.textBoxResult_RAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_RAA.Size = new System.Drawing.Size(145, 326);
            this.textBoxResult_RAA.TabIndex = 0;
            // 
            // panelFunction_RAA
            // 
            this.panelFunction_RAA.Controls.Add(this.splitter_RAA);
            this.panelFunction_RAA.Controls.Add(this.chartFunction_RAA);
            this.panelFunction_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_RAA.Location = new System.Drawing.Point(151, 156);
            this.panelFunction_RAA.Name = "panelFunction_RAA";
            this.panelFunction_RAA.Size = new System.Drawing.Size(881, 347);
            this.panelFunction_RAA.TabIndex = 0;
            // 
            // chartFunction_RAA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_RAA.ChartAreas.Add(chartArea3);
            this.chartFunction_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartFunction_RAA.Legends.Add(legend3);
            this.chartFunction_RAA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_RAA.Name = "chartFunction_RAA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_RAA.Series.Add(series3);
            this.chartFunction_RAA.Size = new System.Drawing.Size(881, 347);
            this.chartFunction_RAA.TabIndex = 1;
            this.chartFunction_RAA.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "График функции";
            this.chartFunction_RAA.Titles.Add(title3);
            // 
            // splitter_RAA
            // 
            this.splitter_RAA.Location = new System.Drawing.Point(0, 0);
            this.splitter_RAA.Name = "splitter_RAA";
            this.splitter_RAA.Size = new System.Drawing.Size(3, 347);
            this.splitter_RAA.TabIndex = 2;
            this.splitter_RAA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 503);
            this.Controls.Add(this.panelFunction_RAA);
            this.Controls.Add(this.panelOutPut_RAA);
            this.Controls.Add(this.panelTask_RAA);
            this.MinimumSize = new System.Drawing.Size(1050, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 17 | Редикульцева А.А.";
            this.panelTask_RAA.ResumeLayout(false);
            this.groupBoxInPut_RAA.ResumeLayout(false);
            this.groupBoxInPut_RAA.PerformLayout();
            this.groupBoxTask_RAA.ResumeLayout(false);
            this.groupBoxTask_RAA.PerformLayout();
            this.panelOutPut_RAA.ResumeLayout(false);
            this.groupBoxOutPut_RAA.ResumeLayout(false);
            this.groupBoxOutPut_RAA.PerformLayout();
            this.panelFunction_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_RAA;
        private System.Windows.Forms.Panel panelOutPut_RAA;
        private System.Windows.Forms.Panel panelFunction_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_RAA;
        private System.Windows.Forms.TextBox textBoxResult_RAA;
        private System.Windows.Forms.GroupBox groupBoxTask_RAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_RAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_RAA;
        private System.Windows.Forms.TextBox textBoxTask_RAA;
        private System.Windows.Forms.Button buttonSave_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.TextBox textBoxStopValue_RAA;
        private System.Windows.Forms.TextBox textBoxStartValue_RAA;
        private System.Windows.Forms.Label labelStopValue_RAA;
        private System.Windows.Forms.Label labelStartValue_RAA;
        private System.Windows.Forms.Splitter splitter_RAA;
    }
}

