namespace LAB3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random myRandomGame = new Random();

        int rockPaperScissors = myRandomGame.Next(1, 4);


        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice.Text = String.Format("Player chooses Rock");

            if (myRandomGame.Next(1, rockPaperScissors) == 1)

                computerChoice.Text = String.Format("Computer chooses Rock");

            else if (myRandomGame.Next(1, rockPaperScissors) == 2)

                computerChoice.Text = String.Format("Computer chooses Paper");

            else (myRandomGame.Next(1, rockPaperScissors) == 3)

                    computerChoice.Text = String.Format("Computer chooses Scissors");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice.Text = String.Format("Player chooses Paper");

            if (myRandomGame.Next(1, rockPaperScissors) == 1)

                computerChoice.Text = String.Format("Computer chooses Rock");

            else if (myRandomGame.Next(1, rockPaperScissors) == 2)

                computerChoice.Text = String.Format("Computer chooses Paper");

            else (myRandomGame.Next(1, rockPaperScissors) == 3)

                    computerChoice.Text = String.Format("Computer chooses Scissors");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice.Text = String.Format("Player chooses Scissors");

            if (myRandomGame.Next(1, rockPaperScissors) == 1)

                computerChoice.Text = String.Format("Computer chooses Rock");

            else if (myRandomGame.Next(1, rockPaperScissors) == 2)

                computerChoice.Text = String.Format("Computer chooses Paper");

            else (myRandomGame.Next(1, rockPaperScissors) == 3)

                    computerChoice.Text = String.Format("Computer chooses Scissors");
        }
    }
}