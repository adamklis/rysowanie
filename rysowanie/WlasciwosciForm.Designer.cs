namespace rysowanie
{
    partial class WlasciwosciForm
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
            this.numPrzeuniecieProfiluX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrzeuniecieProfiluX)).BeginInit();
            this.SuspendLayout();
            // 
            // numPrzeuniecieProfiluX
            // 
            this.numPrzeuniecieProfiluX.Location = new System.Drawing.Point(189, 53);
            this.numPrzeuniecieProfiluX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numPrzeuniecieProfiluX.Name = "numPrzeuniecieProfiluX";
            this.numPrzeuniecieProfiluX.Size = new System.Drawing.Size(86, 26);
            this.numPrzeuniecieProfiluX.TabIndex = 0;
            this.numPrzeuniecieProfiluX.ValueChanged += new System.EventHandler(this.numPrzeuniecieProfiluX_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Przesunięcie profilu (X)";
            // 
            // WlasciwosciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPrzeuniecieProfiluX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WlasciwosciForm";
            this.Text = "WlasciwosciForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WlasciwosciForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numPrzeuniecieProfiluX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPrzeuniecieProfiluX;
        private System.Windows.Forms.Label label1;
    }
}