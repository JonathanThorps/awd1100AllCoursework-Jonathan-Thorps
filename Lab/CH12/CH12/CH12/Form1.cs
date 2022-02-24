namespace CH12
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Car = new Car();
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            Car myCar = new Car();
            myCar.SetCarColor(txtColorBox.Text);
            myCar.SetCarPrice(myCar.GetCarPrice());

            myCar.GetCarColor(myCar.txtColor.Text);
            myCar.GetCarPrice(myCar.GetCarPrice());

            lblResult.Text = ($"{myCar.GetCarColor()}, {myCar.GetCarPrice()}");
        }
    }
}