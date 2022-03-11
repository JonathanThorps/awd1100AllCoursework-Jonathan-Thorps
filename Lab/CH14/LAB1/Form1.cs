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
            letters.Add(new Letter("Da Bank", new DateTime(2018, 3, 3)));
            letters.Add(new CertifiedLetter("Gas Company", new DateTime(2020, 3, 19), "42342342342"));
            letters.Add(new Letter("Waterworks", new DateTime(2018, 3, 3)));
            letters.Add(new CertifiedLetter("Electric Company", new DateTime(2018, 3, 2), "345678"));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string recipientName = txtRecipient.Text;
            string sendDate = txtDate.Text;
            string trackingNumber = txtTrackingNum.Text;
            double letterPrice = .50;
            double certLetterFee = .15;
            double price = 0;

            if (recipientName == null && sendDate == null && trackingNumber == null)
            {
                lblSendError.Visible = true;
            }
            else 
            {
                    if (!String.IsNullOrEmpty(trackingNumber))
                    {
                    letters.Add(new CertifiedLetter(recipientName, Convert.ToDateTime(sendDate), trackingNumber));
                    price = letterPrice + certLetterFee;
                     lblSendError.Visible = false;
                    }
                    else
                    {
                    letters.Add(new Letter(recipientName, Convert.ToDateTime(sendDate)));
                    price = letterPrice;
                    }

                for (int i = 0; i < letters.Count; i++)
                {
                    rtResult.Text = letters[i].ToString() + price;
                    lblSendError.Visible = false;
                    }
                
            }
           
        }
    }
}
