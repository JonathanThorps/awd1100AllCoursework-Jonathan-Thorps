namespace LAB8
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
            this.woodTypeBox = new System.Windows.Forms.TextBox();
            this.numDrawerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWoodCost = new System.Windows.Forms.Label();
            this.lblDrawerCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.estimateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estimateBtn);
            this.groupBox1.Controls.Add(this.lblTotalCost);
            this.groupBox1.Controls.Add(this.lblDrawerCost);
            this.groupBox1.Controls.Add(this.lblWoodCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numDrawerBox);
            this.groupBox1.Controls.Add(this.woodTypeBox);
            this.groupBox1.Location = new System.Drawing.Point(63, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Custom Desk";
            // 
            // woodTypeBox
            // 
            this.woodTypeBox.Location = new System.Drawing.Point(66, 81);
            this.woodTypeBox.Name = "woodTypeBox";
            this.woodTypeBox.Size = new System.Drawing.Size(160, 22);
            this.woodTypeBox.TabIndex = 0;
            // 
            // numDrawerBox
            // 
            this.numDrawerBox.Location = new System.Drawing.Point(275, 81);
            this.numDrawerBox.Name = "numDrawerBox";
            this.numDrawerBox.Size = new System.Drawing.Size(152, 22);
            this.numDrawerBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of Wood";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Drawers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost of Wood";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Cost";
            // 
            // lblWoodCost
            // 
            this.lblWoodCost.AutoSize = true;
            this.lblWoodCost.Location = new System.Drawing.Point(66, 263);
            this.lblWoodCost.Name = "lblWoodCost";
            this.lblWoodCost.Size = new System.Drawing.Size(0, 16);
            this.lblWoodCost.TabIndex = 7;
            // 
            // lblDrawerCost
            // 
            this.lblDrawerCost.AutoSize = true;
            this.lblDrawerCost.Location = new System.Drawing.Point(240, 263);
            this.lblDrawerCost.Name = "lblDrawerCost";
            this.lblDrawerCost.Size = new System.Drawing.Size(0, 16);
            this.lblDrawerCost.TabIndex = 8;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(427, 263);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 16);
            this.lblTotalCost.TabIndex = 9;
            // 
            // estimateBtn
            // 
            this.estimateBtn.Location = new System.Drawing.Point(66, 130);
            this.estimateBtn.Name = "estimateBtn";
            this.estimateBtn.Size = new System.Drawing.Size(106, 37);
            this.estimateBtn.TabIndex = 10;
            this.estimateBtn.Text = "Estimate";
            this.estimateBtn.UseVisualStyleBackColor = true;
            this.estimateBtn.Click += new System.EventHandler(this.estimateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "My Custom Desk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button estimateBtn;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblDrawerCost;
        private System.Windows.Forms.Label lblWoodCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numDrawerBox;
        private System.Windows.Forms.TextBox woodTypeBox;
    }
}

