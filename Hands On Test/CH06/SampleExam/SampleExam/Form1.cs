using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleExam
{
    public partial class Form1 : Form
    {
        string[] doubleAgents = new string[7] { "Aldrich Ames", "Mathilde Carre", "Oleg Penkovsky", "Donald Mclean",
                "Margaretha Geertrudia MacLeod", "Matei Pavel Haiduca", "Brian Nelson" };
        string[] agencies = new string[7] { "CIA", "None", "GRU", "None", "None", "Department of State Security", "Ulster Defense Association" };
        string[] nationality = new string[7] { "American", "French", "Russian", "British", "Dutch", "Romanian", "Irish" };
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string spyName = txtNameSearch.Text;
            string spyNation = txtNationSearch.Text;
            string spyAgency = txtAgencySearch.Text;

            ShowDossier();
        }
        public void SearchByName(string spyName)
        {
            int agentPosition = -1;

            for (int i = 0; i < doubleAgents.Length; i++)
            {
                if (string.IsNullOrEmpty(spyName))
                {
                    lblSearchError.Visible = true;
                }
                else if (string.ToLower().Contains(spyName))
                {
                    return;
                }
                else
                {
                    lblSearchError.Visible = true;
                }
            }
        }
        public void SearchByNationality(string spyNation)
        {
            int nationalityPosition = -1;

            for (int i = 0; i < nationality.Length; i++)
            {
                if (string.IsNullOrEmpty(spyNation))
                {
                    lblSearchError.Visible = true;
                }
                else if (string.ToLower().Contains(spyNation))
                {
                    return;
                }
                else
                {
                    lblSearchError.Visible = true;
                }
            }
        }
        public void SearchByAgency(string spyAgency)
        {
            int agencyPosition = -1;

            for (int i = 0; i < agencies.Length; i++)
            {
                if (string.IsNullOrEmpty(spyAgency))
                {
                    lblSearchError.Visible = true;
                }
                else if (string.ToLower().Contains(spyAgency))
                {
                    return;
                }
                else
                {
                    lblSearchError.Visible = true;
                }
            }
        }
        public string ShowDossier()
        {
            txtName.Text = SearchByName();
            txtNationality.Text = SearchByNationality();
            txtAgency.Text = SearchByAgency();
        }
    }
}
