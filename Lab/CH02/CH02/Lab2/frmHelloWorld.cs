namespace Lab2
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }
private void btnSubmit_Click(object sender, EventArgs e)
{
    lblDisplay.Text = "Hello " + txtUsername.Text;
}

    }
}
