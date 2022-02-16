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
        private string ParseBid(out double bid)
        {
            string errorMsg = String.Format("Your bid of {0:C} was not accepted", bid);
            string bidAccepted = String.Format("Your bid of {0:C} was accepted", bid);

            if (int.TryParse(bid, out bidAmount))
            {
                if (bid > 10)
                {
                    lblBidStatus.Text = bidAccepted;
                }
                else
                {
                    lblBidStatus.Text = errorMsg;
                }
            }
            else if (bid.StartsWith("$"))
            {
             bid = bid.Substring(1);
                if (bid > 10)
                {
                    lblBidStatus.Text = bidAccepted;
                }
                else
                {
                    lblBidStatus.Text = errorMsg;
                }
            }
            else if (bid.StartsWith("$ "))
            {
             bid = bid.Substring(2);
                if (bid > 10)
                {
                    lblBidStatus.Text = bidAccepted;
                }
                else
                {
                    lblBidStatus.Text = errorMsg;
                }
            }
            else if (bid.Contains("dollar"))
            {
                string[] bidInput = bid.Split('\u002C');
                
            }
                
        }
       
    }
}