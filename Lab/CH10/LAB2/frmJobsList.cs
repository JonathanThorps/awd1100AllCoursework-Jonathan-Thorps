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
    public partial class frmJobsList : Form
    {
        Industry[] _industries;
        public frmJobsList(Industry[] industries)
        {
            InitializeComponent();
            _industries = industries;
        }

        private void frmJobsList_Load(object sender, EventArgs e)
        {

        }
    }
}
