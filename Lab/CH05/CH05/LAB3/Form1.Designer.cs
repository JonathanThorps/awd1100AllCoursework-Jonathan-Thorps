namespace LAB3
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.playerChoice = new System.Windows.Forms.Label();
            this.computerChoice = new System.Windows.Forms.Label();
            this.roundResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(196, 187);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(99, 47);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(348, 187);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(98, 47);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(503, 187);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(96, 47);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // playerChoice
            // 
            this.playerChoice.AutoSize = true;
            this.playerChoice.Location = new System.Drawing.Point(196, 281);
            this.playerChoice.Name = "playerChoice";
            this.playerChoice.Size = new System.Drawing.Size(0, 15);
            this.playerChoice.TabIndex = 3;
            // 
            // computerChoice
            // 
            this.computerChoice.AutoSize = true;
            this.computerChoice.Location = new System.Drawing.Point(503, 281);
            this.computerChoice.Name = "computerChoice";
            this.computerChoice.Size = new System.Drawing.Size(0, 15);
            this.computerChoice.TabIndex = 4;
            // 
            // roundResult
            // 
            this.roundResult.AutoSize = true;
            this.roundResult.Location = new System.Drawing.Point(199, 343);
            this.roundResult.Name = "roundResult";
            this.roundResult.Size = new System.Drawing.Size(0, 15);
            this.roundResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundResult);
            this.Controls.Add(this.computerChoice);
            this.Controls.Add(this.playerChoice);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Label playerChoice;
        private Label computerChoice;
        private Label roundResult;
    }
}