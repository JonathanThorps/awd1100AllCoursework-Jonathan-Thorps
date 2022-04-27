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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            for (int i = 0; i < search.Length; i++)
            {
                if ("*".ToLower().Contains(search.ToLower()))
                {

                }
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee employeeForm = new NewEmployee();
                employeeForm.ShowDialog();
        }
    }
}
