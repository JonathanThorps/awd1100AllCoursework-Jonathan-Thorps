namespace HOT6
{
    public partial class Form1 : Form
    {
        string[] name = new string[5]
        {
            name[0] = "The Great Gatsby",
            name[1] = "War and Peace",
            name[2] = "Moby Dick",
            name[3] = "Hamlet",
            name[4] = "Pride and Prejudice"
        };

        string[] description = new string[5]
        {
            description[0] = "The story of eccentric millionare Jay Gatsby and his pursuit of his lost love.",
            description[1] = "A fictional story about the 1812 French invasion of Russia.",
            description[2] = "The story of a sailor's relentless hunt for a white whale.",
            description[3] = "A Shakespearean tragedy about a young man coming home from college after the murder of his father ",
            description[4] = "A comedic story of love and life in Old England."
        };

        string[] author = new string[5]
            {
            author[0] = "F. Scott Fitzgerald",
            author[1] = "Leo Tolstoy",
            author[2] = "Herman Melville",
            author[3] = "William Shakespreare",
            author[4] = "Jane Austen"
        };

        string[] isbn = new string[5]
        {
            isbn[0] = "978-1847496140",
            isbn[1] = "978-1400079988",
            isbn[2] = "978-1503280786",
            isbn[3] = "978-1973844402",
            isbn[4] = "978-0141439518"
        };

        public Form1()
        {
            InitializeComponent();

            string authorName = authorBox.Text;
            string isbnCode = isbnBox.Text;
            string keywordEntry = keywordBox.Text;

            string errorMsg = "Item not Found";
        }
        private void authorBtn_Click(object sender, EventArgs e)
        {
            SearchByAuthor();
            ShowBook();
        }

        private void isbnBtn_Click(object sender, EventArgs e)
        {
            SearchByIsbn();
            ShowBook();
        }

        private void keywordBtn_Click(object sender, EventArgs e)
        {
            SearchByKeyword();
            ShowBook();
        }
   
        private int SearchByAuthor(string authorName)
        {
            for (int i = 0; i < author.Length; i++)
                {
                if (authorName.ToLower().Contains(author[i]))
                   {
                   return author[i];
                   }
        }             
                        
    private int SearchByIsbn(string isbnCode)
    {
        for (int j = 0; j < isbn.Length; j++)
            {
                if (isbnCode.ToLower().Contains(isbn[i]))
                    {
                        return isbn[i];
                    }
            }
    }

    private int SearchByKeyword(string keywordEntry)
    {
        for (int k = 0; k < description.Length; k++)
            {
                if (keywordEntry.ToLower().Contains(description[i]))
                    {
                        return description[i];
                    }
            }
    }

    private string ShowBook(int[] name, int[] isbn, int [] description);
    {

        if (SearchByAuthor() == true || SearchByIsbn() == true || SearchByKeyword() == true)
        {
            lblName.Text = name[i];
            lblDescription.Text = description[i];
            lblAuthor.Text = author[i];
            lblIsbn.Text = isbn[i];
        }
        else
        {
            lblName.Text = errorMsg;
            lblDescription.Text = errorMsg;
            lblAuthor.Text = errorMsg;
            lblIsbn.Text = errorMsg;
        }
    }
}