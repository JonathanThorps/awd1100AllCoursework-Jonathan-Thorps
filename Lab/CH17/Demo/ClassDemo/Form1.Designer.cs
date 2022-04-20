namespace ClassDemo
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
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(49, 58);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(106, 48);
            this.btnAuthor.TabIndex = 0;
            this.btnAuthor.Text = "Author";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnPublisher
            // 
            this.btnPublisher.Location = new System.Drawing.Point(49, 124);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(106, 48);
            this.btnPublisher.TabIndex = 1;
            this.btnPublisher.Text = "Publisher";
            this.btnPublisher.UseVisualStyleBackColor = true;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(49, 188);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(106, 48);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnPublisher);
            this.Controls.Add(this.btnAuthor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnBook;
    }
}

