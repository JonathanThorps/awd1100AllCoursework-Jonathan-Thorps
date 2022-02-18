namespace FirstandLast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = messageBox.Text;
            lblSOut.Text = Message;
        }
        public static string Remove_char(string s)
        {
            // Your Code
            string message = s.Substring(1,s.Length - 2);
            return lblSOut.Text = message;
        }
    }
}