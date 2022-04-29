namespace ClassDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogs_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog();
            Dog yourDog = new Dog();

            Dog bossDog = new Dog();

            Dog[] kennel = new Dog[];

            for (int i = 0; i < kennel.Length; i++)
            {
                kennel[i] = new Dog();
            }
            lblResult.Text = kennel[0].Age.ToString();
        }
    }
}