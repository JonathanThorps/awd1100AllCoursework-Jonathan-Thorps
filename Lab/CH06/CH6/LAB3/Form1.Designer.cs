namespace LAB3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFortune1 = new System.Windows.Forms.Label();
            this.lblFortune2 = new System.Windows.Forms.Label();
            this.openCookieBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openCookieBtn);
            this.groupBox1.Controls.Add(this.lblFortune2);
            this.groupBox1.Controls.Add(this.lblFortune1);
            this.groupBox1.Location = new System.Drawing.Point(91, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fortune Cookie";
            // 
            // lblFortune1
            // 
            this.lblFortune1.AutoSize = true;
            this.lblFortune1.Location = new System.Drawing.Point(34, 124);
            this.lblFortune1.Name = "lblFortune1";
            this.lblFortune1.Size = new System.Drawing.Size(0, 16);
            this.lblFortune1.TabIndex = 0;
            // 
            // lblFortune2
            // 
            this.lblFortune2.AutoSize = true;
            this.lblFortune2.Location = new System.Drawing.Point(34, 176);
            this.lblFortune2.Name = "lblFortune2";
            this.lblFortune2.Size = new System.Drawing.Size(0, 16);
            this.lblFortune2.TabIndex = 1;
            // 
            // openCookieBtn
            // 
            this.openCookieBtn.Location = new System.Drawing.Point(37, 37);
            this.openCookieBtn.Name = "openCookieBtn";
            this.openCookieBtn.Size = new System.Drawing.Size(113, 50);
            this.openCookieBtn.TabIndex = 2;
            this.openCookieBtn.Text = "Open";
            this.openCookieBtn.UseVisualStyleBackColor = true;
            this.openCookieBtn.Click += new System.EventHandler(this.openCookieBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Fortune Cookie";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openCookieBtn;
        private System.Windows.Forms.Label lblFortune2;
        private System.Windows.Forms.Label lblFortune1;
    }
}

