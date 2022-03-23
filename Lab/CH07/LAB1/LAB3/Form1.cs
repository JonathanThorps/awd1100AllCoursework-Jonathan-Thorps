using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = txtPlain.Text;
                int shift = Convert.ToInt32(txtShift.Text);

                for (int i = 0; i < plainText.Length; i++)
                {
                    plainText = plainText.Substring(i, plainText.Length - i);
                }
            }
            catch(InvalidCharacterException)
            {
                lblCharError.Visible = true;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string cypherText = txtCypher.Text;
                int shift = Convert.ToInt32(txtShift.Text);

                for (int i = 0; i < cypherText.Length; i++)
                {
                    cypherText = cypherText.Substring(i, cypherText.Length - i);
                }
            }
            catch (InvalidCharacterException)
            {
                lblCharError1.Visible = true;
            }
        }
    }
}
