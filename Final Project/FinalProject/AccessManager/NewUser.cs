using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessManager
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            cbMainEnt.Checked = true;
            cbMainGate.Checked = true;
            cbTraining.Checked = true;
            cbGarage.Checked = true;
        }
        
        private void rbAviation_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAviation.Checked)
            {
                cbHangar.Checked = true;
                cbMachine.Checked = true;
                cbSecureConf.Checked = true;
                cbControl.Checked = true;
            }
        }

        private void rbCommand_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCommand.Checked)
            {

            }
        }

        private void rbCombat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCombat.Checked)
            {
                gbCombat.Visible = true;
            }
        }

        private void rbEngineering_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEngineering.Checked)
            {
                gbEngine.Visible = true;
            }
        }

        private void rbOps_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOps.Checked)
            {
                gbOps.Visible = true;
            }
        }

        private void rbSecurity_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSupport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSupport.Checked)
            {
                gbSupport.Visible = true;
            }
        }

        private void rbTraining_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
