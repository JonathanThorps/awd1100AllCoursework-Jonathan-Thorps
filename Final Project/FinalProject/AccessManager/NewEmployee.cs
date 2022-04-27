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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
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
                cbPersonnel.Checked=true;
                cbSecureConf.Checked=true;
                cbWeldShop.Checked=true;
                cbMachine.Checked=true;
                cbArmory.Checked=true;
                cbComms.Checked=true;
                cbControl.Checked=true;
                cbConfRm.Checked=true;
                cbIntel.Checked=true;
            }
        }
        private void rbCombat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCombat.Checked)
            {
                gbCombat.Visible = true;

                if(rbWeapons.Checked)
                {
                    cbArmory.Checked=true;
                    cbConfRm.Checked=true;
                    cbSecureConf.Checked=true;
                    cbStorage.Checked=true;
                }
                if(rbEtShop.Checked)
                {
                    cbSecureConf.Checked = true;
                    cbConfRm.Checked = true;
                    cbComms.Checked = true;
                    cbControl.Checked = true;
                    cbElexShop.Checked = true;
                    cbStorage.Checked = true;
                    cbHangar.Checked = true;
                    cbVehicles.Checked = true;
                }
                if(rbItShop.Checked)
                {
                    cbPersonnel.Checked = true;
                    cbServerRm.Checked = true;
                    cbElexShop.Checked = true;
                    cbAccounting.Checked = true;
                    cbNetwork.Checked = true;
                    cbMachine.Checked = true;
                    cbArmory.Checked = true;
                    cbIntel.Checked = true;
                    cbComms.Checked = true;
                    cbCarpentry.Checked = true;
                    cbConfRm.Checked = true;
                    cbControl.Checked = true;
                    cbSecureConf.Checked = true;
                    cbPrintShop.Checked=true;

                    cbAll.Checked = true;

                    if (cbAll.Checked)
                    {
                        cbBarracks.Checked = true;
                        cbDayCare.Checked = true;
                        cbGarage.Checked = true;
                        cbGym.Checked = true;
                        cbHobbyShop.Checked = true;
                        cbLoading.Checked = true;
                        cbMainGate.Checked = true;
                        cbPrintShop.Checked = true;
                        cbMainEnt.Checked = true;
                        cbSideGate.Checked = true;
                        cbSideEnt.Checked = true;
                        cbTraining.Checked = true;
                        cbVehicles.Checked = true;
                    }
                }
            }
        }
        private void rbEngineering_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEngineering.Checked)
            {
                gbEngine.Visible = true;

                if(rbAux.Checked)
                {
                    cbConfRm.Checked=true;
                    cbElectrical.Checked=true;
                    cbHobbyShop.Checked=true;
                    cbHvac.Checked=true;
                    cbMachine.Checked=true;
                    cbStorage.Checked=true;
                    cbVehicles.Checked=true;
                }
                if(rbCarpentry.Checked)
                {
                    cbConfRm.Checked=true;
                    cbCarpentry.Checked=true;
                    cbHobbyShop.Checked=true;
                    cbStorage.Checked=true;
                }
                if(rbEngineShop.Checked)
                {
                    cbConfRm.Checked=true;
                    cbHobbyShop.Checked=true;
                    cbMachine.Checked=true;
                    cbStorage.Checked=true;
                }
                if(rbWelding.Checked)
                {
                    cbConfRm.Checked=true;
                    cbHangar.Checked=true;
                    cbMachine.Checked=true;
                    cbStorage.Checked=true;
                    cbVehicles.Checked=true;
                }
            }
        }
        private void rbOps_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOps.Checked)
            {
                gbOps.Visible = true;

                if(rbComms.Checked)
                {
                    cbComms.Checked=true;
                    cbConfRm.Checked = true;
                    cbControl.Checked=true;
                    cbRecords.Checked=true;
                    cbSecureConf.Checked = true;
                }
                if(rbIntel.Checked)
                {
                    cbConfRm.Checked=true;
                    cbSecureConf.Checked=true;
                    cbIntel.Checked=true;
                    cbComms.Checked=true;
                }
                if(rbPlanning.Checked)
                {
                    cbComms.Checked=true;
                    cbConfRm.Checked = true;
                    cbSecureConf.Checked = true;
                }
            }
        }
        private void rbSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSecurity.Checked)
            {
                cbArmory.Checked=true;
                cbVehicles.Checked=true;
                cbAll.Checked=true;

                if (cbAll.Checked)
                {
                    cbBarracks.Checked=true;
                    cbDayCare.Checked=true;
                    cbGarage.Checked=true;
                    cbGym.Checked=true;
                    cbHobbyShop.Checked=true;
                    cbLoading.Checked=true;
                    cbMainGate.Checked=true;
                    cbPrintShop.Checked=true;
                    cbMainEnt.Checked=true;
                    cbSideGate.Checked=true;
                    cbSideEnt.Checked= true;
                    cbTraining.Checked=true;
                    cbVehicles.Checked=true;
                }
            }
        }
        private void rbSupport_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSupport.Checked)
            {
                gbSupport.Visible = true;

                if(rbAdmin.Checked)
                {
                    cbConfRm.Checked=true;
                    cbPersonnel.Checked=true;
                    cbPrintShop.Checked=true;
                    cbRecords.Checked=true;
                }
                if(rbFoodService.Checked)
                {
                    cbAccounting.Checked=true;
                    cbRecords.Checked=true;
                    cbConfRm.Checked=true;
                    cbPrintShop.Checked=true;
                }
                if(rbMedical.Checked)
                {
                    cbRecords.Checked=true;
                    cbSickBay.Checked=true;
                }
                if(rbSupply.Checked)
                {
                    cbConfRm.Checked=true;
                    cbPrintShop.Checked=true;
                    cbRecords.Checked=true;
                    cbLoading.Checked=true;
                    cbAccounting.Checked=true;
                    cbStorage.Checked=true;
                }
            }
        }
        private void rbTraining_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTraining.Checked)
            {
                cbTraining.Checked = true;
                cbConfRm.Checked = true;
                cbPrintShop.Checked = true;
                cbStorage.Checked = true;
            }
        }
    }
}
