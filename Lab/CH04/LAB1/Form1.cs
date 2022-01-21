namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal KM_PER_MILE = 1.6m;

        private void convertMiles_Click(object sender, EventArgs e)
        {
            decimal miles = Convert.ToDecimal(milesInput.Text);

            decimal kmOutput = miles * KM_PER_MILE;

            kmOut.Text = kmOutput.ToString();

        }

        private void convertKm_Click(object sender, EventArgs e)
        {
            decimal kilometers = Convert.ToDecimal(kmInput.Text);

            decimal milesOutput = kilometers / KM_PER_MILE;

            milesOut.Text = milesOutput.ToString();
        }
    }
}