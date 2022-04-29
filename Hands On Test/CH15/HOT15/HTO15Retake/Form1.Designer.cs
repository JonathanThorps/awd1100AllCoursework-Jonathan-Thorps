namespace HTO15Retake
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
            this.btnMakeLoan = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rbShortTerm = new System.Windows.Forms.RadioButton();
            this.rbLongTerm = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblPrinciple = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblLoan);
            this.groupBox1.Controls.Add(this.lblPrinciple);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.btnPayment);
            this.groupBox1.Location = new System.Drawing.Point(129, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Loan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblError);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbLongTerm);
            this.groupBox2.Controls.Add(this.rbShortTerm);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnMakeLoan);
            this.groupBox2.Location = new System.Drawing.Point(129, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Loan";
            // 
            // btnMakeLoan
            // 
            this.btnMakeLoan.Location = new System.Drawing.Point(21, 180);
            this.btnMakeLoan.Name = "btnMakeLoan";
            this.btnMakeLoan.Size = new System.Drawing.Size(100, 45);
            this.btnMakeLoan.TabIndex = 0;
            this.btnMakeLoan.Text = "Make Loan";
            this.btnMakeLoan.UseVisualStyleBackColor = true;
            this.btnMakeLoan.Click += new System.EventHandler(this.btnMakeLoan_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(21, 106);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(100, 45);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(95, 81);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(236, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // rbShortTerm
            // 
            this.rbShortTerm.AutoSize = true;
            this.rbShortTerm.Location = new System.Drawing.Point(119, 126);
            this.rbShortTerm.Name = "rbShortTerm";
            this.rbShortTerm.Size = new System.Drawing.Size(122, 20);
            this.rbShortTerm.TabIndex = 3;
            this.rbShortTerm.TabStop = true;
            this.rbShortTerm.Text = "Short-term Loan";
            this.rbShortTerm.UseVisualStyleBackColor = true;
            // 
            // rbLongTerm
            // 
            this.rbLongTerm.AutoSize = true;
            this.rbLongTerm.Location = new System.Drawing.Point(269, 126);
            this.rbLongTerm.Name = "rbLongTerm";
            this.rbLongTerm.Size = new System.Drawing.Size(121, 20);
            this.rbLongTerm.TabIndex = 4;
            this.rbLongTerm.TabStop = true;
            this.rbLongTerm.Text = "Long-term Loan";
            this.rbLongTerm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loan Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(18, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 8;
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(18, 77);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(0, 16);
            this.lblLoan.TabIndex = 9;
            // 
            // lblPrinciple
            // 
            this.lblPrinciple.AutoSize = true;
            this.lblPrinciple.Location = new System.Drawing.Point(21, 165);
            this.lblPrinciple.Name = "lblPrinciple";
            this.lblPrinciple.Size = new System.Drawing.Size(0, 16);
            this.lblPrinciple.TabIndex = 10;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(21, 201);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 16);
            this.lblBalance.TabIndex = 11;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(185, 191);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(256, 20);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Please Enter a Valid Amount!";
            this.lblError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblPrinciple;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLongTerm;
        private System.Windows.Forms.RadioButton rbShortTerm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnMakeLoan;
        private System.Windows.Forms.Label lblError;
    }
}

