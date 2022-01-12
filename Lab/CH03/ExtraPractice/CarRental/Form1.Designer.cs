namespace CarRental
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyRate = new System.Windows.Forms.TextBox();
            this.numberOfDays = new System.Windows.Forms.TextBox();
            this.mileageRate = new System.Windows.Forms.TextBox();
            this.mileage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.invoiceTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate per Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. of Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate per Mile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. of Miles";
            // 
            // dailyRate
            // 
            this.dailyRate.Location = new System.Drawing.Point(187, 61);
            this.dailyRate.Name = "dailyRate";
            this.dailyRate.ReadOnly = true;
            this.dailyRate.Size = new System.Drawing.Size(100, 23);
            this.dailyRate.TabIndex = 0;
            this.dailyRate.Text = "20.00";
            // 
            // numberOfDays
            // 
            this.numberOfDays.Location = new System.Drawing.Point(187, 98);
            this.numberOfDays.Name = "numberOfDays";
            this.numberOfDays.Size = new System.Drawing.Size(100, 23);
            this.numberOfDays.TabIndex = 1;
            // 
            // mileageRate
            // 
            this.mileageRate.Location = new System.Drawing.Point(187, 137);
            this.mileageRate.Name = "mileageRate";
            this.mileageRate.ReadOnly = true;
            this.mileageRate.Size = new System.Drawing.Size(100, 23);
            this.mileageRate.TabIndex = 2;
            this.mileageRate.Text = "0.25";
            // 
            // mileage
            // 
            this.mileage.Location = new System.Drawing.Point(187, 173);
            this.mileage.Name = "mileage";
            this.mileage.Size = new System.Drawing.Size(100, 23);
            this.mileage.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(187, 223);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 47);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Invoice";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // invoiceTotal
            // 
            this.invoiceTotal.Location = new System.Drawing.Point(467, 61);
            this.invoiceTotal.Name = "invoiceTotal";
            this.invoiceTotal.ReadOnly = true;
            this.invoiceTotal.Size = new System.Drawing.Size(100, 23);
            this.invoiceTotal.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Invoice Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.invoiceTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.mileage);
            this.Controls.Add(this.mileageRate);
            this.Controls.Add(this.numberOfDays);
            this.Controls.Add(this.dailyRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dailyRate;
        private TextBox numberOfDays;
        private TextBox mileageRate;
        private TextBox mileage;
        private Button btnCalculate;
        private TextBox invoiceTotal;
        private Label label5;
    }
}