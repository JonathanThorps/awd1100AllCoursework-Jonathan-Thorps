using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>()
        { 
            new Student(11111,"Chris", "Redfield","credfield@capcom.com"),
            new Student(22222,"Leon","Kennedy","lskennedy@capcom.com"),
            new Student(33333,"Claire","Redfield","credfield2@capcom.com"),
            new Student(12345,"Ada","Wong","awong@capcom.com"),
            new Student(13579,"Jill","Valentine","jvalentine@capcom.com"),
            new Student(11223,"Rebecca","Chambers","rchambers@capcom.com")
        };
        public Form1()
        {
            InitializeComponent();
            rtStudentOutput.Text = students.Count.ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(txtStudentId.Text);
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmailAddress.Text;

                students.Add(new Student(studentId, firstName, lastName, email));
                rtStudentOutput.Text = students.Count.ToString("\n");
            }
            catch(StudentException)
            {

            }

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            int i = -1;

            if (students.Count == cbStudentID.SelectedIndex)
            {
                i = cbStudentID.SelectedIndex;
                students.Remove(students[i]);
            }
        }
    }
}
