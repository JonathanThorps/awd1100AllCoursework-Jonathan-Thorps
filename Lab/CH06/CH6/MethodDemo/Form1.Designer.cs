namespace MethodDemo
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.actorBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.movieSearchBtn = new System.Windows.Forms.Button();
            this.actorSearchBtn = new System.Windows.Forms.Button();
            this.directorSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMovieOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStarringOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDirectorOut = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStudioOut = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.studioSearchBtn = new System.Windows.Forms.Button();
            this.studioBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.studioSearchBtn);
            this.groupBox1.Controls.Add(this.studioBox);
            this.groupBox1.Controls.Add(this.lblStudioOut);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblDirectorOut);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblStarringOut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblMovieOut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.directorSearchBtn);
            this.groupBox1.Controls.Add(this.actorSearchBtn);
            this.groupBox1.Controls.Add(this.movieSearchBtn);
            this.groupBox1.Controls.Add(this.directorBox);
            this.groupBox1.Controls.Add(this.actorBox);
            this.groupBox1.Controls.Add(this.titleBox);
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Search";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(166, 26);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(373, 27);
            this.titleBox.TabIndex = 0;
            // 
            // actorBox
            // 
            this.actorBox.Location = new System.Drawing.Point(166, 82);
            this.actorBox.Name = "actorBox";
            this.actorBox.Size = new System.Drawing.Size(373, 27);
            this.actorBox.TabIndex = 1;
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(166, 139);
            this.directorBox.Name = "directorBox";
            this.directorBox.Size = new System.Drawing.Size(373, 27);
            this.directorBox.TabIndex = 2;
            // 
            // movieSearchBtn
            // 
            this.movieSearchBtn.Location = new System.Drawing.Point(562, 25);
            this.movieSearchBtn.Name = "movieSearchBtn";
            this.movieSearchBtn.Size = new System.Drawing.Size(94, 29);
            this.movieSearchBtn.TabIndex = 3;
            this.movieSearchBtn.Text = "Search";
            this.movieSearchBtn.UseVisualStyleBackColor = true;
            this.movieSearchBtn.Click += new System.EventHandler(this.movieSearchBtn_Click);
            // 
            // actorSearchBtn
            // 
            this.actorSearchBtn.Location = new System.Drawing.Point(562, 81);
            this.actorSearchBtn.Name = "actorSearchBtn";
            this.actorSearchBtn.Size = new System.Drawing.Size(94, 29);
            this.actorSearchBtn.TabIndex = 4;
            this.actorSearchBtn.Text = "Search";
            this.actorSearchBtn.UseVisualStyleBackColor = true;
            this.actorSearchBtn.Click += new System.EventHandler(this.actorSearchBtn_Click);
            // 
            // directorSearchBtn
            // 
            this.directorSearchBtn.Location = new System.Drawing.Point(562, 138);
            this.directorSearchBtn.Name = "directorSearchBtn";
            this.directorSearchBtn.Size = new System.Drawing.Size(94, 29);
            this.directorSearchBtn.TabIndex = 5;
            this.directorSearchBtn.Text = "Search";
            this.directorSearchBtn.UseVisualStyleBackColor = true;
            this.directorSearchBtn.Click += new System.EventHandler(this.directorSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Movie Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actor/Actress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Title";
            // 
            // lblMovieOut
            // 
            this.lblMovieOut.AutoSize = true;
            this.lblMovieOut.Location = new System.Drawing.Point(166, 263);
            this.lblMovieOut.Name = "lblMovieOut";
            this.lblMovieOut.Size = new System.Drawing.Size(0, 20);
            this.lblMovieOut.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Starring";
            // 
            // lblStarringOut
            // 
            this.lblStarringOut.AutoSize = true;
            this.lblStarringOut.Location = new System.Drawing.Point(166, 313);
            this.lblStarringOut.Name = "lblStarringOut";
            this.lblStarringOut.Size = new System.Drawing.Size(0, 20);
            this.lblStarringOut.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Director";
            // 
            // lblDirectorOut
            // 
            this.lblDirectorOut.AutoSize = true;
            this.lblDirectorOut.Location = new System.Drawing.Point(166, 360);
            this.lblDirectorOut.Name = "lblDirectorOut";
            this.lblDirectorOut.Size = new System.Drawing.Size(0, 20);
            this.lblDirectorOut.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Studio";
            // 
            // lblStudioOut
            // 
            this.lblStudioOut.AutoSize = true;
            this.lblStudioOut.Location = new System.Drawing.Point(166, 411);
            this.lblStudioOut.Name = "lblStudioOut";
            this.lblStudioOut.Size = new System.Drawing.Size(0, 20);
            this.lblStudioOut.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Studio";
            // 
            // studioSearchBtn
            // 
            this.studioSearchBtn.Location = new System.Drawing.Point(562, 196);
            this.studioSearchBtn.Name = "studioSearchBtn";
            this.studioSearchBtn.Size = new System.Drawing.Size(94, 29);
            this.studioSearchBtn.TabIndex = 18;
            this.studioSearchBtn.Text = "Search";
            this.studioSearchBtn.UseVisualStyleBackColor = true;
            this.studioSearchBtn.Click += new System.EventHandler(this.studioSearchBtn_Click);
            // 
            // studioBox
            // 
            this.studioBox.Location = new System.Drawing.Point(166, 197);
            this.studioBox.Name = "studioBox";
            this.studioBox.Size = new System.Drawing.Size(373, 27);
            this.studioBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label12;
        private Button studioSearchBtn;
        private TextBox studioBox;
        private Label lblStudioOut;
        private Label label10;
        private Label lblDirectorOut;
        private Label label8;
        private Label lblStarringOut;
        private Label label6;
        private Label lblMovieOut;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button directorSearchBtn;
        private Button actorSearchBtn;
        private Button movieSearchBtn;
        private TextBox directorBox;
        private TextBox actorBox;
        private TextBox titleBox;
    }
}