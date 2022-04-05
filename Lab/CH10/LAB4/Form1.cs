using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>()
        {
            new Student("Joe","Louis","INF 2100",'C', 2.75),
            new Student("Oscar","DeLaHoya","ACR 1000",'A',3.5),
            new Student("Mike","Tyson","AMT 1000",'D',2.0),
            new Student("Lennox","Lewis","HVAC 1000",'A',4),
            new Student("Roy","Jones Jr.","AWD 1100",'A',3.5),
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchFirstName_Click(object sender, EventArgs e)
        {
            
            try
            {
                string firstName = txtFirstName.Text;

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].FirstName.ToLower() == firstName)
                    {
                        lblStudentName.Text = students[i].FirstName + students[i].LastName;
                        lblCourseName.Text = students[i].Course;
                        lblCourseGrade.Text = Convert.ToString(students[i].Grade);
                        lblCourseGpa.Text = Convert.ToString(students[i].Gpa);
                    }
                }
            }
            catch(StudentException)
            {
                lblStudentName.ForeColor = Color.Red;
                lblStudentName.Text = "Student Not Found";
            }
        }

        private void btnSearchLastName_Click(object sender, EventArgs e)
        {
            
            try
            { 
                string lastName = txtLastName.Text;
             
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].LastName.ToLower() == lastName)
                    {
                        lblStudentName.Text = students[i].FirstName + students[i].LastName;
                        lblCourseName.Text = students[i].Course;
                        lblCourseGrade.Text = Convert.ToString(students[i].Grade);
                        lblCourseGpa.Text = Convert.ToString(students[i].Gpa);
                    }
                }
            }

            catch (StudentException)
            {
                lblStudentName.ForeColor= Color.Red;
                lblStudentName.Text = "Student Not Found";
            }
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnSearchFirstName.PerformClick();
            }
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                btnSearchLastName.PerformClick();
            }
        }
    }
}
