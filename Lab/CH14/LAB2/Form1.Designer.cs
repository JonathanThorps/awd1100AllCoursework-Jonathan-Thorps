namespace LAB2
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
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbColors = new System.Windows.Forms.GroupBox();
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.gbStyle = new System.Windows.Forms.GroupBox();
            this.rbUnframed = new System.Windows.Forms.RadioButton();
            this.rbMatted = new System.Windows.Forms.RadioButton();
            this.rbFramed = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbPine = new System.Windows.Forms.RadioButton();
            this.rbOak = new System.Windows.Forms.RadioButton();
            this.rbSteel = new System.Windows.Forms.RadioButton();
            this.rbSilver = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbModern = new System.Windows.Forms.RadioButton();
            this.rbAntique = new System.Windows.Forms.RadioButton();
            this.rbVintage = new System.Windows.Forms.RadioButton();
            this.rbEcclectic = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOrderResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbColors.SuspendLayout();
            this.gbMaterial.SuspendLayout();
            this.gbStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOrderResult);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.lblCost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gbColors);
            this.groupBox1.Controls.Add(this.gbMaterial);
            this.groupBox1.Controls.Add(this.gbStyle);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Location = new System.Drawing.Point(95, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 542);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(101, 24);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(255, 22);
            this.txtWidth.TabIndex = 0;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(101, 61);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(255, 22);
            this.txtHeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbUnframed);
            this.groupBox2.Controls.Add(this.rbMatted);
            this.groupBox2.Controls.Add(this.rbFramed);
            this.groupBox2.Location = new System.Drawing.Point(35, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frame";
            // 
            // gbColors
            // 
            this.gbColors.Controls.Add(this.rbWhite);
            this.gbColors.Controls.Add(this.rbBlue);
            this.gbColors.Controls.Add(this.rbGreen);
            this.gbColors.Controls.Add(this.rbRed);
            this.gbColors.Controls.Add(this.rbBlack);
            this.gbColors.Location = new System.Drawing.Point(35, 225);
            this.gbColors.Name = "gbColors";
            this.gbColors.Size = new System.Drawing.Size(172, 220);
            this.gbColors.TabIndex = 5;
            this.gbColors.TabStop = false;
            this.gbColors.Text = "Color";
            this.gbColors.Visible = false;
            // 
            // gbMaterial
            // 
            this.gbMaterial.Controls.Add(this.rbPine);
            this.gbMaterial.Controls.Add(this.rbOak);
            this.gbMaterial.Controls.Add(this.rbSteel);
            this.gbMaterial.Controls.Add(this.rbSilver);
            this.gbMaterial.Controls.Add(this.rbGold);
            this.gbMaterial.Location = new System.Drawing.Point(229, 225);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Size = new System.Drawing.Size(163, 220);
            this.gbMaterial.TabIndex = 5;
            this.gbMaterial.TabStop = false;
            this.gbMaterial.Text = "Material";
            this.gbMaterial.Visible = false;
            // 
            // gbStyle
            // 
            this.gbStyle.Controls.Add(this.rbSimple);
            this.gbStyle.Controls.Add(this.rbModern);
            this.gbStyle.Controls.Add(this.rbAntique);
            this.gbStyle.Controls.Add(this.rbVintage);
            this.gbStyle.Controls.Add(this.rbEcclectic);
            this.gbStyle.Location = new System.Drawing.Point(416, 225);
            this.gbStyle.Name = "gbStyle";
            this.gbStyle.Size = new System.Drawing.Size(176, 220);
            this.gbStyle.TabIndex = 5;
            this.gbStyle.TabStop = false;
            this.gbStyle.Text = "Style";
            this.gbStyle.Visible = false;
            // 
            // rbUnframed
            // 
            this.rbUnframed.AutoSize = true;
            this.rbUnframed.Location = new System.Drawing.Point(19, 21);
            this.rbUnframed.Name = "rbUnframed";
            this.rbUnframed.Size = new System.Drawing.Size(87, 20);
            this.rbUnframed.TabIndex = 0;
            this.rbUnframed.TabStop = true;
            this.rbUnframed.Text = "Unframed";
            this.rbUnframed.UseVisualStyleBackColor = true;
            this.rbUnframed.CheckedChanged += new System.EventHandler(this.rbUnframed_CheckedChanged);
            // 
            // rbMatted
            // 
            this.rbMatted.AutoSize = true;
            this.rbMatted.Location = new System.Drawing.Point(19, 58);
            this.rbMatted.Name = "rbMatted";
            this.rbMatted.Size = new System.Drawing.Size(69, 20);
            this.rbMatted.TabIndex = 1;
            this.rbMatted.TabStop = true;
            this.rbMatted.Text = "Matted";
            this.rbMatted.UseVisualStyleBackColor = true;
            this.rbMatted.CheckedChanged += new System.EventHandler(this.rbMatted_CheckedChanged);
            // 
            // rbFramed
            // 
            this.rbFramed.AutoSize = true;
            this.rbFramed.Location = new System.Drawing.Point(19, 95);
            this.rbFramed.Name = "rbFramed";
            this.rbFramed.Size = new System.Drawing.Size(75, 20);
            this.rbFramed.TabIndex = 2;
            this.rbFramed.TabStop = true;
            this.rbFramed.Text = "Framed";
            this.rbFramed.UseVisualStyleBackColor = true;
            this.rbFramed.CheckedChanged += new System.EventHandler(this.rbFramed_CheckedChanged);
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(19, 31);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(62, 20);
            this.rbBlack.TabIndex = 3;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(19, 66);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(54, 20);
            this.rbRed.TabIndex = 4;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(19, 104);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(65, 20);
            this.rbGreen.TabIndex = 5;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(19, 142);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(55, 20);
            this.rbBlue.TabIndex = 6;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(19, 180);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(62, 20);
            this.rbWhite.TabIndex = 7;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White";
            this.rbWhite.UseVisualStyleBackColor = true;
            this.rbWhite.CheckedChanged += new System.EventHandler(this.rbWhite_CheckedChanged);
            // 
            // rbPine
            // 
            this.rbPine.AutoSize = true;
            this.rbPine.Location = new System.Drawing.Point(24, 31);
            this.rbPine.Name = "rbPine";
            this.rbPine.Size = new System.Drawing.Size(55, 20);
            this.rbPine.TabIndex = 8;
            this.rbPine.TabStop = true;
            this.rbPine.Text = "Pine";
            this.rbPine.UseVisualStyleBackColor = true;
            this.rbPine.CheckedChanged += new System.EventHandler(this.rbPine_CheckedChanged);
            // 
            // rbOak
            // 
            this.rbOak.AutoSize = true;
            this.rbOak.Location = new System.Drawing.Point(22, 66);
            this.rbOak.Name = "rbOak";
            this.rbOak.Size = new System.Drawing.Size(53, 20);
            this.rbOak.TabIndex = 9;
            this.rbOak.TabStop = true;
            this.rbOak.Text = "Oak";
            this.rbOak.UseVisualStyleBackColor = true;
            this.rbOak.CheckedChanged += new System.EventHandler(this.rbOak_CheckedChanged);
            // 
            // rbSteel
            // 
            this.rbSteel.AutoSize = true;
            this.rbSteel.Location = new System.Drawing.Point(22, 104);
            this.rbSteel.Name = "rbSteel";
            this.rbSteel.Size = new System.Drawing.Size(59, 20);
            this.rbSteel.TabIndex = 10;
            this.rbSteel.TabStop = true;
            this.rbSteel.Text = "Steel";
            this.rbSteel.UseVisualStyleBackColor = true;
            this.rbSteel.CheckedChanged += new System.EventHandler(this.rbSteel_CheckedChanged);
            // 
            // rbSilver
            // 
            this.rbSilver.AutoSize = true;
            this.rbSilver.Location = new System.Drawing.Point(22, 142);
            this.rbSilver.Name = "rbSilver";
            this.rbSilver.Size = new System.Drawing.Size(62, 20);
            this.rbSilver.TabIndex = 11;
            this.rbSilver.TabStop = true;
            this.rbSilver.Text = "Silver";
            this.rbSilver.UseVisualStyleBackColor = true;
            this.rbSilver.CheckedChanged += new System.EventHandler(this.rbSilver_CheckedChanged);
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Location = new System.Drawing.Point(22, 180);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(57, 20);
            this.rbGold.TabIndex = 12;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            this.rbGold.CheckedChanged += new System.EventHandler(this.rbGold_CheckedChanged);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(20, 31);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(70, 20);
            this.rbSimple.TabIndex = 13;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            this.rbSimple.CheckedChanged += new System.EventHandler(this.rbSimple_CheckedChanged);
            // 
            // rbModern
            // 
            this.rbModern.AutoSize = true;
            this.rbModern.Location = new System.Drawing.Point(20, 66);
            this.rbModern.Name = "rbModern";
            this.rbModern.Size = new System.Drawing.Size(74, 20);
            this.rbModern.TabIndex = 14;
            this.rbModern.TabStop = true;
            this.rbModern.Text = "Modern";
            this.rbModern.UseVisualStyleBackColor = true;
            this.rbModern.CheckedChanged += new System.EventHandler(this.rbModern_CheckedChanged);
            // 
            // rbAntique
            // 
            this.rbAntique.AutoSize = true;
            this.rbAntique.Location = new System.Drawing.Point(20, 104);
            this.rbAntique.Name = "rbAntique";
            this.rbAntique.Size = new System.Drawing.Size(73, 20);
            this.rbAntique.TabIndex = 15;
            this.rbAntique.TabStop = true;
            this.rbAntique.Text = "Antique";
            this.rbAntique.UseVisualStyleBackColor = true;
            this.rbAntique.CheckedChanged += new System.EventHandler(this.rbAntique_CheckedChanged);
            // 
            // rbVintage
            // 
            this.rbVintage.AutoSize = true;
            this.rbVintage.Location = new System.Drawing.Point(20, 142);
            this.rbVintage.Name = "rbVintage";
            this.rbVintage.Size = new System.Drawing.Size(74, 20);
            this.rbVintage.TabIndex = 16;
            this.rbVintage.TabStop = true;
            this.rbVintage.Text = "Vintage";
            this.rbVintage.UseVisualStyleBackColor = true;
            this.rbVintage.CheckedChanged += new System.EventHandler(this.rbVintage_CheckedChanged);
            // 
            // rbEcclectic
            // 
            this.rbEcclectic.AutoSize = true;
            this.rbEcclectic.Location = new System.Drawing.Point(20, 180);
            this.rbEcclectic.Name = "rbEcclectic";
            this.rbEcclectic.Size = new System.Drawing.Size(82, 20);
            this.rbEcclectic.TabIndex = 17;
            this.rbEcclectic.TabStop = true;
            this.rbEcclectic.Text = "Ecclectic";
            this.rbEcclectic.UseVisualStyleBackColor = true;
            this.rbEcclectic.CheckedChanged += new System.EventHandler(this.rbEcclectic_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(502, 479);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 16);
            this.lblCost.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(35, 461);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 41);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOrderResult
            // 
            this.lblOrderResult.AutoSize = true;
            this.lblOrderResult.Location = new System.Drawing.Point(35, 509);
            this.lblOrderResult.Name = "lblOrderResult";
            this.lblOrderResult.Size = new System.Drawing.Size(0, 16);
            this.lblOrderResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbColors.ResumeLayout(false);
            this.gbColors.PerformLayout();
            this.gbMaterial.ResumeLayout(false);
            this.gbMaterial.PerformLayout();
            this.gbStyle.ResumeLayout(false);
            this.gbStyle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOrderResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbColors;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.RadioButton rbPine;
        private System.Windows.Forms.RadioButton rbOak;
        private System.Windows.Forms.RadioButton rbSteel;
        private System.Windows.Forms.RadioButton rbSilver;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.GroupBox gbStyle;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbModern;
        private System.Windows.Forms.RadioButton rbAntique;
        private System.Windows.Forms.RadioButton rbVintage;
        private System.Windows.Forms.RadioButton rbEcclectic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbUnframed;
        private System.Windows.Forms.RadioButton rbMatted;
        private System.Windows.Forms.RadioButton rbFramed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
    }
}

