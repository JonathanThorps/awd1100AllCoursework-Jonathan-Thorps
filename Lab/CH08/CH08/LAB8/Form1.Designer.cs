namespace LAB8
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
            this.maskBtn = new System.Windows.Forms.Button();
            this.lblCardMask = new System.Windows.Forms.Label();
            this.cardNumBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskBtn
            // 
            this.maskBtn.Location = new System.Drawing.Point(555, 155);
            this.maskBtn.Name = "maskBtn";
            this.maskBtn.Size = new System.Drawing.Size(94, 29);
            this.maskBtn.TabIndex = 0;
            this.maskBtn.Text = "Mask";
            this.maskBtn.UseVisualStyleBackColor = true;
            this.maskBtn.Click += new System.EventHandler(this.maskBtn_Click);
            // 
            // lblCardMask
            // 
            this.lblCardMask.AutoSize = true;
            this.lblCardMask.Location = new System.Drawing.Point(146, 228);
            this.lblCardMask.Name = "lblCardMask";
            this.lblCardMask.Size = new System.Drawing.Size(0, 20);
            this.lblCardMask.TabIndex = 1;
            // 
            // cardNumBox
            // 
            this.cardNumBox.Location = new System.Drawing.Point(146, 155);
            this.cardNumBox.Name = "cardNumBox";
            this.cardNumBox.Size = new System.Drawing.Size(319, 27);
            this.cardNumBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardNumBox);
            this.Controls.Add(this.lblCardMask);
            this.Controls.Add(this.maskBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button maskBtn;
        private Label lblCardMask;
        private TextBox cardNumBox;
    }
}