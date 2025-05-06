using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                Box calculate = new Box(length, width, height);
                label4.Text = $" 體積 = {calculate.Volume():F2} 立方公分 ";
            }
            catch
            {
                label4.Text = $"輸入錯誤 , 請重新輸入";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(textBox1.Text);
                double width = double.Parse(textBox2.Text);
                double height = double.Parse(textBox3.Text);
                Box calculate = new Box(length, width, height);
                label4.Text = $"表面積和 = {calculate.Area():F2} 平方公分";
            }
            catch
            {
                label4.Text = $"輸入錯誤 , 請重新輸入";
            }
        }
    }
}
