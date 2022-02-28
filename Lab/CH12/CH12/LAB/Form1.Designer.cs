namespace LAB
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(424, 58);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(99, 42);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(363, 292);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(99, 42);
            this.depositBtn.TabIndex = 1;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(363, 364);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(99, 42);
            this.withdrawBtn.TabIndex = 2;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(219, 440);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(99, 42);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblResultBalance);
            this.groupBox2.Controls.Add(this.lblResultName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtWithdraw);
            this.groupBox2.Controls.Add(this.logoutBtn);
            this.groupBox2.Controls.Add(this.txtDeposit);
            this.groupBox2.Controls.Add(this.withdrawBtn);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.depositBtn);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.loginBtn);
            this.groupBox2.Location = new System.Drawing.Point(97, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 504);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 22);
            this.textBox2.TabIndex = 1;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(120, 302);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(170, 22);
            this.txtDeposit.TabIndex = 2;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(120, 374);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(170, 22);
            this.txtWithdraw.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "PIN#";
            // 
            // lblResultName
            // 
            this.lblResultName.AutoSize = true;
            this.lblResultName.Location = new System.Drawing.Point(124, 160);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(0, 16);
            this.lblResultName.TabIndex = 6;
            // 
            // lblResultBalance
            // 
            this.lblResultBalance.AutoSize = true;
            this.lblResultBalance.Location = new System.Drawing.Point(124, 207);
            this.lblResultBalance.Name = "lblResultBalance";
            this.lblResultBalance.Size = new System.Drawing.Size(0, 16);
            this.lblResultBalance.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Would you like to make a deposit?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Would you like to make a withdrawal?";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(755, 541);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPinNum;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResultBalance;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

