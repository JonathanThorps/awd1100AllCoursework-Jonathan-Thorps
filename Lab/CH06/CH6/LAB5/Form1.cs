namespace LAB5
{
    public partial class Form1 : Form
    {
        char[] vowels = new char[]
        {
            vowels[0] = 'a',
            vowels[1] = 'e',
            vowels[2] = 'i',
            vowels[3] = 'o',
            vowels[4] = 'u'
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            CountVowels();
        }
        private string CountVowels()
        {
            string phrase = phraseBox.Text;
            int vowelNum;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase.Length.ToLower().Contains(vowels[i]))
                {
                    vowelNum = i;
                    lblVowelOutput.Text = String.Format("There are {0} vowels in your phase.", vowelNum);
                }
            }
            
        }
    }
}