namespace GradingLetterMark
{
    partial class FrmGradingLetterMark
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(146, 97);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(140, 44);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // FrmGradingLetterMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 271);
            this.Controls.Add(this.BtnCalculate);
            this.Name = "FrmGradingLetterMark";
            this.Text = "Grading Letter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
    }
}

