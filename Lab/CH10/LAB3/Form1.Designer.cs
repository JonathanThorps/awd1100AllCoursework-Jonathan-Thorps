﻿namespace LAB3
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.txtFive = new System.Windows.Forms.TextBox();
            this.txtSix = new System.Windows.Forms.TextBox();
            this.txtSeven = new System.Windows.Forms.TextBox();
            this.txtEight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(353, 52);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 22);
            this.txtOne.TabIndex = 0;
            this.txtOne.Text = "1";
            this.txtOne.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtOne.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtOne.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(520, 107);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 22);
            this.txtTwo.TabIndex = 1;
            this.txtTwo.Text = "2";
            this.txtTwo.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtTwo.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtTwo.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(662, 203);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 22);
            this.txtThree.TabIndex = 2;
            this.txtThree.Text = "3";
            this.txtThree.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtThree.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtThree.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // txtFour
            // 
            this.txtFour.Location = new System.Drawing.Point(520, 309);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(100, 22);
            this.txtFour.TabIndex = 3;
            this.txtFour.Text = "4";
            this.txtFour.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtFour.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtFour.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // txtFive
            // 
            this.txtFive.Location = new System.Drawing.Point(353, 365);
            this.txtFive.Name = "txtFive";
            this.txtFive.Size = new System.Drawing.Size(100, 22);
            this.txtFive.TabIndex = 4;
            this.txtFive.Text = "5";
            this.txtFive.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtFive.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtFive.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // txtSix
            // 
            this.txtSix.Location = new System.Drawing.Point(168, 309);
            this.txtSix.Name = "txtSix";
            this.txtSix.Size = new System.Drawing.Size(100, 22);
            this.txtSix.TabIndex = 5;
            this.txtSix.Text = "6";
            this.txtSix.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtSix.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtSix.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // txtSeven
            // 
            this.txtSeven.Location = new System.Drawing.Point(32, 203);
            this.txtSeven.Name = "txtSeven";
            this.txtSeven.Size = new System.Drawing.Size(100, 22);
            this.txtSeven.TabIndex = 6;
            this.txtSeven.Text = "7";
            this.txtSeven.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtSeven.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtSeven.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // txtEight
            // 
            this.txtEight.Location = new System.Drawing.Point(168, 107);
            this.txtEight.Name = "txtEight";
            this.txtEight.Size = new System.Drawing.Size(100, 22);
            this.txtEight.TabIndex = 7;
            this.txtEight.Text = "8";
            this.txtEight.Click += new System.EventHandler(this.AnyTextbox_Click);
            this.txtEight.Enter += new System.EventHandler(this.AnyTextbox_Focus);
            this.txtEight.Leave += new System.EventHandler(this.AnyTextbox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEight);
            this.Controls.Add(this.txtSeven);
            this.Controls.Add(this.txtSix);
            this.Controls.Add(this.txtFive);
            this.Controls.Add(this.txtFour);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Name = "Form1";
            this.Text = "Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.TextBox txtFive;
        private System.Windows.Forms.TextBox txtSix;
        private System.Windows.Forms.TextBox txtSeven;
        private System.Windows.Forms.TextBox txtEight;
    }
}

