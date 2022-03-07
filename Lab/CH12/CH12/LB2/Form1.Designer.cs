namespace LB2
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
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtAttendees = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtBeginDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.btnAddConf = new System.Windows.Forms.Button();
            this.btnSearchConf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConfNum = new System.Windows.Forms.Label();
            this.lblTotalAttend = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBeginDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(77, 107);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 22);
            this.txtGroupName.TabIndex = 0;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(247, 107);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 22);
            this.txtStartDate.TabIndex = 1;
            // 
            // txtAttendees
            // 
            this.txtAttendees.Location = new System.Drawing.Point(399, 107);
            this.txtAttendees.Name = "txtAttendees";
            this.txtAttendees.Size = new System.Drawing.Size(100, 22);
            this.txtAttendees.TabIndex = 2;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(559, 107);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 22);
            this.txtRoom.TabIndex = 3;
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.Location = new System.Drawing.Point(77, 282);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.Size = new System.Drawing.Size(100, 22);
            this.txtBeginDate.TabIndex = 4;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(238, 282);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 22);
            this.txtEndDate.TabIndex = 5;
            // 
            // btnAddConf
            // 
            this.btnAddConf.Location = new System.Drawing.Point(696, 107);
            this.btnAddConf.Name = "btnAddConf";
            this.btnAddConf.Size = new System.Drawing.Size(75, 23);
            this.btnAddConf.TabIndex = 6;
            this.btnAddConf.Text = "Add";
            this.btnAddConf.UseVisualStyleBackColor = true;
            this.btnAddConf.Click += new System.EventHandler(this.btnAddConf_Click);
            // 
            // btnSearchConf
            // 
            this.btnSearchConf.Location = new System.Drawing.Point(399, 282);
            this.btnSearchConf.Name = "btnSearchConf";
            this.btnSearchConf.Size = new System.Drawing.Size(75, 23);
            this.btnSearchConf.TabIndex = 7;
            this.btnSearchConf.Text = "Search";
            this.btnSearchConf.UseVisualStyleBackColor = true;
            this.btnSearchConf.Click += new System.EventHandler(this.btnSearchConf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Starting Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Attendees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Room";
            // 
            // lblConfNum
            // 
            this.lblConfNum.AutoSize = true;
            this.lblConfNum.Location = new System.Drawing.Point(244, 151);
            this.lblConfNum.Name = "lblConfNum";
            this.lblConfNum.Size = new System.Drawing.Size(0, 16);
            this.lblConfNum.TabIndex = 12;
            // 
            // lblTotalAttend
            // 
            this.lblTotalAttend.AutoSize = true;
            this.lblTotalAttend.Location = new System.Drawing.Point(244, 191);
            this.lblTotalAttend.Name = "lblTotalAttend";
            this.lblTotalAttend.Size = new System.Drawing.Size(0, 16);
            this.lblTotalAttend.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Begin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "End";
            // 
            // lblBeginDate
            // 
            this.lblBeginDate.AutoSize = true;
            this.lblBeginDate.Location = new System.Drawing.Point(74, 334);
            this.lblBeginDate.Name = "lblBeginDate";
            this.lblBeginDate.Size = new System.Drawing.Size(0, 16);
            this.lblBeginDate.TabIndex = 16;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(74, 366);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 16);
            this.lblEndDate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Conference:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Attendees:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblBeginDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalAttend);
            this.Controls.Add(this.lblConfNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchConf);
            this.Controls.Add(this.btnAddConf);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtBeginDate);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtAttendees);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtGroupName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtAttendees;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtBeginDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Button btnAddConf;
        private System.Windows.Forms.Button btnSearchConf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConfNum;
        private System.Windows.Forms.Label lblTotalAttend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBeginDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

