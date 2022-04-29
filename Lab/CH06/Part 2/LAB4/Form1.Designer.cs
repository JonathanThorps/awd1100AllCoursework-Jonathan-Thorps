namespace LAB4
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
            this.phraseBox = new System.Windows.Forms.TextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.lblSortOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSortOutput);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Controls.Add(this.phraseBox);
            this.groupBox1.Location = new System.Drawing.Point(97, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorted Phrase";
            // 
            // phraseBox
            // 
            this.phraseBox.Location = new System.Drawing.Point(63, 70);
            this.phraseBox.Name = "phraseBox";
            this.phraseBox.Size = new System.Drawing.Size(501, 27);
            this.phraseBox.TabIndex = 0;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(63, 133);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(94, 29);
            this.sortBtn.TabIndex = 1;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // lblSortOutput
            // 
            this.lblSortOutput.AutoSize = true;
            this.lblSortOutput.Location = new System.Drawing.Point(63, 199);
            this.lblSortOutput.Name = "lblSortOutput";
            this.lblSortOutput.Size = new System.Drawing.Size(0, 20);
            this.lblSortOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
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
        private Label lblSortOutput;
        private Button sortBtn;
        private TextBox phraseBox;
    }
}