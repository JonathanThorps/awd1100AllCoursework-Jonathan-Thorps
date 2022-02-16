namespace LAB5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void bidBtn_Click(object sender, EventArgs e)
        {   
            double bidAmount = double.Parse(biddingBox.Text);
            ParseBid();
        }
        private string ParseBid(out double bidAmount)
        {
            string errorMsg = String.Format("Your bid of {0:C} was not accepted", bidAmount);
            string bidAccepted = String.Format("Your bid of {0:C} was accepted", bidAmount);

            if (int.TryParse(out double bidAmount))
            {
                if (bidAmount > 10)
                {
                    lblBidStatus.Text = bidAccepted;
                }
                else
                {
                    lblBidStatus.Text = errorMsg;
                }
            }
            else if (bidAmount.StartsWith("$"))
            {
             bidAmount = bidAmount.Substring(1);
                if (bidAmount > 10)
                {
                    lblBidStatus.Text = bidAccepted;
                }
                else
                {
                    lblBidStatus.Text = errorMsg;
                }
            }
            else if (bidAmount.StartsWith("$ "))
            {
             bidAmount = bidAmount.Substring(2);
                if (bidAmount > 10)
                {
                    lblBidStatus.Text = bidAccepted;
                }
                else
                {
                    lblBidStatus.Text = errorMsg;
                }
            }
            else if (bidAmount.Contains("dollar"))
            {
                string[] bidInput = bidAmount.Split('\u002C');
                {
                    if (!bidInput.Any())
                }
                
            }
                
        }
       
    }
}