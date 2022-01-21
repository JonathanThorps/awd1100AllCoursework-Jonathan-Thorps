namespace LAB3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random number = new Random();

        int rounds = 1;
       
        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice.Text = String.Format("Player chooses Rock");

            int computerChoice = number.Next(1, 4);
            
            if (computerChoice == 1)

                lblComputerChoice.Text = String.Format("Computer chooses Rock");

            else if (computerChoice == 2)

                lblComputerChoice.Text = String.Format("Computer chooses Paper");

            else

               lblComputerChoice.Text = String.Format("Computer chooses Scissors");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice.Text = String.Format("Player chooses Paper");

            int computerChoice = number.Next(1, 4);

            if (computerChoice == 1)

                lblComputerChoice.Text = String.Format("Computer chooses Rock");

            else if (computerChoice == 2)

                lblComputerChoice.Text = String.Format("Computer chooses Paper");

            else

                lblComputerChoice.Text = String.Format("Computer chooses Scissors");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice.Text = String.Format("Player chooses Scissors");

            int computerChoice = number.Next(1, 4);

            if (computerChoice == 1)

                lblComputerChoice.Text = String.Format("Computer chooses Rock");

            else if (computerChoice == 2)

                lblComputerChoice.Text = String.Format("Computer chooses Paper");

            else

                lblComputerChoice.Text = String.Format("Computer chooses Scissors");
        }
    }
}