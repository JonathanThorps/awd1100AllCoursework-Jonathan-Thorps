using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        List<Letter> letters = new List<Letter>();
        public Form1()
        {
            InitializeComponent();
            letters.Add(new Letter("Da Bank", "03MAR2018", .50m));
            letters.Add(new CertifiedLetter("Gas Company", "03MAR2018", .65m, "123456"));
            letters.Add(new Letter("Waterworks", "02MAR2018", .50m));
            letters.Add(new CertifiedLetter("Electric Company", "01MAR2018", .65m, "345678"));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string recipientName = txtRecipient.Text;
            string sendDate = txtDate.Text;
            string trackingNumber = txtTrackingNum.Text;

            if (recipientName == null && sendDate == null && trackingNumber == null)
            {

            }
            if (recipientName == null && sendDate == null && trackingNumber != null)
            {

            }
           
        }
    }
}
