namespace LAB4
{
    using System;
    using System.Collections;
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
            SortWords();
            
        }
        private string SortWords(params string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words.Sort();
            }
            return lblSortOutput.Text = String.Format("{0}", words);
        }
    }
}