namespace Twitter
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
            this.btnPost = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.postMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(264, 252);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(99, 42);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(264, 132);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(375, 97);
            this.txtBox.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(148, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // postMessage
            // 
            this.postMessage.AutoSize = true;
            this.postMessage.Location = new System.Drawing.Point(148, 135);
            this.postMessage.Name = "postMessage";
            this.postMessage.Size = new System.Drawing.Size(110, 15);
            this.postMessage.TabIndex = 3;
            this.postMessage.Text = "Post Your Thoughts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postMessage);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnPost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPost;
        private TextBox txtBox;
        private Label lblUsername;
        private Label postMessage;
    }
}