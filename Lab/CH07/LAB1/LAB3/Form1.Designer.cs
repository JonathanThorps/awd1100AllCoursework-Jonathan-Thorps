namespace LAB3
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
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtCypher = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharError = new System.Windows.Forms.Label();
            this.lblCharError1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCharError1);
            this.groupBox1.Controls.Add(this.lblCharError);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtShift);
            this.groupBox1.Controls.Add(this.btnDecode);
            this.groupBox1.Controls.Add(this.btnEncode);
            this.groupBox1.Controls.Add(this.txtCypher);
            this.groupBox1.Controls.Add(this.txtPlain);
            this.groupBox1.Location = new System.Drawing.Point(27, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(25, 67);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(490, 22);
            this.txtPlain.TabIndex = 0;
            // 
            // txtCypher
            // 
            this.txtCypher.Location = new System.Drawing.Point(25, 217);
            this.txtCypher.Name = "txtCypher";
            this.txtCypher.Size = new System.Drawing.Size(490, 22);
            this.txtCypher.TabIndex = 1;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(531, 59);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(94, 38);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(531, 209);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(94, 38);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(605, 146);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(100, 22);
            this.txtShift.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shift";
            // 
            // lblCharError
            // 
            this.lblCharError.AutoSize = true;
            this.lblCharError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharError.ForeColor = System.Drawing.Color.Red;
            this.lblCharError.Location = new System.Drawing.Point(25, 114);
            this.lblCharError.Name = "lblCharError";
            this.lblCharError.Size = new System.Drawing.Size(220, 16);
            this.lblCharError.TabIndex = 6;
            this.lblCharError.Text = "Invalid Characters In Message!";
            this.lblCharError.Visible = false;
            // 
            // lblCharError1
            // 
            this.lblCharError1.AutoSize = true;
            this.lblCharError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharError1.ForeColor = System.Drawing.Color.Red;
            this.lblCharError1.Location = new System.Drawing.Point(25, 262);
            this.lblCharError1.Name = "lblCharError1";
            this.lblCharError1.Size = new System.Drawing.Size(220, 16);
            this.lblCharError1.TabIndex = 7;
            this.lblCharError1.Text = "Invalid Characters In Message!";
            this.lblCharError1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtCypher;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Label lblCharError1;
        private System.Windows.Forms.Label lblCharError;
    }
}

