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
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOccassion = new System.Windows.Forms.ComboBox();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.cbEnvelope = new System.Windows.Forms.CheckBox();
            this.cbStamp = new System.Windows.Forms.CheckBox();
            this.cbCustomMessage = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCardImage
            // 
            this.pbCardImage.Location = new System.Drawing.Point(347, 34);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(476, 340);
            this.pbCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardImage.TabIndex = 0;
            this.pbCardImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Occassion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Style:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost:";
            // 
            // cboOccassion
            // 
            this.cboOccassion.FormattingEnabled = true;
            this.cboOccassion.Location = new System.Drawing.Point(145, 34);
            this.cboOccassion.Name = "cboOccassion";
            this.cboOccassion.Size = new System.Drawing.Size(146, 24);
            this.cboOccassion.TabIndex = 5;
            this.cboOccassion.SelectedIndexChanged += new System.EventHandler(this.cboOccassion_SelectedIndexChanged);
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(145, 82);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(146, 24);
            this.cboStyle.TabIndex = 6;
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.cboStyle_SelectedIndexChanged);
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(38, 212);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(266, 162);
            this.txtMessageBox.TabIndex = 7;
            this.txtMessageBox.Visible = false;
            this.txtMessageBox.TextChanged += new System.EventHandler(this.txtMessageBox_TextChanged);
            // 
            // cbEnvelope
            // 
            this.cbEnvelope.AutoSize = true;
            this.cbEnvelope.Location = new System.Drawing.Point(38, 128);
            this.cbEnvelope.Name = "cbEnvelope";
            this.cbEnvelope.Size = new System.Drawing.Size(129, 20);
            this.cbEnvelope.TabIndex = 8;
            this.cbEnvelope.Text = "Envelope ($0.25)";
            this.cbEnvelope.UseVisualStyleBackColor = true;
            this.cbEnvelope.CheckedChanged += new System.EventHandler(this.cbEnvelope_CheckedChanged);
            this.cbEnvelope.Enter += new System.EventHandler(this.changeColor);
            // 
            // cbStamp
            // 
            this.cbStamp.AutoSize = true;
            this.cbStamp.Location = new System.Drawing.Point(38, 154);
            this.cbStamp.Name = "cbStamp";
            this.cbStamp.Size = new System.Drawing.Size(110, 20);
            this.cbStamp.TabIndex = 9;
            this.cbStamp.Text = "Stamp ($0.50)";
            this.cbStamp.UseVisualStyleBackColor = true;
            this.cbStamp.CheckedChanged += new System.EventHandler(this.cbStamp_CheckedChanged);
            this.cbStamp.Enter += new System.EventHandler(this.changeColor);
            // 
            // cbCustomMessage
            // 
            this.cbCustomMessage.AutoSize = true;
            this.cbCustomMessage.Location = new System.Drawing.Point(38, 180);
            this.cbCustomMessage.Name = "cbCustomMessage";
            this.cbCustomMessage.Size = new System.Drawing.Size(176, 20);
            this.cbCustomMessage.TabIndex = 10;
            this.cbCustomMessage.Text = "Custom Message ($0.30)";
            this.cbCustomMessage.UseVisualStyleBackColor = true;
            this.cbCustomMessage.CheckedChanged += new System.EventHandler(this.cbCustomMessage_CheckedChanged);
            this.cbCustomMessage.Enter += new System.EventHandler(this.changeColor);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(108, 416);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 11;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(429, 184);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 471);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbCustomMessage);
            this.Controls.Add(this.cbStamp);
            this.Controls.Add(this.cbEnvelope);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.cboOccassion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCardImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCardImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOccassion;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.CheckBox cbEnvelope;
        private System.Windows.Forms.CheckBox cbStamp;
        private System.Windows.Forms.CheckBox cbCustomMessage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMessage;
    }
}

