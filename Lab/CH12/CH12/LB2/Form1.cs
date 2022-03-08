using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        List<Conference> conference = new List<Conference>(20)
        {

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddConf_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            DateTime conferenceDate = Convert.ToDateTime(txtStartDate.Text);
            int attendees = Convert.ToInt32(txtAttendees.Text);
            int room = Convert.ToInt32(txtRoom.Text);

            conference.Add(new Conference() { Attendees = attendees, GroupName = groupName, StartingDate = conferenceDate, Room = (Room)room });
        }

        private void btnSearchConf_Click(object sender, EventArgs e)
        {
            DateTime beginDate = Convert.ToDateTime(txtStartDate.Text);
            DateTime endDate = Convert.ToDateTime(txtEndDate.Text);
            Conference.Display();

            for (int i = 0; i < conference.Count; i++)
            {
                int startPosition = -1;
                int endPosition = 0;
                if (beginDate && endDate)
                {
                    
                }  
                    
            }
        }
    }
}
