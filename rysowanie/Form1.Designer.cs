namespace rysowanie
{
    partial class Form1
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
            this.studniaPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studniaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studniaPictureBox
            // 
            this.studniaPictureBox.BackColor = System.Drawing.Color.White;
            this.studniaPictureBox.Location = new System.Drawing.Point(455, 40);
            this.studniaPictureBox.Name = "studniaPictureBox";
            this.studniaPictureBox.Size = new System.Drawing.Size(500, 700);
            this.studniaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studniaPictureBox.TabIndex = 0;
            this.studniaPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 866);
            this.Controls.Add(this.studniaPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studniaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox studniaPictureBox;
    }
}

