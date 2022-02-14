namespace LAB3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void reverseBtn_Click(object sender, EventArgs e)
    {
        int first = Convert.ToInt32(txtBox1.Text);
        int second = Convert.ToInt32(txtBox2.Text);
        int third = Convert.ToInt32(txtBox3.Text);
        int fourth = Convert.ToInt32(txtBox4.Text);

        int num = fourth;
        int num2 = third;
        int num3 = second;
        int num4 = first;

        Reverse4(ref fourth, ref third, ref second, ref first);
        lblFirst.Text = $"{num4}";
        lblSecond.Text = $"{num3}";
        lblThird.Text = $"{num2}";
        lblLast.Text = $"{num}";

    }
   private void Reverse4(ref int fourth, ref int third, ref int second, ref int first)
    {
       

    }
}
