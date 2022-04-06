using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboOccassion.Items.AddRange(GetOccassion());
            cboOccassion.SelectedIndex = 0;
        }
            public string[] GetOccassion()
            {
                return new string[]
                {
                    "Please select an occassion",
                    "Birthday",
                    "Graduation",
                    "Wedding"
                };
            }
        public string[] GetStyles(string occassion)
        {
            switch (occassion)
            {
                default:
                    return new string[]
                    {
                            "Please select a style"
                    };
                case "Birthday":
                    return new string[]
                    {
                            new Style{Name="Boy", Price=1.25m, Image=Properties.Resources.birthday_border_boy},
                            new Style{Name="Girl", Price=2.50m, Image=Properties.Resources.birthday_border_girl}
                        };
                case "Graduation":
                    return new string[]
                    {
                            new Style{Name="Certificate", Price=2m, Image=Properties.Resources.graduation_certificate_border },
                            new Style{Name="Gold", Price=3m, Image=Properties.Resources.graduation_gold_border }
                        };
                case "Wedding":
                    return new string[]
                    {
                            new Style{Name="Simple", Price=2.50m, Image=Properties.Resources.wedding_invitation_border },
                            new Style{Name="Fancy", Price=3m, Image=Properties.Resources.wedding_invitation_top_bottom_border }
                    };
            }
        }

        decimal total = 0;
        private void cboOccassion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStyle.Items.Clear();
            cboOccassion.Items.AddRange(GetOccassion());
            cboOccassion.SelectedIndex = 0;
        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string occassion = cboOccassion.SelectedItem.ToString();
            cboStyle.Items.AddRange(GetStyles(occassion));
            cboStyle.SelectedIndex = 0;
        }
        private void cbEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            decimal envelope = 0.25m;
            if (cbEnvelope.Checked)
            {
                total += envelope;
                lblTotal.Text += total;
            }
        }

        private void cbStamp_CheckedChanged(object sender, EventArgs e)
        {
            decimal stamp = 0.50m;
            if (cbEnvelope.Checked)
            {
                total += stamp;
                lblTotal.Text += total;
            }
        }
        private void cbCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            decimal message = 0.30m;
            if (cbCustomMessage.Checked)
            {
                txtMessageBox.Visible = true;
                total += message;
                lblTotal.Text += total;
            }
        }

        private void txtMessageBox_TextChanged(object sender, EventArgs e)
        {
            string userMessage = txtMessageBox.Text;
            if (userMessage == txtMessageBox.Text)
            {
                lblMessage.Text = txtMessageBox.Text;
            }
        }
        private void changeColor(object sender, EventArgs e)
        {
            cbEnvelope.BackColor = Color.LightGreen;
            cbStamp.BackColor = Color.LightGreen;
            cbCustomMessage.BackColor = Color.LightGreen;
        }
    }
}
