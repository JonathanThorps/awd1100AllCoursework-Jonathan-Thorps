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
            lblNumEntered.Text = count.ToString();
        }
        private int CalculateStats(out int minNum, out int maxNum, out double sum, out double avg, params int[] numbers)
        {
            do
            {
                for (int i = 0; i < count; i++)
                {
                    if (numbers[i] > maxNum)
                    {
                        maxNum = numbers[i];
                        lblNumHighest.Text = numbers[i].ToString();
                    }
                    else
                    {
                        minNum = numbers[i];
                        lblNumLowest.Text = numbers[i].ToString();
                    }
                   
                }
                sum = 0;
                for (int i = 0; i < count; i++)
                {
                    sum += numbers[i];
                    lblSum.Text = sum.ToString();
                }

                avg = sum / count;
                lblAverage.Text = avg.ToString();

            } while (count < 20);

        }
       
    }
}