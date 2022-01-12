namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dayRate = Convert.ToDouble(dailyRate.Text);
            double days = Convert.ToDouble(numberOfDays.Text);

            double mileRate = Convert.ToDouble(mileageRate.Text);
            double miles = Convert.ToDouble(mileage.Text);

            double invoice = (dayRate * days) + (mileRate * miles);

            invoiceTotal.Text = String.Format("{0:N2}", invoice);
        }
    }
}