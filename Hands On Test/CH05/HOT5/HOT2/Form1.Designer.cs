namespace HOT2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.gradeBtn = new System.Windows.Forms.Button();
            this.gradeResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gradeBox);
            this.groupBox1.Controls.Add(this.gradeBtn);
            this.groupBox1.Controls.Add(this.gradeResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(225, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Letter Grades";
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(43, 68);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(100, 23);
            this.gradeBox.TabIndex = 0;
            // 
            // gradeBtn
            // 
            this.gradeBtn.Location = new System.Drawing.Point(43, 115);
            this.gradeBtn.Name = "gradeBtn";
            this.gradeBtn.Size = new System.Drawing.Size(100, 45);
            this.gradeBtn.TabIndex = 1;
            this.gradeBtn.Text = "Show Letter Grade";
            this.gradeBtn.UseVisualStyleBackColor = true;
            this.gradeBtn.Click += new System.EventHandler(this.gradeBtn_Click);
            // 
            // gradeResult
            // 
            this.gradeResult.AutoSize = true;
            this.gradeResult.Location = new System.Drawing.Point(143, 182);
            this.gradeResult.Name = "gradeResult";
            this.gradeResult.Size = new System.Drawing.Size(0, 15);
            this.gradeResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeric Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Grade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox gradeBox;
        private Button gradeBtn;
        private Label gradeResult;
        private Label label1;
        private Label label2;
    }
}