namespace LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        const int dozen = 12;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int chickenClare = Convert.ToInt32(clareNumEggs.Text);

            int chickenRed = Convert.ToInt32(redNumEggs.Text);

            int chickenBelle = Convert.ToInt32(belleNumEggs.Text);

            int chickenAnnie = Convert.ToInt32(annieNumEggs.Text);

            int totalEggs = chickenClare + chickenRed + chickenBelle + chickenAnnie;

            totalBox.Text = totalEggs.ToString();

            int numDozen = totalEggs / dozen;

            double remainingEggs = totalEggs % dozen;

            dozenOutput.Text = String.Format("There are {0} dozens and {1} left over eggs", numDozen, remainingEggs);
        }
    }
}