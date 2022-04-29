using System.Collections.Generic;
namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = 
        }
        public static int Fib(int n)

        List<int> fibList = new List<int> { 1, 1 };

            while (n >= fibList.Count)
            {
            fibList.Add(fibList[fibList.Count - 1] + fibList[fibList.Count - 2]);
            }

            return fibList[fibList.Count - 1];
    }
}