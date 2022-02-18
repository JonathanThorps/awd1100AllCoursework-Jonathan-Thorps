namespace AreaPerimeter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaOrPerimeter();
            //int length = Convert.ToInt32(txtLength.Text);
            //int width = Convert.ToInt32(txtWidth.Text);

            //if (length == width)
            //{
            //    Area();
            //}
            //else
            //{
            //    Perimeter();
            //}
        }

        public static int AreaOrPerimeter(int l, int w)
        {
            // code goes here
            int result = 0;
            if (l == w)
            { 
                result = l * w
            }
            else
            {
                result = (l + w) * 2;
            }
            return result;
        }
        //private int Area(int length, int width)
        //{
        //    int area = length * width;

        //    return lblOutput.Text = ($"{area}ft sq");
        //}
        //private int Perimeter(int length, int width)
        //{
        //    int perimeter = (2 * length) + (2 * width);

        //    return lblOutput.Text = String.Format("{0}", perimeter);
        //}

    }
}