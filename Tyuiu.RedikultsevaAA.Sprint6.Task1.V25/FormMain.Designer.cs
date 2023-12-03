
namespace Tyuiu.RedikultsevaAA.Sprint6.Task1.V25
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
            this.groupBoxResult_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult_RAA = new System.Windows.Forms.Label();
            this.groupBoxTask_RAA = new System.Windows.Forms.GroupBox();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.buttonReference_RAA = new System.Windows.Forms.Button();
            this.textBoxStopValue_RAA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_RAA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_RAA = new System.Windows.Forms.GroupBox();
            this.labelStopValue_RAA = new System.Windows.Forms.Label();
            this.labelStartValue_RAA = new System.Windows.Forms.Label();
            this.labelTask_RAA = new System.Windows.Forms.Label();
            this.groupBoxResult_RAA.SuspendLayout();
            this.groupBoxTask_RAA.SuspendLayout();
            this.groupBoxInPut_RAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult_RAA
            // 
            this.groupBoxResult_RAA.Controls.Add(this.textBoxResult);
            this.groupBoxResult_RAA.Controls.Add(this.labelResult_RAA);
            this.groupBoxResult_RAA.Location = new System.Drawing.Point(541, 7);
            this.groupBoxResult_RAA.Name = "groupBoxResult_RAA";
            this.groupBoxResult_RAA.Size = new System.Drawing.Size(249, 431);
            this.groupBoxResult_RAA.TabIndex = 0;
            this.groupBoxResult_RAA.TabStop = false;
            this.groupBoxResult_RAA.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(11, 38);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(228, 376);
            this.textBoxResult.TabIndex = 1;
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
            this.groupBoxTask_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_RAA.Name = "groupBoxTask_RAA";
            this.groupBoxTask_RAA.Size = new System.Drawing.Size(523, 345);
            this.groupBoxTask_RAA.TabIndex = 1;
            this.groupBoxTask_RAA.TabStop = false;
            this.groupBoxTask_RAA.Text = "Условие";
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_RAA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDone_RAA.FlatAppearance.BorderSize = 5;
            this.buttonDone_RAA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDone_RAA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_RAA.Location = new System.Drawing.Point(392, 363);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(143, 75);
            this.buttonDone_RAA.TabIndex = 2;
            this.buttonDone_RAA.Text = "Выполнить";
            this.buttonDone_RAA.UseVisualStyleBackColor = false;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            // 
            // buttonReference_RAA
            // 
            this.buttonReference_RAA.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonReference_RAA.FlatAppearance.BorderSize = 5;
            this.buttonReference_RAA.Location = new System.Drawing.Point(283, 363);
            this.buttonReference_RAA.Name = "buttonReference_RAA";
            this.buttonReference_RAA.Size = new System.Drawing.Size(100, 75);
            this.buttonReference_RAA.TabIndex = 3;
            this.buttonReference_RAA.Text = "Справка";
            this.buttonReference_RAA.UseVisualStyleBackColor = false;
            this.buttonReference_RAA.Click += new System.EventHandler(this.buttonReference_RAA_Click);
            // 
            // textBoxStopValue_RAA
            // 
            this.textBoxStopValue_RAA.Location = new System.Drawing.Point(136, 38);
            this.textBoxStopValue_RAA.Name = "textBoxStopValue_RAA";
            this.textBoxStopValue_RAA.Size = new System.Drawing.Size(123, 20);
            this.textBoxStopValue_RAA.TabIndex = 4;
            this.textBoxStopValue_RAA.Text = "5";
            // 
            // textBoxStartValue_RAA
            // 
            this.textBoxStartValue_RAA.Location = new System.Drawing.Point(6, 38);
            this.textBoxStartValue_RAA.Name = "textBoxStartValue_RAA";
            this.textBoxStartValue_RAA.Size = new System.Drawing.Size(124, 20);
            this.textBoxStartValue_RAA.TabIndex = 0;
            this.textBoxStartValue_RAA.Text = "-5";
            // 
            // groupBoxInPut_RAA
            // 
            this.groupBoxInPut_RAA.Controls.Add(this.labelStopValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.labelStartValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.textBoxStopValue_RAA);
            this.groupBoxInPut_RAA.Controls.Add(this.textBoxStartValue_RAA);
            this.groupBoxInPut_RAA.Location = new System.Drawing.Point(12, 363);
            this.groupBoxInPut_RAA.Name = "groupBoxInPut_RAA";
            this.groupBoxInPut_RAA.Size = new System.Drawing.Size(265, 75);
            this.groupBoxInPut_RAA.TabIndex = 0;
            this.groupBoxInPut_RAA.TabStop = false;
            this.groupBoxInPut_RAA.Text = "Ввод данных";
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
            // labelStartValue_RAA
            // 
            this.labelStartValue_RAA.AutoSize = true;
            this.labelStartValue_RAA.Location = new System.Drawing.Point(6, 16);
            this.labelStartValue_RAA.Name = "labelStartValue_RAA";
            this.labelStartValue_RAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_RAA.TabIndex = 0;
            this.labelStartValue_RAA.Text = "Старт шага:";
            // 
            // labelTask_RAA
            // 
            this.labelTask_RAA.AutoSize = true;
            this.labelTask_RAA.Location = new System.Drawing.Point(6, 16);
            this.labelTask_RAA.Name = "labelTask_RAA";
            this.labelTask_RAA.Size = new System.Drawing.Size(305, 26);
            this.labelTask_RAA.TabIndex = 0;
            this.labelTask_RAA.Text = "Протабулировать функцию sin(x) на заданном диапозоне.  \r\nРезультат вывести в виде" +
    " таблицы";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxInPut_RAA);
            this.Controls.Add(this.buttonReference_RAA);
            this.Controls.Add(this.buttonDone_RAA);
            this.Controls.Add(this.groupBoxTask_RAA);
            this.Controls.Add(this.groupBoxResult_RAA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 25 | Редикульцева А.А.";
            this.groupBoxResult_RAA.ResumeLayout(false);
            this.groupBoxResult_RAA.PerformLayout();
            this.groupBoxTask_RAA.ResumeLayout(false);
            this.groupBoxTask_RAA.PerformLayout();
            this.groupBoxInPut_RAA.ResumeLayout(false);
            this.groupBoxInPut_RAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult_RAA;
        private System.Windows.Forms.Label labelResult_RAA;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxTask_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.Button buttonReference_RAA;
        private System.Windows.Forms.TextBox textBoxStopValue_RAA;
        private System.Windows.Forms.TextBox textBoxStartValue_RAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_RAA;
        private System.Windows.Forms.Label labelStopValue_RAA;
        private System.Windows.Forms.Label labelStartValue_RAA;
        private System.Windows.Forms.Label labelTask_RAA;
    }
}

