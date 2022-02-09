namespace LAB5
{
    public partial class Form1 : Form
    {
        char[] vowels =
        {
            vowels[0] = 'A',
            vowels[1] = 'E',
            vowels[2] = 'I',
            vowels[3] = 'O',
            vowels[4] = 'U'
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
            for (; ;)
            {
                if (phrase.Length.Contains(ToLower(vowels.Length)))
                {

                }
            }
            
        }
    }
}