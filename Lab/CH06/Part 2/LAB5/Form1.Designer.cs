namespace LAB5
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
            this.biddingBox = new System.Windows.Forms.TextBox();
            this.bidBtn = new System.Windows.Forms.Button();
            this.lblBidStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBidStatus);
            this.groupBox1.Controls.Add(this.bidBtn);
            this.groupBox1.Controls.Add(this.biddingBox);
            this.groupBox1.Location = new System.Drawing.Point(85, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auction";
            // 
            // biddingBox
            // 
            this.biddingBox.Location = new System.Drawing.Point(29, 57);
            this.biddingBox.Name = "biddingBox";
            this.biddingBox.Size = new System.Drawing.Size(235, 27);
            this.biddingBox.TabIndex = 0;
            // 
            // bidBtn
            // 
            this.bidBtn.Location = new System.Drawing.Point(351, 56);
            this.bidBtn.Name = "bidBtn";
            this.bidBtn.Size = new System.Drawing.Size(94, 29);
            this.bidBtn.TabIndex = 1;
            this.bidBtn.Text = "Bid";
            this.bidBtn.UseVisualStyleBackColor = true;
            this.bidBtn.Click += new System.EventHandler(this.bidBtn_Click);
            // 
            // lblBidStatus
            // 
            this.lblBidStatus.AutoSize = true;
            this.lblBidStatus.Location = new System.Drawing.Point(29, 125);
            this.lblBidStatus.Name = "lblBidStatus";
            this.lblBidStatus.Size = new System.Drawing.Size(0, 20);
            this.lblBidStatus.TabIndex = 2;
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
        private Label lblBidStatus;
        private Button bidBtn;
        private TextBox biddingBox;
    }
}