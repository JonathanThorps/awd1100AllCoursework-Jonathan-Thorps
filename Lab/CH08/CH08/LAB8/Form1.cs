namespace LAB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskBtn_Click(object sender, EventArgs e)
        {
             string cardNumber = cardNumBox.Text;

            for (int i = 0; i < cardNumber.Length - 4; i++)
                if (cardNumber[i] bool char IsDigit)
                {
                lblCardMask.Text = char.ToString();
            }
        }
    }
}