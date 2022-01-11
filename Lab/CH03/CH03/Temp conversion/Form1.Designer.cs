namespace Temp_conversion
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
            this.txtTempF = new System.Windows.Forms.TextBox();
            this.txtTempC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertF = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTempF
            // 
            this.txtTempF.AcceptsTab = true;
            this.txtTempF.Location = new System.Drawing.Point(249, 37);
            this.txtTempF.Name = "txtTempF";
            this.txtTempF.Size = new System.Drawing.Size(100, 20);
            this.txtTempF.TabIndex = 0;
            // 
            // txtTempC
            // 
            this.txtTempC.AcceptsTab = true;
            this.txtTempC.Location = new System.Drawing.Point(249, 91);
            this.txtTempC.Name = "txtTempC";
            this.txtTempC.Size = new System.Drawing.Size(100, 20);
            this.txtTempC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Celsius";
            // 
            // btnConvertF
            // 
            this.btnConvertF.Location = new System.Drawing.Point(249, 143);
            this.btnConvertF.Name = "btnConvertF";
            this.btnConvertF.Size = new System.Drawing.Size(100, 53);
            this.btnConvertF.TabIndex = 2;
            this.btnConvertF.Text = "Convert to Celsius";
            this.btnConvertF.UseVisualStyleBackColor = true;
            this.btnConvertF.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(403, 143);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(99, 52);
            this.btnCelsius.TabIndex = 3;
            this.btnCelsius.Text = "Convert to Fahrenheit";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnConvertF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempC);
            this.Controls.Add(this.txtTempF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempF;
        private System.Windows.Forms.TextBox txtTempC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConvertF;
        private System.Windows.Forms.Button btnCelsius;
    }
}

