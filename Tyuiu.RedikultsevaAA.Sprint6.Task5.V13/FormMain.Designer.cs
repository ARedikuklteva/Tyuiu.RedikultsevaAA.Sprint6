
namespace Tyuiu.RedikultsevaAA.Sprint6.Task5.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_RAA = new System.Windows.Forms.Panel();
            this.panelOutPut_RAA = new System.Windows.Forms.Panel();
            this.panelFunction_RAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_RAA = new System.Windows.Forms.GroupBox();
            this.labelTask_RAA = new System.Windows.Forms.Label();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.buttonOpen_RAA = new System.Windows.Forms.Button();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.chartFunction_RAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_RAA = new System.Windows.Forms.DataGridView();
            this.panelTask_RAA.SuspendLayout();
            this.panelOutPut_RAA.SuspendLayout();
            this.panelFunction_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).BeginInit();
            this.groupBoxOutPut_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_RAA
            // 
            this.panelTask_RAA.Controls.Add(this.buttonHelp_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonOpen_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonDone_RAA);
            this.panelTask_RAA.Controls.Add(this.labelTask_RAA);
            this.panelTask_RAA.Controls.Add(this.groupBoxTask_RAA);
            this.panelTask_RAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_RAA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_RAA.Name = "panelTask_RAA";
            this.panelTask_RAA.Size = new System.Drawing.Size(882, 109);
            this.panelTask_RAA.TabIndex = 0;
            // 
            // panelOutPut_RAA
            // 
            this.panelOutPut_RAA.Controls.Add(this.groupBoxOutPut_RAA);
            this.panelOutPut_RAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_RAA.Location = new System.Drawing.Point(0, 109);
            this.panelOutPut_RAA.Name = "panelOutPut_RAA";
            this.panelOutPut_RAA.Size = new System.Drawing.Size(130, 294);
            this.panelOutPut_RAA.TabIndex = 0;
            // 
            // panelFunction_RAA
            // 
            this.panelFunction_RAA.Controls.Add(this.chartFunction_RAA);
            this.panelFunction_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_RAA.Location = new System.Drawing.Point(130, 109);
            this.panelFunction_RAA.Name = "panelFunction_RAA";
            this.panelFunction_RAA.Size = new System.Drawing.Size(752, 294);
            this.panelFunction_RAA.TabIndex = 0;
            // 
            // groupBoxTask_RAA
            // 
            this.groupBoxTask_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_RAA.Name = "groupBoxTask_RAA";
            this.groupBoxTask_RAA.Size = new System.Drawing.Size(510, 82);
            this.groupBoxTask_RAA.TabIndex = 0;
            this.groupBoxTask_RAA.TabStop = false;
            this.groupBoxTask_RAA.Text = "Условие:";
            // 
            // labelTask_RAA
            // 
            this.labelTask_RAA.AutoSize = true;
            this.labelTask_RAA.Location = new System.Drawing.Point(18, 30);
            this.labelTask_RAA.Name = "labelTask_RAA";
            this.labelTask_RAA.Size = new System.Drawing.Size(506, 68);
            this.labelTask_RAA.TabIndex = 0;
            this.labelTask_RAA.Text = resources.GetString("labelTask_RAA.Text");
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_RAA.Location = new System.Drawing.Point(528, 24);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(110, 70);
            this.buttonDone_RAA.TabIndex = 1;
            this.buttonDone_RAA.Text = "Выполнить";
            this.buttonDone_RAA.UseVisualStyleBackColor = false;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            // 
            // buttonOpen_RAA
            // 
            this.buttonOpen_RAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_RAA.Location = new System.Drawing.Point(644, 24);
            this.buttonOpen_RAA.Name = "buttonOpen_RAA";
            this.buttonOpen_RAA.Size = new System.Drawing.Size(110, 70);
            this.buttonOpen_RAA.TabIndex = 1;
            this.buttonOpen_RAA.Text = "Открыть\r\nфайл";
            this.buttonOpen_RAA.UseVisualStyleBackColor = false;
            this.buttonOpen_RAA.Click += new System.EventHandler(this.buttonOpen_RAA_Click);
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_RAA.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(760, 24);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(110, 70);
            this.buttonHelp_RAA.TabIndex = 1;
            this.buttonHelp_RAA.Text = "Справка";
            this.buttonHelp_RAA.UseVisualStyleBackColor = false;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // chartFunction_RAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_RAA.ChartAreas.Add(chartArea2);
            this.chartFunction_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunction_RAA.Legends.Add(legend2);
            this.chartFunction_RAA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_RAA.Name = "chartFunction_RAA";
            this.chartFunction_RAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_RAA.Series.Add(series2);
            this.chartFunction_RAA.Size = new System.Drawing.Size(752, 294);
            this.chartFunction_RAA.TabIndex = 0;
            // 
            // groupBoxOutPut_RAA
            // 
            this.groupBoxOutPut_RAA.Controls.Add(this.dataGridViewOutPut_RAA);
            this.groupBoxOutPut_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_RAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_RAA.Name = "groupBoxOutPut_RAA";
            this.groupBoxOutPut_RAA.Size = new System.Drawing.Size(130, 294);
            this.groupBoxOutPut_RAA.TabIndex = 0;
            this.groupBoxOutPut_RAA.TabStop = false;
            this.groupBoxOutPut_RAA.Text = "Вывод данных:";
            // 
            // dataGridViewOutPut_RAA
            // 
            this.dataGridViewOutPut_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_RAA.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_RAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutPut_RAA.Name = "dataGridViewOutPut_RAA";
            this.dataGridViewOutPut_RAA.RowHeadersVisible = false;
            this.dataGridViewOutPut_RAA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_RAA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_RAA.Size = new System.Drawing.Size(124, 273);
            this.dataGridViewOutPut_RAA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 403);
            this.Controls.Add(this.panelFunction_RAA);
            this.Controls.Add(this.panelOutPut_RAA);
            this.Controls.Add(this.panelTask_RAA);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 13 | Редикульцева А.А.";
            this.panelTask_RAA.ResumeLayout(false);
            this.panelTask_RAA.PerformLayout();
            this.panelOutPut_RAA.ResumeLayout(false);
            this.panelFunction_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_RAA)).EndInit();
            this.groupBoxOutPut_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_RAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonOpen_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.Label labelTask_RAA;
        private System.Windows.Forms.GroupBox groupBoxTask_RAA;
        private System.Windows.Forms.Panel panelOutPut_RAA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_RAA;
        private System.Windows.Forms.Panel panelFunction_RAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_RAA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_RAA;
    }
}

