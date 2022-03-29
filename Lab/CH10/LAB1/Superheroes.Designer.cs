namespace LAB1
{
    partial class Superheroes
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
            this.lblHeroName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.cboHeroes = new System.Windows.Forms.ComboBox();
            this.picHeroPic = new System.Windows.Forms.PictureBox();
            this.lblDislikes = new System.Windows.Forms.Label();
            this.lblExtLink = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtBiography = new System.Windows.Forms.RichTextBox();
            this.rtSuperpowers = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroName.Location = new System.Drawing.Point(39, 62);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(0, 29);
            this.lblHeroName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Likes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dislikes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Superpowers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biography";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(174, 102);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(0, 16);
            this.lblLikes.TabIndex = 5;
            // 
            // cboHeroes
            // 
            this.cboHeroes.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Black Widow",
            "Deadpool",
            "Elektra",
            "Hulk",
            "The Punisher",
            "Wolverine"});
            this.cboHeroes.FormattingEnabled = true;
            this.cboHeroes.Items.AddRange(new object[] {
            "None",
            "Black Widow",
            "Deadpool",
            "Elektra",
            "Hulk",
            "The Punisher",
            "Wolverine"});
            this.cboHeroes.Location = new System.Drawing.Point(42, 22);
            this.cboHeroes.Name = "cboHeroes";
            this.cboHeroes.Size = new System.Drawing.Size(176, 24);
            this.cboHeroes.TabIndex = 6;
            this.cboHeroes.SelectedIndexChanged += new System.EventHandler(this.cboHeroes_SelectedIndexChanged);
            // 
            // picHeroPic
            // 
            this.picHeroPic.Location = new System.Drawing.Point(395, 36);
            this.picHeroPic.Name = "picHeroPic";
            this.picHeroPic.Size = new System.Drawing.Size(358, 417);
            this.picHeroPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeroPic.TabIndex = 7;
            this.picHeroPic.TabStop = false;
            // 
            // lblDislikes
            // 
            this.lblDislikes.AutoSize = true;
            this.lblDislikes.Location = new System.Drawing.Point(174, 137);
            this.lblDislikes.Name = "lblDislikes";
            this.lblDislikes.Size = new System.Drawing.Size(0, 16);
            this.lblDislikes.TabIndex = 8;
            // 
            // lblExtLink
            // 
            this.lblExtLink.AutoSize = true;
            this.lblExtLink.Location = new System.Drawing.Point(61, 470);
            this.lblExtLink.Name = "lblExtLink";
            this.lblExtLink.Size = new System.Drawing.Size(0, 16);
            this.lblExtLink.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtSuperpowers);
            this.groupBox1.Controls.Add(this.rtBiography);
            this.groupBox1.Controls.Add(this.lblDislikes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLikes);
            this.groupBox1.Controls.Add(this.cboHeroes);
            this.groupBox1.Controls.Add(this.lblHeroName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 488);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Superheroes";
            // 
            // rtBiography
            // 
            this.rtBiography.Location = new System.Drawing.Point(42, 327);
            this.rtBiography.Name = "rtBiography";
            this.rtBiography.ReadOnly = true;
            this.rtBiography.Size = new System.Drawing.Size(306, 112);
            this.rtBiography.TabIndex = 0;
            this.rtBiography.Text = "";
            // 
            // rtSuperpowers
            // 
            this.rtSuperpowers.Location = new System.Drawing.Point(42, 205);
            this.rtSuperpowers.Name = "rtSuperpowers";
            this.rtSuperpowers.ReadOnly = true;
            this.rtSuperpowers.Size = new System.Drawing.Size(304, 69);
            this.rtSuperpowers.TabIndex = 5;
            this.rtSuperpowers.Text = "";
            // 
            // Superheroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.lblExtLink);
            this.Controls.Add(this.picHeroPic);
            this.Controls.Add(this.groupBox1);
            this.Name = "Superheroes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picHeroPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.ComboBox cboHeroes;
        private System.Windows.Forms.PictureBox picHeroPic;
        private System.Windows.Forms.Label lblDislikes;
        private System.Windows.Forms.Label lblExtLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtBiography;
        private System.Windows.Forms.RichTextBox rtSuperpowers;
    }
}

