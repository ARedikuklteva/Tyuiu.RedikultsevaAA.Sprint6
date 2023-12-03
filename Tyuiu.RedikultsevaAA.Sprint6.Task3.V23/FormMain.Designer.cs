
namespace Tyuiu.RedikultsevaAA.Sprint6.Task3.V23
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
            this.groupBoxResult_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_RAA = new System.Windows.Forms.DataGridView();
            this.labelResult_RAA = new System.Windows.Forms.Label();
            this.groupBoxTask_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_RAA = new System.Windows.Forms.DataGridView();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.labelTask_RAA = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxResult_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_RAA)).BeginInit();
            this.groupBoxTask_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxResult_RAA
            // 
            this.groupBoxResult_RAA.Controls.Add(this.dataGridViewResult_RAA);
            this.groupBoxResult_RAA.Controls.Add(this.labelResult_RAA);
            this.groupBoxResult_RAA.Location = new System.Drawing.Point(529, 12);
            this.groupBoxResult_RAA.Name = "groupBoxResult_RAA";
            this.groupBoxResult_RAA.Size = new System.Drawing.Size(259, 201);
            this.groupBoxResult_RAA.TabIndex = 0;
            this.groupBoxResult_RAA.TabStop = false;
            this.groupBoxResult_RAA.Text = "Вывод данных";
            // 
            // dataGridViewResult_RAA
            // 
            this.dataGridViewResult_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_RAA.Location = new System.Drawing.Point(10, 40);
            this.dataGridViewResult_RAA.Name = "dataGridViewResult_RAA";
            this.dataGridViewResult_RAA.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResult_RAA.TabIndex = 1;
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
            // groupBoxTask_RAA
            // 
            this.groupBoxTask_RAA.Controls.Add(this.labelTask_RAA);
            this.groupBoxTask_RAA.Controls.Add(this.dataGridViewInPut_RAA);
            this.groupBoxTask_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_RAA.Name = "groupBoxTask_RAA";
            this.groupBoxTask_RAA.Size = new System.Drawing.Size(511, 251);
            this.groupBoxTask_RAA.TabIndex = 1;
            this.groupBoxTask_RAA.TabStop = false;
            this.groupBoxTask_RAA.Text = "Условие";
            // 
            // dataGridViewInPut_RAA
            // 
            this.dataGridViewInPut_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_RAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewInPut_RAA.Location = new System.Drawing.Point(252, 16);
            this.dataGridViewInPut_RAA.Name = "dataGridViewInPut_RAA";
            this.dataGridViewInPut_RAA.RowHeadersVisible = false;
            this.dataGridViewInPut_RAA.Size = new System.Drawing.Size(248, 218);
            this.dataGridViewInPut_RAA.TabIndex = 0;
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.Location = new System.Drawing.Point(584, 236);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(24, 23);
            this.buttonHelp_RAA.TabIndex = 2;
            this.buttonHelp_RAA.Text = "?";
            this.buttonHelp_RAA.UseVisualStyleBackColor = true;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.Location = new System.Drawing.Point(653, 232);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(81, 27);
            this.buttonDone_RAA.TabIndex = 3;
            this.buttonDone_RAA.Text = "Результат";
            this.buttonDone_RAA.UseVisualStyleBackColor = true;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            // 
            // labelTask_RAA
            // 
            this.labelTask_RAA.AutoSize = true;
            this.labelTask_RAA.Location = new System.Drawing.Point(6, 16);
            this.labelTask_RAA.Name = "labelTask_RAA";
            this.labelTask_RAA.Size = new System.Drawing.Size(176, 104);
            this.labelTask_RAA.TabIndex = 1;
            this.labelTask_RAA.Text = resources.GetString("labelTask_RAA.Text");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.buttonDone_RAA);
            this.Controls.Add(this.buttonHelp_RAA);
            this.Controls.Add(this.groupBoxTask_RAA);
            this.Controls.Add(this.groupBoxResult_RAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 23 | Редикульцева А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResult_RAA.ResumeLayout(false);
            this.groupBoxResult_RAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_RAA)).EndInit();
            this.groupBoxTask_RAA.ResumeLayout(false);
            this.groupBoxTask_RAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_RAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult_RAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_RAA;
        private System.Windows.Forms.Label labelResult_RAA;
        private System.Windows.Forms.GroupBox groupBoxTask_RAA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_RAA;
        private System.Windows.Forms.Label labelTask_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

