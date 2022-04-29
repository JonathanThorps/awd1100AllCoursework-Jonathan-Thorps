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
        string[] c = { "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,O,Q,R,S,T,U,V,W,X,Y,Z" };
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
                    plainText = plainText.Substring(i, plainText.Length + c.Length + shift);
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
                    cypherText = cypherText.Substring(i, cypherText.Length - c.Length + shift);
                }
            }
            catch (InvalidCharacterException)
            {
                lblCharError1.Visible = true;
            }
        }
    }
}
