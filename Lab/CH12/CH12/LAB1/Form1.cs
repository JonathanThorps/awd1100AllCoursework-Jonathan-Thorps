namespace LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        
            InitializeComponent();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text;
            string errorTxt = "I don't know that term yet. What does it mean?";

            FlashCard[] myDeck = new FlashCard[20];
            {
                                   
            }

            
            for (int i = 0; i < myDeck.Length; i++)
            {
                if (myDeck[i].ToLower().Contains(term.ToLower()))
                {
                    lblResult.Text = ;
                }
                else
                {
                    lblTermError.Text = errorTxt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}