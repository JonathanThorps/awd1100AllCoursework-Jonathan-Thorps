namespace HOT1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedCount = new System.Windows.Forms.Label();
            this.lblLrgCount = new System.Windows.Forms.Label();
            this.lblSmallCount = new System.Windows.Forms.Label();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSmallTotal = new System.Windows.Forms.Label();
            this.lblMedTotal = new System.Windows.Forms.Label();
            this.lblLrgTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnClearOrder);
            this.groupBox1.Controls.Add(this.btnLarge);
            this.groupBox1.Controls.Add(this.btnMedium);
            this.groupBox1.Controls.Add(this.btnSmall);
            this.groupBox1.Controls.Add(this.lblSmallCount);
            this.groupBox1.Controls.Add(this.lblLrgCount);
            this.groupBox1.Controls.Add(this.lblMedCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(137, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Super Custom Cool Shirts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "What size shirts do you need?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "$9.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "$10.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "$11.99";
            // 
            // lblMedCount
            // 
            this.lblMedCount.AutoSize = true;
            this.lblMedCount.Location = new System.Drawing.Point(248, 171);
            this.lblMedCount.Name = "lblMedCount";
            this.lblMedCount.Size = new System.Drawing.Size(0, 20);
            this.lblMedCount.TabIndex = 4;
            // 
            // lblLrgCount
            // 
            this.lblLrgCount.AutoSize = true;
            this.lblLrgCount.Location = new System.Drawing.Point(382, 171);
            this.lblLrgCount.Name = "lblLrgCount";
            this.lblLrgCount.Size = new System.Drawing.Size(0, 20);
            this.lblLrgCount.TabIndex = 5;
            // 
            // lblSmallCount
            // 
            this.lblSmallCount.AutoSize = true;
            this.lblSmallCount.Location = new System.Drawing.Point(97, 171);
            this.lblSmallCount.Name = "lblSmallCount";
            this.lblSmallCount.Size = new System.Drawing.Size(0, 20);
            this.lblSmallCount.TabIndex = 6;
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(63, 128);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(94, 29);
            this.btnSmall.TabIndex = 7;
            this.btnSmall.Text = "Small";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(211, 128);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(94, 29);
            this.btnMedium.TabIndex = 8;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(344, 128);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(94, 29);
            this.btnLarge.TabIndex = 9;
            this.btnLarge.Text = "Large";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(184, 479);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(94, 29);
            this.btnClearOrder.TabIndex = 10;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSubtotal);
            this.groupBox2.Controls.Add(this.lblTax);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblLrgTotal);
            this.groupBox2.Controls.Add(this.lblMedTotal);
            this.groupBox2.Controls.Add(this.lblSmallTotal);
            this.groupBox2.Location = new System.Drawing.Point(27, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 270);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblSmallTotal
            // 
            this.lblSmallTotal.AutoSize = true;
            this.lblSmallTotal.Location = new System.Drawing.Point(36, 23);
            this.lblSmallTotal.Name = "lblSmallTotal";
            this.lblSmallTotal.Size = new System.Drawing.Size(0, 20);
            this.lblSmallTotal.TabIndex = 0;
            // 
            // lblMedTotal
            // 
            this.lblMedTotal.AutoSize = true;
            this.lblMedTotal.Location = new System.Drawing.Point(36, 63);
            this.lblMedTotal.Name = "lblMedTotal";
            this.lblMedTotal.Size = new System.Drawing.Size(0, 20);
            this.lblMedTotal.TabIndex = 1;
            // 
            // lblLrgTotal
            // 
            this.lblLrgTotal.AutoSize = true;
            this.lblLrgTotal.Location = new System.Drawing.Point(28, 102);
            this.lblLrgTotal.Name = "lblLrgTotal";
            this.lblLrgTotal.Size = new System.Drawing.Size(0, 20);
            this.lblLrgTotal.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Subtotal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(157, 149);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 20);
            this.lblSubtotal.TabIndex = 4;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(157, 185);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(0, 20);
            this.lblTax.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(157, 218);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Super Custom Cool Shirts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label lblLrgTotal;
        private Label lblMedTotal;
        private Label lblSmallTotal;
        private Button btnClearOrder;
        private Button btnLarge;
        private Button btnMedium;
        private Button btnSmall;
        private Label lblSmallCount;
        private Label lblLrgCount;
        private Label lblMedCount;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}