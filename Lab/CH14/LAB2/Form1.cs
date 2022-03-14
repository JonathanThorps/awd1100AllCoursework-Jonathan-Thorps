using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Form1 : Form
    {
        Colors photoColor = Colors.WHITE;
        Materials frameMaterial = Materials.OAK;
        Styles frameStyle = Styles.SIMPLE;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float photoWidth = Convert.ToInt32(txtHeight.Text);
            float photoHeight = Convert.ToInt32(txtHeight.Text);

           // lblOrderResult.Text = base.ToString();
           // lblCost.Text = Price;
           if (rbUnframed.Checked)
            {
                Photo myPhoto = new Photo(photoWidth, photoHeight);
                lblOrderResult.Text = myPhoto.ToString();
            }
           if (rbMatted.Checked)
            {
                MattedPhoto myMattedPhoto = new MattedPhoto(photoWidth, photoHeight, photoColor);
                lblOrderResult.Text = myMattedPhoto.ToString();
            }
           if (rbFramed.Checked)
            {
                FramedPhoto myFramedPhoto = new FramedPhoto(photoWidth, photoHeight, frameMaterial, frameStyle);
                lblCost.Text = myFramedPhoto.ToString();
            }
        }

        private void rbUnframed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnframed.Checked)
            {
                gbColors.Visible = false;
                gbMaterial.Visible = false;
                gbStyle.Visible = false;
                lblOrderResult.Text += ToString();
            }
        }

        private void rbMatted_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMatted.Checked)
            {
                gbColors.Visible = true;
                gbMaterial.Visible = false;
                gbStyle.Visible = false;
            }
        }

        private void rbFramed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFramed.Checked)
            {
                gbStyle.Visible = true;
                gbMaterial.Visible = true;
                gbColors.Visible = false;
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            photoColor = Colors.BLACK;
            lblOrderResult.Text += ToString();
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            photoColor = Colors.RED;
            lblOrderResult.Text += ToString();
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            photoColor = Colors.GREEN;
            lblOrderResult.Text += ToString();
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            photoColor = Colors.BLUE;
            lblOrderResult.Text += ToString();
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            photoColor = Colors.WHITE;
            lblOrderResult.Text += ToString();
        }

        private void rbPine_CheckedChanged(object sender, EventArgs e)
        {
            frameMaterial = Materials.PINE;
            lblOrderResult.Text += ToString();
        }

        private void rbOak_CheckedChanged(object sender, EventArgs e)
        {
            frameMaterial = Materials.OAK;
            lblOrderResult.Text += ToString();
        }

        private void rbSteel_CheckedChanged(object sender, EventArgs e)
        {
            frameMaterial = Materials.STEEL;
            lblOrderResult.Text += ToString();
        }

        private void rbSilver_CheckedChanged(object sender, EventArgs e)
        {
            frameMaterial = Materials.SILVER;
            lblOrderResult.Text += ToString();
        }

        private void rbGold_CheckedChanged(object sender, EventArgs e)
        {
            frameMaterial = Materials.GOLD;
            lblOrderResult.Text += ToString();
        }

        private void rbSimple_CheckedChanged(object sender, EventArgs e)
        {
            frameStyle = Styles.SIMPLE;
            lblOrderResult.Text += ToString();
        }

        private void rbModern_CheckedChanged(object sender, EventArgs e)
        {
            frameStyle = Styles.MODERN;
            lblOrderResult.Text += ToString();
        }

        private void rbAntique_CheckedChanged(object sender, EventArgs e)
        {
            frameStyle = Styles.ANTIQUE;
            lblOrderResult.Text += ToString();
        }

        private void rbVintage_CheckedChanged(object sender, EventArgs e)
        {
            frameStyle = Styles.VINTAGE;
            lblOrderResult.Text += ToString();
        }

        private void rbEcclectic_CheckedChanged(object sender, EventArgs e)
        {
            frameStyle = Styles.ECCLECTIC;
            lblOrderResult.Text += ToString();
        }
    }
}
