namespace LAB4
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
            this.zipCodeBox = new System.Windows.Forms.TextBox();
            this.zipCodeInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeliveryCharges = new System.Windows.Forms.Label();
            this.lblErrorOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorOutput);
            this.groupBox1.Controls.Add(this.lblDeliveryCharges);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zipCodeInput);
            this.groupBox1.Controls.Add(this.zipCodeBox);
            this.groupBox1.Location = new System.Drawing.Point(192, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Charges";
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Location = new System.Drawing.Point(61, 110);
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(100, 20);
            this.zipCodeBox.TabIndex = 0;
            // 
            // zipCodeInput
            // 
            this.zipCodeInput.Location = new System.Drawing.Point(202, 108);
            this.zipCodeInput.Name = "zipCodeInput";
            this.zipCodeInput.Size = new System.Drawing.Size(75, 23);
            this.zipCodeInput.TabIndex = 1;
            this.zipCodeInput.Text = "Calculate";
            this.zipCodeInput.UseVisualStyleBackColor = true;
            this.zipCodeInput.Click += new System.EventHandler(this.zipCodeInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zip Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery Charges";
            // 
            // lblDeliveryCharges
            // 
            this.lblDeliveryCharges.AutoSize = true;
            this.lblDeliveryCharges.Location = new System.Drawing.Point(304, 113);
            this.lblDeliveryCharges.Name = "lblDeliveryCharges";
            this.lblDeliveryCharges.Size = new System.Drawing.Size(0, 13);
            this.lblDeliveryCharges.TabIndex = 4;
            // 
            // lblErrorOutput
            // 
            this.lblErrorOutput.AutoSize = true;
            this.lblErrorOutput.Location = new System.Drawing.Point(61, 180);
            this.lblErrorOutput.Name = "lblErrorOutput";
            this.lblErrorOutput.Size = new System.Drawing.Size(0, 13);
            this.lblErrorOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorOutput;
        private System.Windows.Forms.Label lblDeliveryCharges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zipCodeInput;
        private System.Windows.Forms.TextBox zipCodeBox;
    }
}

