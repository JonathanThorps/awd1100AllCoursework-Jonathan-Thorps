namespace TwiceAsOld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dadYears = 0;
            int sonYears = 0;
            TwiceAsOld();
        }
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            if (dadYears == 2 * sonYears)
            { }
        }
    }
}