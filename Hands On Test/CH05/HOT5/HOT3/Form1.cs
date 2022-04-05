namespace HOT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            decimal length = Convert.ToDecimal(lengthBox.Text);

            decimal width = Convert.ToDecimal(widthBox.Text);

            decimal area = length * width;

            int season = Convert.ToInt32(seasonLength.Text);
            int weeklyFee;

            if (area >= 600)
                    weekFee = 50; wklyFee.Text = Convert.ToString(weekFee);

            else if (area >= 400)
                    weekFee = 35; wklyFee.Text = Convert.ToString(weekFee);

            else

                    weekFee = 25;
                wklyFee.Text = Convert.ToString(weekFee);

            areaBox.Text = String.Format(area);

            totalCost.Text = Convert.ToString(weekFee * season);
        }
    }
}