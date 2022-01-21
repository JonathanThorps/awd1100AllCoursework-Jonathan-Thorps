namespace LAB2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hurricaneScale = new System.Windows.Forms.GroupBox();
            this.windSpeedIn = new System.Windows.Forms.TextBox();
            this.categoryOut = new System.Windows.Forms.TextBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.hurricaneScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // hurricaneScale
            // 
            this.hurricaneScale.Controls.Add(this.btnEstimate);
            this.hurricaneScale.Controls.Add(this.categoryOut);
            this.hurricaneScale.Controls.Add(this.windSpeedIn);
            this.hurricaneScale.Location = new System.Drawing.Point(198, 45);
            this.hurricaneScale.Name = "hurricaneScale";
            this.hurricaneScale.Size = new System.Drawing.Size(413, 228);
            this.hurricaneScale.TabIndex = 0;
            this.hurricaneScale.TabStop = false;
            this.hurricaneScale.Text = "Saffir-Simpson Hurricane Scale";
            // 
            // windSpeedIn
            // 
            this.windSpeedIn.Location = new System.Drawing.Point(27, 87);
            this.windSpeedIn.Name = "windSpeedIn";
            this.windSpeedIn.Size = new System.Drawing.Size(100, 23);
            this.windSpeedIn.TabIndex = 0;
            // 
            // categoryOut
            // 
            this.categoryOut.Location = new System.Drawing.Point(288, 87);
            this.categoryOut.Name = "categoryOut";
            this.categoryOut.ReadOnly = true;
            this.categoryOut.Size = new System.Drawing.Size(100, 23);
            this.categoryOut.TabIndex = 1;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(162, 70);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(100, 54);
            this.btnEstimate.TabIndex = 2;
            this.btnEstimate.Text = "Estimate";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hurricaneScale);
            this.Name = "Form1";
            this.Text = "Hurrican Scale";
            this.hurricaneScale.ResumeLayout(false);
            this.hurricaneScale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox hurricaneScale;
        private Button btnEstimate;
        private TextBox categoryOut;
        private TextBox windSpeedIn;
    }
}