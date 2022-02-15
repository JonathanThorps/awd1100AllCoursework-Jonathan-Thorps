namespace LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            string phrase = phraseBox.Text;
            string[] words = phrase.Split(" ");
            foreach (string word in words)
            SortWords();
            
        }
        private string SortWords(params string[] words)
        {
            foreach (string i in words)
            {
                Array.Sort(words);
            }
            return lblSortOutput.Text = String.Format($"{words}");
        }
    }
}