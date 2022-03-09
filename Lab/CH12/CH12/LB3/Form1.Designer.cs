namespace LB3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChampSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblChampion = new System.Windows.Forms.Label();
            this.lblChampType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLeftMouse = new System.Windows.Forms.Label();
            this.lblRightMouse = new System.Windows.Forms.Label();
            this.lblQAttack = new System.Windows.Forms.Label();
            this.lblFAttack = new System.Windows.Forms.Label();
            this.lblEAttack = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtChampSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(101, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paladins Wiki";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEAttack);
            this.groupBox2.Controls.Add(this.lblFAttack);
            this.groupBox2.Controls.Add(this.lblQAttack);
            this.groupBox2.Controls.Add(this.lblRightMouse);
            this.groupBox2.Controls.Add(this.lblLeftMouse);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblChampType);
            this.groupBox2.Controls.Add(this.lblChampion);
            this.groupBox2.Location = new System.Drawing.Point(29, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 317);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtChampSearch
            // 
            this.txtChampSearch.Location = new System.Drawing.Point(56, 48);
            this.txtChampSearch.Name = "txtChampSearch";
            this.txtChampSearch.Size = new System.Drawing.Size(315, 22);
            this.txtChampSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(408, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblChampion
            // 
            this.lblChampion.AutoSize = true;
            this.lblChampion.Enabled = false;
            this.lblChampion.Location = new System.Drawing.Point(24, 32);
            this.lblChampion.Name = "lblChampion";
            this.lblChampion.Size = new System.Drawing.Size(0, 16);
            this.lblChampion.TabIndex = 0;
            // 
            // lblChampType
            // 
            this.lblChampType.AutoSize = true;
            this.lblChampType.Enabled = false;
            this.lblChampType.Location = new System.Drawing.Point(24, 67);
            this.lblChampType.Name = "lblChampType";
            this.lblChampType.Size = new System.Drawing.Size(0, 16);
            this.lblChampType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Left Mouse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Right Mouse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Q:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "F:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "E:";
            // 
            // lblLeftMouse
            // 
            this.lblLeftMouse.AutoSize = true;
            this.lblLeftMouse.Enabled = false;
            this.lblLeftMouse.Location = new System.Drawing.Point(138, 122);
            this.lblLeftMouse.Name = "lblLeftMouse";
            this.lblLeftMouse.Size = new System.Drawing.Size(0, 16);
            this.lblLeftMouse.TabIndex = 7;
            // 
            // lblRightMouse
            // 
            this.lblRightMouse.AutoSize = true;
            this.lblRightMouse.Enabled = false;
            this.lblRightMouse.Location = new System.Drawing.Point(138, 155);
            this.lblRightMouse.Name = "lblRightMouse";
            this.lblRightMouse.Size = new System.Drawing.Size(0, 16);
            this.lblRightMouse.TabIndex = 8;
            // 
            // lblQAttack
            // 
            this.lblQAttack.AutoSize = true;
            this.lblQAttack.Enabled = false;
            this.lblQAttack.Location = new System.Drawing.Point(138, 206);
            this.lblQAttack.Name = "lblQAttack";
            this.lblQAttack.Size = new System.Drawing.Size(0, 16);
            this.lblQAttack.TabIndex = 9;
            // 
            // lblFAttack
            // 
            this.lblFAttack.AutoSize = true;
            this.lblFAttack.Enabled = false;
            this.lblFAttack.Location = new System.Drawing.Point(138, 242);
            this.lblFAttack.Name = "lblFAttack";
            this.lblFAttack.Size = new System.Drawing.Size(0, 16);
            this.lblFAttack.TabIndex = 10;
            // 
            // lblEAttack
            // 
            this.lblEAttack.AutoSize = true;
            this.lblEAttack.Enabled = false;
            this.lblEAttack.Location = new System.Drawing.Point(138, 279);
            this.lblEAttack.Name = "lblEAttack";
            this.lblEAttack.Size = new System.Drawing.Size(0, 16);
            this.lblEAttack.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtChampSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEAttack;
        private System.Windows.Forms.Label lblFAttack;
        private System.Windows.Forms.Label lblQAttack;
        private System.Windows.Forms.Label lblRightMouse;
        private System.Windows.Forms.Label lblLeftMouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChampType;
        private System.Windows.Forms.Label lblChampion;
    }
}

