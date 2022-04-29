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
        List<Conference> conferences = new List<Conference>(20)
        {

        };
        int totalAttendees = 0;
        public Form1()
        {
            InitializeComponent();
            conferences.Add(new Conference() { Attendees = 100, GroupName = "Dev Up", StartingDate = Convert.ToDateTime("1/1/2000"), Room = Room.ROOM_101 });
            conferences.Add(new Conference() { Attendees = 100, GroupName = "Dev Up 2", StartingDate = Convert.ToDateTime("1/1/2001"), Room = Room.ROOM_102 });
        }

        private void btnAddConf_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            DateTime conferenceDate = Convert.ToDateTime(txtStartDate.Text);
            int attendees = Convert.ToInt32(txtAttendees.Text);
            int room = Convert.ToInt32(txtRoom.Text);

            conferences.Add(new Conference() { Attendees = attendees, GroupName = groupName, StartingDate = conferenceDate, Room = (Room)room });

            lblConfNum.Text += conferences.Count.ToString();
            totalAttendees += attendees;
            lblTotalAttend.Text = attendees.ToString();
            
        }

        private void btnSearchConf_Click(object sender, EventArgs e)
        {
            DateTime startingSearchDate = Convert.ToDateTime(txtBeginDate.Text);
            DateTime endingSearchDate = Convert.ToDateTime(txtEndDate.Text);

            for (int i = 0; i < conferences.Count; i++)
            {
                if (conferences[i].StartingDate > startingSearchDate && conferences[i].StartingDate < endingSearchDate)
                {
                    lblResult.Text += conferences[i].Display();
                }  
                    
            }
        }
    }
}
