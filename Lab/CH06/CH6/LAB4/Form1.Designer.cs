namespace LAB4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpaScoreBox = new System.Windows.Forms.TextBox();
            this.testScoreBox = new System.Windows.Forms.TextBox();
            this.admitBtn = new System.Windows.Forms.Button();
            this.lblAdmitOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdmitOutput);
            this.groupBox1.Controls.Add(this.admitBtn);
            this.groupBox1.Controls.Add(this.testScoreBox);
            this.groupBox1.Controls.Add(this.gpaScoreBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(135, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "College Admission";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admission Test Score";
            // 
            // gpaScoreBox
            // 
            this.gpaScoreBox.Location = new System.Drawing.Point(59, 114);
            this.gpaScoreBox.Name = "gpaScoreBox";
            this.gpaScoreBox.Size = new System.Drawing.Size(140, 22);
            this.gpaScoreBox.TabIndex = 2;
            // 
            // testScoreBox
            // 
            this.testScoreBox.Location = new System.Drawing.Point(310, 114);
            this.testScoreBox.Name = "testScoreBox";
            this.testScoreBox.Size = new System.Drawing.Size(140, 22);
            this.testScoreBox.TabIndex = 3;
            // 
            // admitBtn
            // 
            this.admitBtn.Location = new System.Drawing.Point(59, 191);
            this.admitBtn.Name = "admitBtn";
            this.admitBtn.Size = new System.Drawing.Size(100, 41);
            this.admitBtn.TabIndex = 4;
            this.admitBtn.Text = "Admit";
            this.admitBtn.UseVisualStyleBackColor = true;
            this.admitBtn.Click += new System.EventHandler(this.admitBtn_Click);
            // 
            // lblAdmitOutput
            // 
            this.lblAdmitOutput.AutoSize = true;
            this.lblAdmitOutput.Location = new System.Drawing.Point(307, 203);
            this.lblAdmitOutput.Name = "lblAdmitOutput";
            this.lblAdmitOutput.Size = new System.Drawing.Size(0, 16);
            this.lblAdmitOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "College Admission";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdmitOutput;
        private System.Windows.Forms.Button admitBtn;
        private System.Windows.Forms.TextBox testScoreBox;
        private System.Windows.Forms.TextBox gpaScoreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

