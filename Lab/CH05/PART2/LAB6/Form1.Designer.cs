namespace LAB6
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numScoresBox = new System.Windows.Forms.TextBox();
            this.SumScoresBox = new System.Windows.Forms.TextBox();
            this.avgScoresBox = new System.Windows.Forms.TextBox();
            this.lowScoreBox = new System.Windows.Forms.TextBox();
            this.highScoreBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter a Test Score";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.highScoreBox);
            this.groupBox1.Controls.Add(this.lowScoreBox);
            this.groupBox1.Controls.Add(this.avgScoresBox);
            this.groupBox1.Controls.Add(this.SumScoresBox);
            this.groupBox1.Controls.Add(this.numScoresBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.enterBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.scoreBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(188, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 324);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Scores";
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(85, 57);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(100, 20);
            this.scoreBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Scores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sum of Test Scores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average Test Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lowest Test Score";
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(85, 99);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(78, 37);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Highest Test Score";
            // 
            // numScoresBox
            // 
            this.numScoresBox.Location = new System.Drawing.Point(229, 163);
            this.numScoresBox.Name = "numScoresBox";
            this.numScoresBox.ReadOnly = true;
            this.numScoresBox.Size = new System.Drawing.Size(100, 20);
            this.numScoresBox.TabIndex = 8;
            // 
            // SumScoresBox
            // 
            this.SumScoresBox.Location = new System.Drawing.Point(229, 192);
            this.SumScoresBox.Name = "SumScoresBox";
            this.SumScoresBox.ReadOnly = true;
            this.SumScoresBox.Size = new System.Drawing.Size(100, 20);
            this.SumScoresBox.TabIndex = 9;
            // 
            // avgScoresBox
            // 
            this.avgScoresBox.Location = new System.Drawing.Point(229, 218);
            this.avgScoresBox.Name = "avgScoresBox";
            this.avgScoresBox.ReadOnly = true;
            this.avgScoresBox.Size = new System.Drawing.Size(100, 20);
            this.avgScoresBox.TabIndex = 10;
            // 
            // lowScoreBox
            // 
            this.lowScoreBox.Location = new System.Drawing.Point(229, 249);
            this.lowScoreBox.Name = "lowScoreBox";
            this.lowScoreBox.ReadOnly = true;
            this.lowScoreBox.Size = new System.Drawing.Size(100, 20);
            this.lowScoreBox.TabIndex = 11;
            // 
            // highScoreBox
            // 
            this.highScoreBox.Location = new System.Drawing.Point(229, 278);
            this.highScoreBox.Name = "highScoreBox";
            this.highScoreBox.ReadOnly = true;
            this.highScoreBox.Size = new System.Drawing.Size(100, 20);
            this.highScoreBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox highScoreBox;
        private System.Windows.Forms.TextBox lowScoreBox;
        private System.Windows.Forms.TextBox avgScoresBox;
        private System.Windows.Forms.TextBox SumScoresBox;
        private System.Windows.Forms.TextBox numScoresBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scoreBox;
    }
}

