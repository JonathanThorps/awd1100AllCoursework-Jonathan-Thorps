namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string error = "Error";
            string errorMsg = "User Not Found";
            string searchTerms = nameBox.Text;

            string[] firstName = new string[5];
            {
            firstName[0] = "Markel";
            firstName[1] = "Luiza";
            firstName[2] = "Bryony";
            firstName[3] = "Giraldo";
            firstName[4] = "Lowri";
            }
            string[] lastName = new string[5];
            {
            lastName[0] = "Diggory";
            lastName[1] = "Gunnar";
            lastName[2] = "Hester";
            lastName[3] = "Addy";
            lastName[4] = "Hari";
            }
            string[] phoneNum = new string[5];
            {
                phoneNum[0] = "555-8390";
                phoneNum[1] = "555-4618";
                phoneNum[2] = "555-4440";
                phoneNum[3] = "555-1687";
                phoneNum[4] = "555-7763";
            }
            for (int i = 0; i < 5; i++)
                if (firstName[i].ToLower().Contains(searchTerms.ToLower()))
                {
                    lblFirstName.Text = firstName[i];
                    lblLastName.Text = lastName[i];
                    lblPhoneNum.Text = phoneNum[i];
                    lblErrorMsg.Text = "";
                    break;
                }
            else if (lastName[i].ToLower().Contains(searchTerms.ToLower()))
                {
                    lblFirstName.Text = firstName[i];
                    lblLastName.Text = lastName[i];
                    lblPhoneNum.Text = phoneNum[i];
                    lblErrorMsg.Text = "";
                    break;
                }
            else
                {
                    lblFirstName.Text = error;
                    lblLastName.Text = error;
                    lblPhoneNum.Text = error;
                    lblErrorMsg.Text = errorMsg;
                }
        }
    }
}