namespace LAB2
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
            this.clare = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Label();
            this.belle = new System.Windows.Forms.Label();
            this.annie = new System.Windows.Forms.Label();
            this.clareNumEggs = new System.Windows.Forms.TextBox();
            this.redNumEggs = new System.Windows.Forms.TextBox();
            this.belleNumEggs = new System.Windows.Forms.TextBox();
            this.annieNumEggs = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.dozenOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clare
            // 
            this.clare.AutoSize = true;
            this.clare.Location = new System.Drawing.Point(180, 51);
            this.clare.Name = "clare";
            this.clare.Size = new System.Drawing.Size(34, 15);
            this.clare.TabIndex = 0;
            this.clare.Text = "Clare";
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(180, 100);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(27, 15);
            this.red.TabIndex = 1;
            this.red.Text = "Red";
            // 
            // belle
            // 
            this.belle.AutoSize = true;
            this.belle.Location = new System.Drawing.Point(180, 147);
            this.belle.Name = "belle";
            this.belle.Size = new System.Drawing.Size(32, 15);
            this.belle.TabIndex = 2;
            this.belle.Text = "Belle";
            // 
            // annie
            // 
            this.annie.AutoSize = true;
            this.annie.Location = new System.Drawing.Point(182, 191);
            this.annie.Name = "annie";
            this.annie.Size = new System.Drawing.Size(38, 15);
            this.annie.TabIndex = 3;
            this.annie.Text = "Annie";
            // 
            // clareNumEggs
            // 
            this.clareNumEggs.Location = new System.Drawing.Point(273, 48);
            this.clareNumEggs.Name = "clareNumEggs";
            this.clareNumEggs.Size = new System.Drawing.Size(100, 23);
            this.clareNumEggs.TabIndex = 0;
            // 
            // redNumEggs
            // 
            this.redNumEggs.Location = new System.Drawing.Point(273, 98);
            this.redNumEggs.Name = "redNumEggs";
            this.redNumEggs.Size = new System.Drawing.Size(100, 23);
            this.redNumEggs.TabIndex = 1;
            // 
            // belleNumEggs
            // 
            this.belleNumEggs.Location = new System.Drawing.Point(273, 144);
            this.belleNumEggs.Name = "belleNumEggs";
            this.belleNumEggs.Size = new System.Drawing.Size(100, 23);
            this.belleNumEggs.TabIndex = 2;
            // 
            // annieNumEggs
            // 
            this.annieNumEggs.Location = new System.Drawing.Point(273, 188);
            this.annieNumEggs.Name = "annieNumEggs";
            this.annieNumEggs.Size = new System.Drawing.Size(100, 23);
            this.annieNumEggs.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(273, 246);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 44);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(558, 45);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 23);
            this.totalBox.TabIndex = 5;
            this.totalBox.TabStop = false;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(453, 48);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(32, 15);
            this.totalLbl.TabIndex = 6;
            this.totalLbl.Text = "Total";
            // 
            // dozenOutput
            // 
            this.dozenOutput.AutoSize = true;
            this.dozenOutput.Location = new System.Drawing.Point(457, 107);
            this.dozenOutput.Name = "dozenOutput";
            this.dozenOutput.Size = new System.Drawing.Size(0, 15);
            this.dozenOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dozenOutput);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.annieNumEggs);
            this.Controls.Add(this.belleNumEggs);
            this.Controls.Add(this.redNumEggs);
            this.Controls.Add(this.clareNumEggs);
            this.Controls.Add(this.annie);
            this.Controls.Add(this.belle);
            this.Controls.Add(this.red);
            this.Controls.Add(this.clare);
            this.Name = "Form1";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clare;
        private Label red;
        private Label belle;
        private Label annie;
        private TextBox clareNumEggs;
        private TextBox redNumEggs;
        private TextBox belleNumEggs;
        private TextBox annieNumEggs;
        private Button btnCalculate;
        private TextBox totalBox;
        private Label totalLbl;
        private Label dozenOutput;
    }
}