using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDemo
{
    HenryDataContext henryDb = new HenryDataContext();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var data = henryDb.Authors;
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            where();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }
    }
}
