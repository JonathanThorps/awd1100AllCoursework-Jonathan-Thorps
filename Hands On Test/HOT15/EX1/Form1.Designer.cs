namespace EX1
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
            this.lblLoanError = new System.Windows.Forms.Label();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbLongTerm = new System.Windows.Forms.RadioButton();
            this.rbShortTerm = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBalInterest = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblLoanType = new System.Windows.Forms.Label();
            this.lblLoanBalance = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLoanError);
            this.groupBox1.Controls.Add(this.txtLoanAmt);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.rbLongTerm);
            this.groupBox1.Controls.Add(this.rbShortTerm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateLoan);
            this.groupBox1.Location = new System.Drawing.Point(124, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Loan";
            // 
            // lblLoanError
            // 
            this.lblLoanError.AutoSize = true;
            this.lblLoanError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanError.ForeColor = System.Drawing.Color.Red;
            this.lblLoanError.Location = new System.Drawing.Point(177, 212);
            this.lblLoanError.Name = "lblLoanError";
            this.lblLoanError.Size = new System.Drawing.Size(266, 16);
            this.lblLoanError.TabIndex = 8;
            this.lblLoanError.Text = "**Please Enter a Valid Loan Amount**";
            this.lblLoanError.Visible = false;
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Location = new System.Drawing.Point(125, 75);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(261, 22);
            this.txtLoanAmt.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 22);
            this.txtName.TabIndex = 6;
            // 
            // rbLongTerm
            // 
            this.rbLongTerm.AutoSize = true;
            this.rbLongTerm.Location = new System.Drawing.Point(125, 160);
            this.rbLongTerm.Name = "rbLongTerm";
            this.rbLongTerm.Size = new System.Drawing.Size(120, 20);
            this.rbLongTerm.TabIndex = 5;
            this.rbLongTerm.TabStop = true;
            this.rbLongTerm.Text = "Long term Loan";
            this.rbLongTerm.UseVisualStyleBackColor = true;
            this.rbLongTerm.CheckedChanged += new System.EventHandler(this.rbLongTerm_CheckedChanged);
            // 
            // rbShortTerm
            // 
            this.rbShortTerm.AutoSize = true;
            this.rbShortTerm.Location = new System.Drawing.Point(125, 125);
            this.rbShortTerm.Name = "rbShortTerm";
            this.rbShortTerm.Size = new System.Drawing.Size(121, 20);
            this.rbShortTerm.TabIndex = 4;
            this.rbShortTerm.TabStop = true;
            this.rbShortTerm.Text = "Short term Loan";
            this.rbShortTerm.UseVisualStyleBackColor = true;
            this.rbShortTerm.CheckedChanged += new System.EventHandler(this.rbShortTerm_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(36, 201);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(95, 38);
            this.btnCreateLoan.TabIndex = 0;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBalInterest);
            this.groupBox2.Controls.Add(this.lblBusinessName);
            this.groupBox2.Controls.Add(this.lblLoanType);
            this.groupBox2.Controls.Add(this.lblLoanBalance);
            this.groupBox2.Controls.Add(this.btnMakePayment);
            this.groupBox2.Location = new System.Drawing.Point(124, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Loan";
            // 
            // lblBalInterest
            // 
            this.lblBalInterest.AutoSize = true;
            this.lblBalInterest.Location = new System.Drawing.Point(33, 199);
            this.lblBalInterest.Name = "lblBalInterest";
            this.lblBalInterest.Size = new System.Drawing.Size(0, 16);
            this.lblBalInterest.TabIndex = 2;
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Location = new System.Drawing.Point(33, 39);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(0, 16);
            this.lblBusinessName.TabIndex = 4;
            // 
            // lblLoanType
            // 
            this.lblLoanType.AutoSize = true;
            this.lblLoanType.Location = new System.Drawing.Point(33, 73);
            this.lblLoanType.Name = "lblLoanType";
            this.lblLoanType.Size = new System.Drawing.Size(0, 16);
            this.lblLoanType.TabIndex = 5;
            // 
            // lblLoanBalance
            // 
            this.lblLoanBalance.AutoSize = true;
            this.lblLoanBalance.Location = new System.Drawing.Point(33, 162);
            this.lblLoanBalance.Name = "lblLoanBalance";
            this.lblLoanBalance.Size = new System.Drawing.Size(0, 16);
            this.lblLoanBalance.TabIndex = 6;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(36, 109);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(106, 38);
            this.btnMakePayment.TabIndex = 1;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBox2);
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
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbLongTerm;
        private System.Windows.Forms.RadioButton rbShortTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBalInterest;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblLoanType;
        private System.Windows.Forms.Label lblLoanBalance;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblLoanError;
    }
}

