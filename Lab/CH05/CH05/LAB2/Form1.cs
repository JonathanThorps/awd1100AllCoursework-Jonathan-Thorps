namespace LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            int windSpeed = Convert.ToInt32(windSpeedIn.Text);

            if (windSpeed >= 157)

                categoryOut.Text = String.Format("Category 5");

            else if (windSpeed >= 130)

                categoryOut.Text = String.Format("Category 4");

            else if (windSpeed >= 111)

                categoryOut.Text = String.Format("Category 3");

            else if (windSpeed >= 96)

                categoryOut.Text = String.Format("Category 2");

            else if (windSpeed >= 74)

                categoryOut.Text = String.Format("Category 1");

            else

                categoryOut.Text = String.Format("Not a hurricane");
        }
    }
}