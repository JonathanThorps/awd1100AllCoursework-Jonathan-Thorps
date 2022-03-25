namespace EX1
{
    partial class TestScoresForm
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScoreBox = new System.Windows.Forms.TextBox();
            this.lblNumScores = new System.Windows.Forms.Label();
            this.lblSumScores = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.lblLowestScore = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            this.lblScoreError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblScoreError);
            this.groupBox1.Controls.Add(this.lblHighestScore);
            this.groupBox1.Controls.Add(this.lblLowestScore);
            this.groupBox1.Controls.Add(this.lblAvgScore);
            this.groupBox1.Controls.Add(this.lblSumScores);
            this.groupBox1.Controls.Add(this.lblNumScores);
            this.groupBox1.Controls.Add(this.txtScoreBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Location = new System.Drawing.Point(134, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Scores";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(47, 142);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(95, 41);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter a Test Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(44, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Scores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(44, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sum of the Test Scores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(44, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average Test Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(44, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lowest Test Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(44, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Highest Test Score:";
            // 
            // txtScoreBox
            // 
            this.txtScoreBox.Location = new System.Drawing.Point(47, 67);
            this.txtScoreBox.Name = "txtScoreBox";
            this.txtScoreBox.Size = new System.Drawing.Size(196, 22);
            this.txtScoreBox.TabIndex = 0;
            // 
            // lblNumScores
            // 
            this.lblNumScores.AutoSize = true;
            this.lblNumScores.Enabled = false;
            this.lblNumScores.Location = new System.Drawing.Point(207, 210);
            this.lblNumScores.Name = "lblNumScores";
            this.lblNumScores.Size = new System.Drawing.Size(0, 16);
            this.lblNumScores.TabIndex = 8;
            // 
            // lblSumScores
            // 
            this.lblSumScores.AutoSize = true;
            this.lblSumScores.Enabled = false;
            this.lblSumScores.Location = new System.Drawing.Point(207, 248);
            this.lblSumScores.Name = "lblSumScores";
            this.lblSumScores.Size = new System.Drawing.Size(0, 16);
            this.lblSumScores.TabIndex = 9;
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.Enabled = false;
            this.lblAvgScore.Location = new System.Drawing.Point(207, 285);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(0, 16);
            this.lblAvgScore.TabIndex = 10;
            // 
            // lblLowestScore
            // 
            this.lblLowestScore.AutoSize = true;
            this.lblLowestScore.Enabled = false;
            this.lblLowestScore.Location = new System.Drawing.Point(207, 324);
            this.lblLowestScore.Name = "lblLowestScore";
            this.lblLowestScore.Size = new System.Drawing.Size(0, 16);
            this.lblLowestScore.TabIndex = 11;
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Enabled = false;
            this.lblHighestScore.Location = new System.Drawing.Point(207, 363);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(0, 16);
            this.lblHighestScore.TabIndex = 12;
            // 
            // lblScoreError
            // 
            this.lblScoreError.AutoSize = true;
            this.lblScoreError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreError.ForeColor = System.Drawing.Color.Red;
            this.lblScoreError.Location = new System.Drawing.Point(44, 106);
            this.lblScoreError.Name = "lblScoreError";
            this.lblScoreError.Size = new System.Drawing.Size(253, 16);
            this.lblScoreError.TabIndex = 13;
            this.lblScoreError.Text = "**Please Enter a Valid Test Score**";
            this.lblScoreError.Visible = false;
            // 
            // TestScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestScoresForm";
            this.Text = "TestScoresForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHighestScore;
        private System.Windows.Forms.Label lblLowestScore;
        private System.Windows.Forms.Label lblAvgScore;
        private System.Windows.Forms.Label lblSumScores;
        private System.Windows.Forms.Label lblNumScores;
        private System.Windows.Forms.TextBox txtScoreBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblScoreError;
    }
}

