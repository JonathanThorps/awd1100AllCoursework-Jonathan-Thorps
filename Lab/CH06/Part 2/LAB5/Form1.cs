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
            string errorMsg = "Your Bid was not accepted";
            double bidAmount = Double.Parse(biddingBox.Text);
            ParseBid();
        }
        private string ParseBid(string bid)
        {
            if (bid !=)
        }
        return lblBidStatus.Text = String.Format("Your Bid of {0} was accepted", )
    }
}