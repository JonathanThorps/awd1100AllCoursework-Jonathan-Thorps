namespace LAB1
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
            this.admissionBox = new System.Windows.Forms.GroupBox();
            this.admitOutput = new System.Windows.Forms.Label();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.testScore = new System.Windows.Forms.Label();
            this.gpa = new System.Windows.Forms.Label();
            this.testScoreInput = new System.Windows.Forms.TextBox();
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.admissionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // admissionBox
            // 
            this.admissionBox.Controls.Add(this.admitOutput);
            this.admissionBox.Controls.Add(this.btnAdmit);
            this.admissionBox.Controls.Add(this.testScore);
            this.admissionBox.Controls.Add(this.gpa);
            this.admissionBox.Controls.Add(this.testScoreInput);
            this.admissionBox.Controls.Add(this.gpaInput);
            this.admissionBox.Location = new System.Drawing.Point(174, 40);
            this.admissionBox.Name = "admissionBox";
            this.admissionBox.Size = new System.Drawing.Size(458, 254);
            this.admissionBox.TabIndex = 0;
            this.admissionBox.TabStop = false;
            this.admissionBox.Text = "College Admission";
            // 
            // admitOutput
            // 
            this.admitOutput.AutoSize = true;
            this.admitOutput.Location = new System.Drawing.Point(193, 167);
            this.admitOutput.Name = "admitOutput";
            this.admitOutput.Size = new System.Drawing.Size(0, 15);
            this.admitOutput.TabIndex = 5;
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(24, 150);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(100, 49);
            this.btnAdmit.TabIndex = 4;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // testScore
            // 
            this.testScore.AutoSize = true;
            this.testScore.Location = new System.Drawing.Point(272, 57);
            this.testScore.Name = "testScore";
            this.testScore.Size = new System.Drawing.Size(118, 15);
            this.testScore.TabIndex = 3;
            this.testScore.Text = "Admission Test Score";
            // 
            // gpa
            // 
            this.gpa.AutoSize = true;
            this.gpa.Enabled = false;
            this.gpa.Location = new System.Drawing.Point(24, 57);
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(29, 15);
            this.gpa.TabIndex = 2;
            this.gpa.Text = "GPA";
            // 
            // testScoreInput
            // 
            this.testScoreInput.Location = new System.Drawing.Point(272, 96);
            this.testScoreInput.Name = "testScoreInput";
            this.testScoreInput.Size = new System.Drawing.Size(100, 23);
            this.testScoreInput.TabIndex = 1;
            // 
            // gpaInput
            // 
            this.gpaInput.Location = new System.Drawing.Point(24, 96);
            this.gpaInput.Name = "gpaInput";
            this.gpaInput.Size = new System.Drawing.Size(100, 23);
            this.gpaInput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admissionBox);
            this.Name = "Form1";
            this.Text = "College Admission";
            this.admissionBox.ResumeLayout(false);
            this.admissionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox admissionBox;
        private Label admitOutput;
        private Button btnAdmit;
        private Label testScore;
        private Label gpa;
        private TextBox testScoreInput;
        private TextBox gpaInput;
    }
}