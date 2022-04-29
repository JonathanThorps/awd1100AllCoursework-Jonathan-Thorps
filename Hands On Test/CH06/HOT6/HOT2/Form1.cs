namespace HOT2
{
    public partial class Form1 : Form
    {;
        decimal tax = .08m;
        decimal shirtPrice = 13.75m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int shirtAmt = Convert.ToInt32(txtQuantity.Text);
            float discountCode = Convert.ToInt32(txtDiscountCode.Text);
            CheckDiscountCode();
            ShowInvoice(out int shirtAmt);
        }
        private string CheckDiscountCode(float discountCode)
        {
            decimal discount = 0;
           if (discountCode == 6483)
            {
                discount = .10m;
            }
           else if (discountCode == 5679)
            {
                discount = .20m;
            }
           else if (discountCode == 8264)
            {
                discount = .30m;
            }
           else if (txtDiscountCode.Text == string.Empty)
            {
                discount = 0;
            }
            else
            {
                return
                lblCodeError.Text = "** Invalid Discount Code **";
            }
        }
        private void ShowInvoice(ref decimal shirtPrice, out int shirtAmt, ref decimal tax, ref decimal discount)
        {
            decimal subtotal = 0;
            decimal salesTax = 0;
            decimal total = 0;

            if (CheckDiscountCode() == true)
            {
                decimal discountTotal = (discount * total) - total;
            }
            subtotal = shirtPrice * shirtAmt;
            salesTax = subtotal * tax;
            total = subtotal + salesTax;
            

            lblSubtotal.Text = subtotal;
            lblTax.Text = salesTax;
            lblTotal.Text = total;
        }
    }
}