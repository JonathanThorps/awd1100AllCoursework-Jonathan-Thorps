namespace LAB3;

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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFirst);
            this.groupBox1.Controls.Add(this.lblSecond);
            this.groupBox1.Controls.Add(this.lblThird);
            this.groupBox1.Controls.Add(this.lblLast);
            this.groupBox1.Controls.Add(this.reverseBtn);
            this.groupBox1.Controls.Add(this.txtBox4);
            this.groupBox1.Controls.Add(this.txtBox3);
            this.groupBox1.Controls.Add(this.txtBox2);
            this.groupBox1.Controls.Add(this.txtBox1);
            this.groupBox1.Location = new System.Drawing.Point(90, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reverse 4";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(472, 185);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 20);
            this.lblFirst.TabIndex = 8;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(325, 185);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(0, 20);
            this.lblSecond.TabIndex = 7;
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Location = new System.Drawing.Point(175, 185);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(0, 20);
            this.lblThird.TabIndex = 6;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(21, 185);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(0, 20);
            this.lblLast.TabIndex = 5;
            // 
            // reverseBtn
            // 
            this.reverseBtn.Location = new System.Drawing.Point(21, 105);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(125, 47);
            this.reverseBtn.TabIndex = 4;
            this.reverseBtn.Text = "Reverse";
            this.reverseBtn.UseVisualStyleBackColor = true;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(472, 45);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(125, 27);
            this.txtBox4.TabIndex = 3;
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(325, 45);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(125, 27);
            this.txtBox3.TabIndex = 2;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(175, 45);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(125, 27);
            this.txtBox2.TabIndex = 1;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(21, 45);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(125, 27);
            this.txtBox1.TabIndex = 0;
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
    private Button reverseBtn;
    private TextBox txtBox4;
    private TextBox txtBox3;
    private TextBox txtBox2;
    private TextBox txtBox1;
    private Label lblThird;
    private Label lblLast;
    private Label lblFirst;
    private Label lblSecond;
}
