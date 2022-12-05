using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(int n, double x, int i = 0)
        {
            if (i <= n)
            {
                double result = i + x / f(n, x, i + 1);
                return Math.Round(result, 2);
            }
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                if (n > 0)
                {
                    textBox3.Text = "y = " + (f(n, x));
                }
                else MessageBox.Show("n должно быть натуральным числом");
            }
            catch { MessageBox.Show("Некорректный ввод данных"); }
        }
    }
}
