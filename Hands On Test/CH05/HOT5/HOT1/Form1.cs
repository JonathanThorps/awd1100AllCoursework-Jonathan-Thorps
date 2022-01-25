namespace HOT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            int inches = Convert.ToInt32(measureBox.Text);

            const decimal CM_PER_IN = 2.54m;

            decimal result = inches * CM_PER_IN;

            convertResult.Text = String.Format("{0} inches equals {1} centimeters", inches, result);
        }
    }
}