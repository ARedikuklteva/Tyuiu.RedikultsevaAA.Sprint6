
namespace Tyuiu.RedikultsevAA.Sprint6.Task7.V16
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_RAA = new System.Windows.Forms.PictureBox();
            this.labelAvatar_RAA = new System.Windows.Forms.Label();
            this.buttonOK_RAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_RAA
            // 
            this.pictureBoxAvatar_RAA.Image = global::Tyuiu.RedikultsevAA.Sprint6.Task7.V16.Properties.Resources.photo;
            this.pictureBoxAvatar_RAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_RAA.Name = "pictureBoxAvatar_RAA";
            this.pictureBoxAvatar_RAA.Size = new System.Drawing.Size(129, 179);
            this.pictureBoxAvatar_RAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_RAA.TabIndex = 0;
            this.pictureBoxAvatar_RAA.TabStop = false;
            // 
            // labelAvatar_RAA
            // 
            this.labelAvatar_RAA.AutoSize = true;
            this.labelAvatar_RAA.Location = new System.Drawing.Point(147, 12);
            this.labelAvatar_RAA.Name = "labelAvatar_RAA";
            this.labelAvatar_RAA.Size = new System.Drawing.Size(383, 153);
            this.labelAvatar_RAA.TabIndex = 1;
            this.labelAvatar_RAA.Text = resources.GetString("labelAvatar_RAA.Text");
            // 
            // buttonOK_RAA
            // 
            this.buttonOK_RAA.Location = new System.Drawing.Point(445, 177);
            this.buttonOK_RAA.Name = "buttonOK_RAA";
            this.buttonOK_RAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_RAA.TabIndex = 2;
            this.buttonOK_RAA.Text = "Ok";
            this.buttonOK_RAA.UseVisualStyleBackColor = true;
            this.buttonOK_RAA.Click += new System.EventHandler(this.buttonOK_RAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 203);
            this.Controls.Add(this.buttonOK_RAA);
            this.Controls.Add(this.labelAvatar_RAA);
            this.Controls.Add(this.pictureBoxAvatar_RAA);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_RAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_RAA;
        private System.Windows.Forms.Label labelAvatar_RAA;
        private System.Windows.Forms.Button buttonOK_RAA;
    }
}