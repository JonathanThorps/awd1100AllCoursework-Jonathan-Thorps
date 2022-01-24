namespace LAB1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.milesInput = new System.Windows.Forms.TextBox();
            this.kmInput = new System.Windows.Forms.TextBox();
            this.milesOut = new System.Windows.Forms.TextBox();
            this.kmOut = new System.Windows.Forms.TextBox();
            this.convertMiles = new System.Windows.Forms.Button();
            this.convertKm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilometers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Miles Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kilometers Output";
            // 
            // milesInput
            // 
            this.milesInput.Location = new System.Drawing.Point(68, 92);
            this.milesInput.Name = "milesInput";
            this.milesInput.Size = new System.Drawing.Size(100, 23);
            this.milesInput.TabIndex = 0;
            // 
            // kmInput
            // 
            this.kmInput.Location = new System.Drawing.Point(286, 92);
            this.kmInput.Name = "kmInput";
            this.kmInput.Size = new System.Drawing.Size(100, 23);
            this.kmInput.TabIndex = 2;
            // 
            // milesOut
            // 
            this.milesOut.Location = new System.Drawing.Point(286, 257);
            this.milesOut.Name = "milesOut";
            this.milesOut.ReadOnly = true;
            this.milesOut.Size = new System.Drawing.Size(100, 23);
            this.milesOut.TabIndex = 9;
            this.milesOut.TabStop = false;
            // 
            // kmOut
            // 
            this.kmOut.Location = new System.Drawing.Point(69, 257);
            this.kmOut.Name = "kmOut";
            this.kmOut.ReadOnly = true;
            this.kmOut.Size = new System.Drawing.Size(100, 23);
            this.kmOut.TabIndex = 10;
            this.kmOut.TabStop = false;
            // 
            // convertMiles
            // 
            this.convertMiles.Location = new System.Drawing.Point(69, 145);
            this.convertMiles.Name = "convertMiles";
            this.convertMiles.Size = new System.Drawing.Size(99, 47);
            this.convertMiles.TabIndex = 1;
            this.convertMiles.Text = "Convert Miles";
            this.convertMiles.UseVisualStyleBackColor = true;
            this.convertMiles.Click += new System.EventHandler(this.convertMiles_Click);
            // 
            // convertKm
            // 
            this.convertKm.Location = new System.Drawing.Point(286, 145);
            this.convertKm.Name = "convertKm";
            this.convertKm.Size = new System.Drawing.Size(100, 47);
            this.convertKm.TabIndex = 3;
            this.convertKm.Text = "Convert Kilometers";
            this.convertKm.UseVisualStyleBackColor = true;
            this.convertKm.Click += new System.EventHandler(this.convertKm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertKm);
            this.Controls.Add(this.convertMiles);
            this.Controls.Add(this.kmOut);
            this.Controls.Add(this.milesOut);
            this.Controls.Add(this.kmInput);
            this.Controls.Add(this.milesInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private Label label4;
        private Label label5;
        private TextBox milesInput;
        private TextBox kmInput;
        private TextBox milesOut;
        private TextBox kmOut;
        private Button convertMiles;
        private Button convertKm;
    }
}