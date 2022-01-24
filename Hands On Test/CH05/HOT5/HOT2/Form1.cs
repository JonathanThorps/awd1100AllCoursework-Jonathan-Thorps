namespace HOT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradeBtn_Click(object sender, EventArgs e)
        {
            decimal grade = Convert.ToDecimal(gradeBox.Text);

            if (grade > 3)

                gradeResult.Text = String.Format("A");

            else if (grade >= 2)

                gradeResult.Text = String.Format("B");

            else if (grade >= 1)

                gradeResult.Text = String.Format("C");

            else if (grade > 0)

                gradeResult.Text = String.Format("D");

            else

                gradeResult.Text = String.Format("F");
        }
    }
}