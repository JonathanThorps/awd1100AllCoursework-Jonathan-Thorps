namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal PERCENT_RAISE = .04m;

        private void button1_Click(object sender, EventArgs e)
        {
            decimal empSalary1 = Convert.ToDecimal(salary1.Text);

            decimal empSalary2 = Convert.ToDecimal(salary2.Text);

            decimal empSalary3 = Convert.ToDecimal(salary3.Text);

            decimal emp12019 = (empSalary1 * PERCENT_RAISE) + empSalary1;

            em1Sal19Out.Text = emp12019.ToString("c");

            decimal emp12020 = (emp12019 * PERCENT_RAISE) + emp12019;

            em1Sal20Out.Text = emp12020.ToString("c");

            decimal emp12021 = (emp12020 * PERCENT_RAISE) + emp12020;

            em1Sal21Out.Text = emp12021.ToString("c");

            decimal emp22019 = (empSalary2 * PERCENT_RAISE) + empSalary2;

            em2Sal19Out.Text = emp22019.ToString("c");

            decimal emp22020 = (emp22019 * PERCENT_RAISE) + emp22019;

            em2Sal20Out.Text = emp22020.ToString("c");

            decimal emp22021 = (emp22020 * PERCENT_RAISE) + emp22020;

            em2Sal21Out.Text = emp22021.ToString("c");

            decimal emp32019 = (empSalary3 * PERCENT_RAISE) + empSalary3;

            em3Sal19Out.Text = emp32019.ToString("c");

            decimal emp32020 = (emp32019 * PERCENT_RAISE) + emp32019;

            em3Sal20Out.Text = emp32020.ToString("c");

            decimal emp32021 = (emp32020 * PERCENT_RAISE) + emp32020;

            em3Sal21Out.Text = emp32021.ToString("c");
        }
    }
}