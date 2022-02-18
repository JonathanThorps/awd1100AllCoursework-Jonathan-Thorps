namespace CodeWars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtBox1.Text);
            int s2 = Convert.ToInt32(txtBox2.Text);
            StringSum();
        }
        public static string StringSum()
        {
            if (string.IsNullOrEmpty(s1))
            {
                n1 = int.Parse(s1);
            }
            else
            {
                n2 = int.Parse(s2);
            }
            if (string.IsNullOrEmpty(s2))
            {
                n1 = 0;
            }
            else
            {
                n2 = int.Parse()
            }
        }
    }
}