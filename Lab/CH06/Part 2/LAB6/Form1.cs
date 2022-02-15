namespace LAB6
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(txtEntryBox.Text);
            
            int[] numbers = new int[20]; 
            
            numbers[count] = startValue;
            count++;
            int minNum = 0;
            int maxNum = 0;
            double sum = 0;
            double average = 0;
            CalculateStats(out minNum,out maxNum,out sum, out average,numbers);
            //output
            lblNumEntered.Text = String.Format($"{count}");
        }
        private void CalculateStats(out int min, out int max, out double sum, out double avg, params int[] values)
        {
            do
            {
                for (int i = 0; i < 20; i++)
                {
                    if (values[i] > max)
                    {
                        max = values[i];
                        lblNumHighest.Text = values[i].ToString();
                    }
                    else
                    {
                        min = values[i];
                        lblNumLowest.Text = values[i].ToString();
                    }
                }

                for (int i = 0; i < 20; i++)
                {
                    sum += values[i] + sum;
                    lblSum.Text = String.Format($"{sum}");
                }

                avg = sum / count;
                lblAverage.Text = String.Format($"{avg}");

            } while (count < 20);

        }
        
    }
}