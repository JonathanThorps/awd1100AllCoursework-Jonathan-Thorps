namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            decimal gpa = Convert.ToDecimal(gpaInput.Text);

            double admissionTest = Convert.ToDouble(testScoreInput.Text);

            if (gpa >= 3 && admissionTest >= 60)

                admitOutput.Text = String.Format("Admit");

            else if (gpa <= 3 && admissionTest >= 80)

                admitOutput.Text = String.Format("Admit");

            else

                admitOutput.Text = String.Format("Reject");
        }
    }
}