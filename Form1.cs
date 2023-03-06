using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAovningar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form f = new Form();
            f.Show();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            lbl1.Text = "Hello";
        }

        int num = 0;

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            num++;
            lbl2.Text = num.ToString();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            int x, y;

            Random random = new Random();
            x = random.Next(0, 800);
            y = random.Next(0, 500);

            lbl1.Left = x;
            lbl1.Top = y;
        }

        private void btnUp_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Top -= 5;
        }

        private void btnLeft_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Left -= 5;
        }

        private void btnRight_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Left += 5;
        }

        private void btnDown_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Top += 5;
        }
    }
}
