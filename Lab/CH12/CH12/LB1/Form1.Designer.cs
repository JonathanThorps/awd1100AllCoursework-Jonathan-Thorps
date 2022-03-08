namespace LB1
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDrinkError = new System.Windows.Forms.Label();
            this.lblSundaeError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkChocoSyrup = new System.Windows.Forms.CheckBox();
            this.grpMixins = new System.Windows.Forms.GroupBox();
            this.chkLime = new System.Windows.Forms.CheckBox();
            this.chkPeach = new System.Windows.Forms.CheckBox();
            this.chkMango = new System.Windows.Forms.CheckBox();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpMixins.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblDrinkError);
            this.groupBox1.Controls.Add(this.lblSundaeError);
            this.groupBox1.Controls.Add(this.lblNameError);
            this.groupBox1.Controls.Add(this.chkSoda);
            this.groupBox1.Controls.Add(this.chkSundae);
            this.groupBox1.Controls.Add(this.txtNameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.grpToppings);
            this.groupBox1.Controls.Add(this.grpMixins);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 492);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total";
            this.label6.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(661, 436);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(661, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Order";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtOutput);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(456, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 274);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblDrinkError
            // 
            this.lblDrinkError.AutoSize = true;
            this.lblDrinkError.Enabled = false;
            this.lblDrinkError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkError.ForeColor = System.Drawing.Color.Red;
            this.lblDrinkError.Location = new System.Drawing.Point(250, 400);
            this.lblDrinkError.Name = "lblDrinkError";
            this.lblDrinkError.Size = new System.Drawing.Size(147, 16);
            this.lblDrinkError.TabIndex = 17;
            this.lblDrinkError.Text = "Only 1 Mixin allowed";
            this.lblDrinkError.Visible = false;
            // 
            // lblSundaeError
            // 
            this.lblSundaeError.AutoSize = true;
            this.lblSundaeError.Enabled = false;
            this.lblSundaeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSundaeError.ForeColor = System.Drawing.Color.Red;
            this.lblSundaeError.Location = new System.Drawing.Point(31, 400);
            this.lblSundaeError.Name = "lblSundaeError";
            this.lblSundaeError.Size = new System.Drawing.Size(172, 16);
            this.lblSundaeError.TabIndex = 16;
            this.lblSundaeError.Text = "Only 2 toppings allowed";
            this.lblSundaeError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Enabled = false;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(48, 105);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(234, 16);
            this.lblNameError.TabIndex = 15;
            this.lblNameError.Text = "Name required/No food selected";
            this.lblNameError.Visible = false;
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Location = new System.Drawing.Point(253, 194);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(53, 20);
            this.chkSoda.TabIndex = 5;
            this.chkSoda.Text = "Yes";
            this.chkSoda.UseVisualStyleBackColor = true;
            this.chkSoda.CheckedChanged += new System.EventHandler(this.chkSoda_CheckedChanged);
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(51, 194);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(53, 20);
            this.chkSundae.TabIndex = 1;
            this.chkSundae.Text = "Yes";
            this.chkSundae.UseVisualStyleBackColor = true;
            this.chkSundae.CheckedChanged += new System.EventHandler(this.chkSundae_CheckedChanged);
            // 
            // txtNameBox
            // 
            this.txtNameBox.Location = new System.Drawing.Point(51, 65);
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.Size = new System.Drawing.Size(324, 22);
            this.txtNameBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(250, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do you want a soda?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(48, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do you want a sundae?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "What name do you want for your order?";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(34, 436);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(139, 38);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Item to Order";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkSprinkles);
            this.grpToppings.Controls.Add(this.chkNuts);
            this.grpToppings.Controls.Add(this.chkChocoSyrup);
            this.grpToppings.Location = new System.Drawing.Point(34, 240);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(169, 157);
            this.grpToppings.TabIndex = 21;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Sundae Toppings";
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Location = new System.Drawing.Point(17, 41);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(85, 20);
            this.chkSprinkles.TabIndex = 2;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(17, 80);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(56, 20);
            this.chkNuts.TabIndex = 3;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkChocoSyrup
            // 
            this.chkChocoSyrup.AutoSize = true;
            this.chkChocoSyrup.Location = new System.Drawing.Point(17, 119);
            this.chkChocoSyrup.Name = "chkChocoSyrup";
            this.chkChocoSyrup.Size = new System.Drawing.Size(126, 20);
            this.chkChocoSyrup.TabIndex = 4;
            this.chkChocoSyrup.Text = "Chocolate syrup";
            this.chkChocoSyrup.UseVisualStyleBackColor = true;
            // 
            // grpMixins
            // 
            this.grpMixins.Controls.Add(this.chkLime);
            this.grpMixins.Controls.Add(this.chkPeach);
            this.grpMixins.Controls.Add(this.chkMango);
            this.grpMixins.Location = new System.Drawing.Point(253, 240);
            this.grpMixins.Name = "grpMixins";
            this.grpMixins.Size = new System.Drawing.Size(151, 157);
            this.grpMixins.TabIndex = 22;
            this.grpMixins.TabStop = false;
            this.grpMixins.Text = "Soda Mixins";
            this.grpMixins.Visible = false;
            // 
            // chkLime
            // 
            this.chkLime.AutoSize = true;
            this.chkLime.Location = new System.Drawing.Point(16, 41);
            this.chkLime.Name = "chkLime";
            this.chkLime.Size = new System.Drawing.Size(94, 20);
            this.chkLime.TabIndex = 6;
            this.chkLime.Text = "Lime flavor";
            this.chkLime.UseVisualStyleBackColor = true;
            // 
            // chkPeach
            // 
            this.chkPeach.AutoSize = true;
            this.chkPeach.Location = new System.Drawing.Point(16, 80);
            this.chkPeach.Name = "chkPeach";
            this.chkPeach.Size = new System.Drawing.Size(104, 20);
            this.chkPeach.TabIndex = 7;
            this.chkPeach.Text = "Peach flavor";
            this.chkPeach.UseVisualStyleBackColor = true;
            // 
            // chkMango
            // 
            this.chkMango.AutoSize = true;
            this.chkMango.Location = new System.Drawing.Point(16, 119);
            this.chkMango.Name = "chkMango";
            this.chkMango.Size = new System.Drawing.Size(107, 20);
            this.chkMango.TabIndex = 8;
            this.chkMango.Text = "Mango flavor";
            this.chkMango.UseVisualStyleBackColor = true;
            // 
            // rtOutput
            // 
            this.rtOutput.Location = new System.Drawing.Point(25, 21);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.Size = new System.Drawing.Size(254, 233);
            this.rtOutput.TabIndex = 0;
            this.rtOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpMixins.ResumeLayout(false);
            this.grpMixins.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDrinkError;
        private System.Windows.Forms.Label lblSundaeError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.CheckBox chkMango;
        private System.Windows.Forms.CheckBox chkPeach;
        private System.Windows.Forms.CheckBox chkLime;
        private System.Windows.Forms.CheckBox chkChocoSyrup;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.TextBox txtNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox grpMixins;
        private System.Windows.Forms.RichTextBox rtOutput;
    }
}

