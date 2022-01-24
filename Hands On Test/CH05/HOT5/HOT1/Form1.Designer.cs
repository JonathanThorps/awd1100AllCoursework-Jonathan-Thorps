namespace HOT1
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
            this.label1 = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.measureBox = new System.Windows.Forms.TextBox();
            this.convertResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.convertResult);
            this.groupBox1.Controls.Add(this.measureBox);
            this.groupBox1.Controls.Add(this.convertBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(215, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance Converter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance in Inches";
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(32, 105);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(100, 45);
            this.convertBtn.TabIndex = 1;
            this.convertBtn.Text = "Convert to cm";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // measureBox
            // 
            this.measureBox.Location = new System.Drawing.Point(32, 58);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(100, 23);
            this.measureBox.TabIndex = 0;
            // 
            // convertResult
            // 
            this.convertResult.AutoSize = true;
            this.convertResult.Location = new System.Drawing.Point(32, 171);
            this.convertResult.Name = "convertResult";
            this.convertResult.Size = new System.Drawing.Size(0, 15);
            this.convertResult.TabIndex = 3;
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
        private Label convertResult;
        private TextBox measureBox;
        private Button convertBtn;
        private Label label1;
    }
}