namespace HOT1
{
    public partial class Form1 : Form
    {
        int smallShirt = 0;
        int mediumShirt = 0;
        int largeShirt = 0;
        decimal salesTax = .07m;
        decimal smallPrice = 9.99m;
        decimal mediumPrice = 10.99m;
        decimal largePrice = 11.99m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            smallShirt++;
            lblSmallCount.Text = smallShirt.ToString();
            AddShirt(out int smallShirt);
            ShowInvoice(out int smallShirt, decimal smallPrice);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            mediumShirt++;
            lblMedCount.Text = mediumShirt.ToString();
            AddShirt(out int mediumShirt);
            ShowInvoice(out int mediumShirt);
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            largeShirt++;
            lblLrgCount.Text = largeShirt.ToString();
            AddShirt(out int largerShirt);
            ShowInvoice(out int largeShirt);
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }
        private string AddShirt(out int smallShirt, out int mediumShirt, out int largeShirt)
        {
            smallShirt = 0;
            mediumShirt = 0;
            largeShirt = 0;
            return
                lblSmallTotal.Text = String.Format("{0} small @ $9.00", smallShirt);
                lblMedTotal.Text = String.Format("{0} medium @ $10.99", mediumShirt);
                lblLrgTotal.Text = String.Format("{0} large @ $11.99", largeShirt);
        }
        private decimal ShowInvoice(out int smallShirt, out int mediumShirt, out int largeShirt, ref decimal smallPrice, ref decimal mediumPrice, ref decimal largePrice, ref decimal salesTax)
        {
            smallShirt = 0;
            mediumShirt = 0;
            largeShirt = 0;
            decimal smallSubtotal = 0;
            decimal mediumSubtotal = 0;
            decimal largeSubtotal = 0;
            decimal subtotal = smallSubtotal + mediumSubtotal + largeSubtotal;
            decimal tax = subtotal * salesTax;
            decimal total = (subtotal * salesTax) + subtotal;

            if (smallShirt > 0)
            {
                smallSubtotal = smallPrice * smallShirt;
            }
            if (mediumShirt > 0)
            {
                mediumSubtotal = mediumPrice * mediumShirt;
            }
            if (largeShirt > 0)
            {
                largeSubtotal = largePrice * largeShirt;
            }
            return

            lblSubtotal.Text = $"{subtotal:C}";
            lblTax.Text = $"{tax:C}";
            lblTotal.Text = $"{total:C}";
        }
        private void ClearOrder(int smallShirt, int mediumShirt, int largeShirt)
        {
            lblSmallCount.Text = "";
            lblMedCount.Text = "";
            lblLrgCount.Text = "";
            lblSmallTotal.Text = String.Format("{0} small @ $9.00", smallShirt);
            lblMedTotal.Text = String.Format("{0} medium @ $10.99", mediumShirt);
            lblLrgTotal.Text = String.Format("{0} large @ $11.99", largeShirt);
            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }
    }
}