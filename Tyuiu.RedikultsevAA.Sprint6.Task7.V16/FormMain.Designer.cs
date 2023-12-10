
namespace Tyuiu.RedikultsevAA.Sprint6.Task7.V16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTask_RAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_RAA = new System.Windows.Forms.GroupBox();
            this.labelTask_RAA = new System.Windows.Forms.Label();
            this.panelIn_RAA = new System.Windows.Forms.Panel();
            this.panelOut_RAA = new System.Windows.Forms.Panel();
            this.groupBoxOut_RAA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_RAA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_RAA = new System.Windows.Forms.DataGridView();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.buttonTask_RAA = new System.Windows.Forms.Button();
            this.buttonSave_RAA = new System.Windows.Forms.Button();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.openFileDialogTask_RAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_RAA = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_RAA = new System.Windows.Forms.SaveFileDialog();
            this.panelTask_RAA.SuspendLayout();
            this.groupBoxTask_RAA.SuspendLayout();
            this.panelIn_RAA.SuspendLayout();
            this.panelOut_RAA.SuspendLayout();
            this.groupBoxOut_RAA.SuspendLayout();
            this.groupBoxIn_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_RAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_RAA
            // 
            this.panelTask_RAA.Controls.Add(this.groupBoxTask_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonDone_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonTask_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonSave_RAA);
            this.panelTask_RAA.Controls.Add(this.buttonHelp_RAA);
            this.panelTask_RAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_RAA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_RAA.Name = "panelTask_RAA";
            this.panelTask_RAA.Size = new System.Drawing.Size(800, 155);
            this.panelTask_RAA.TabIndex = 0;
            // 
            // groupBoxTask_RAA
            // 
            this.groupBoxTask_RAA.Controls.Add(this.labelTask_RAA);
            this.groupBoxTask_RAA.Location = new System.Drawing.Point(6, 77);
            this.groupBoxTask_RAA.Name = "groupBoxTask_RAA";
            this.groupBoxTask_RAA.Size = new System.Drawing.Size(791, 77);
            this.groupBoxTask_RAA.TabIndex = 1;
            this.groupBoxTask_RAA.TabStop = false;
            this.groupBoxTask_RAA.Text = "Условие";
            // 
            // labelTask_RAA
            // 
            this.labelTask_RAA.AutoSize = true;
            this.labelTask_RAA.Location = new System.Drawing.Point(6, 18);
            this.labelTask_RAA.Name = "labelTask_RAA";
            this.labelTask_RAA.Size = new System.Drawing.Size(749, 51);
            this.labelTask_RAA.TabIndex = 0;
            this.labelTask_RAA.Text = resources.GetString("labelTask_RAA.Text");
            // 
            // panelIn_RAA
            // 
            this.panelIn_RAA.Controls.Add(this.groupBoxIn_RAA);
            this.panelIn_RAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIn_RAA.Location = new System.Drawing.Point(0, 155);
            this.panelIn_RAA.Name = "panelIn_RAA";
            this.panelIn_RAA.Size = new System.Drawing.Size(375, 295);
            this.panelIn_RAA.TabIndex = 0;
            // 
            // panelOut_RAA
            // 
            this.panelOut_RAA.Controls.Add(this.groupBoxOut_RAA);
            this.panelOut_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOut_RAA.Location = new System.Drawing.Point(375, 155);
            this.panelOut_RAA.Name = "panelOut_RAA";
            this.panelOut_RAA.Size = new System.Drawing.Size(425, 295);
            this.panelOut_RAA.TabIndex = 1;
            // 
            // groupBoxOut_RAA
            // 
            this.groupBoxOut_RAA.Controls.Add(this.dataGridViewOut_RAA);
            this.groupBoxOut_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_RAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_RAA.Name = "groupBoxOut_RAA";
            this.groupBoxOut_RAA.Size = new System.Drawing.Size(425, 295);
            this.groupBoxOut_RAA.TabIndex = 0;
            this.groupBoxOut_RAA.TabStop = false;
            this.groupBoxOut_RAA.Text = "Вывод:";
            // 
            // groupBoxIn_RAA
            // 
            this.groupBoxIn_RAA.Controls.Add(this.dataGridViewIn_RAA);
            this.groupBoxIn_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_RAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_RAA.Name = "groupBoxIn_RAA";
            this.groupBoxIn_RAA.Size = new System.Drawing.Size(375, 295);
            this.groupBoxIn_RAA.TabIndex = 0;
            this.groupBoxIn_RAA.TabStop = false;
            this.groupBoxIn_RAA.Text = "Ввод:";
            // 
            // dataGridViewIn_RAA
            // 
            this.dataGridViewIn_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_RAA.ColumnHeadersVisible = false;
            this.dataGridViewIn_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_RAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_RAA.Name = "dataGridViewIn_RAA";
            this.dataGridViewIn_RAA.RowHeadersVisible = false;
            this.dataGridViewIn_RAA.RowHeadersWidth = 51;
            this.dataGridViewIn_RAA.RowTemplate.Height = 24;
            this.dataGridViewIn_RAA.Size = new System.Drawing.Size(369, 274);
            this.dataGridViewIn_RAA.TabIndex = 0;
            // 
            // dataGridViewOut_RAA
            // 
            this.dataGridViewOut_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_RAA.ColumnHeadersVisible = false;
            this.dataGridViewOut_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_RAA.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_RAA.Name = "dataGridViewOut_RAA";
            this.dataGridViewOut_RAA.RowHeadersVisible = false;
            this.dataGridViewOut_RAA.RowHeadersWidth = 51;
            this.dataGridViewOut_RAA.RowTemplate.Height = 24;
            this.dataGridViewOut_RAA.Size = new System.Drawing.Size(419, 274);
            this.dataGridViewOut_RAA.TabIndex = 0;
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.Enabled = false;
            this.buttonDone_RAA.Image = global::Tyuiu.RedikultsevAA.Sprint6.Task7.V16.Properties.Resources.page_go;
            this.buttonDone_RAA.Location = new System.Drawing.Point(131, 12);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(119, 59);
            this.buttonDone_RAA.TabIndex = 0;
            this.toolTip_RAA.SetToolTip(this.buttonDone_RAA, "Изменить в пятой строке нечетные значения на -1");
            this.buttonDone_RAA.UseVisualStyleBackColor = true;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            // 
            // buttonTask_RAA
            // 
            this.buttonTask_RAA.Image = global::Tyuiu.RedikultsevAA.Sprint6.Task7.V16.Properties.Resources.folder_page_white;
            this.buttonTask_RAA.Location = new System.Drawing.Point(6, 12);
            this.buttonTask_RAA.Name = "buttonTask_RAA";
            this.buttonTask_RAA.Size = new System.Drawing.Size(119, 59);
            this.buttonTask_RAA.TabIndex = 0;
            this.toolTip_RAA.SetToolTip(this.buttonTask_RAA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonTask_RAA.UseVisualStyleBackColor = true;
            this.buttonTask_RAA.Click += new System.EventHandler(this.buttonTask_RAA_Click);
            // 
            // buttonSave_RAA
            // 
            this.buttonSave_RAA.Enabled = false;
            this.buttonSave_RAA.Image = global::Tyuiu.RedikultsevAA.Sprint6.Task7.V16.Properties.Resources.page_save;
            this.buttonSave_RAA.Location = new System.Drawing.Point(256, 12);
            this.buttonSave_RAA.Name = "buttonSave_RAA";
            this.buttonSave_RAA.Size = new System.Drawing.Size(119, 59);
            this.buttonSave_RAA.TabIndex = 0;
            this.toolTip_RAA.SetToolTip(this.buttonSave_RAA, "Сохранить файл");
            this.buttonSave_RAA.UseVisualStyleBackColor = true;
            this.buttonSave_RAA.Click += new System.EventHandler(this.buttonSave_RAA_Click);
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_RAA.Image = global::Tyuiu.RedikultsevAA.Sprint6.Task7.V16.Properties.Resources.help;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(669, 12);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(119, 59);
            this.buttonHelp_RAA.TabIndex = 0;
            this.toolTip_RAA.SetToolTip(this.buttonHelp_RAA, "Свединие о программе");
            this.buttonHelp_RAA.UseVisualStyleBackColor = true;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // openFileDialogTask_RAA
            // 
            this.openFileDialogTask_RAA.FileName = "openFileDialog1";
            // 
            // toolTip_RAA
            // 
            this.toolTip_RAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOut_RAA);
            this.Controls.Add(this.panelIn_RAA);
            this.Controls.Add(this.panelTask_RAA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 13 | Редикульцева А.А.";
            this.panelTask_RAA.ResumeLayout(false);
            this.groupBoxTask_RAA.ResumeLayout(false);
            this.groupBoxTask_RAA.PerformLayout();
            this.panelIn_RAA.ResumeLayout(false);
            this.panelOut_RAA.ResumeLayout(false);
            this.groupBoxOut_RAA.ResumeLayout(false);
            this.groupBoxIn_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_RAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_RAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTask_RAA;
        private System.Windows.Forms.GroupBox groupBoxTask_RAA;
        private System.Windows.Forms.Label labelTask_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.Button buttonTask_RAA;
        private System.Windows.Forms.Button buttonSave_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Panel panelIn_RAA;
        private System.Windows.Forms.GroupBox groupBoxIn_RAA;
        private System.Windows.Forms.DataGridView dataGridViewIn_RAA;
        private System.Windows.Forms.Panel panelOut_RAA;
        private System.Windows.Forms.GroupBox groupBoxOut_RAA;
        private System.Windows.Forms.DataGridView dataGridViewOut_RAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_RAA;
        private System.Windows.Forms.ToolTip toolTip_RAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_RAA;
    }
}

