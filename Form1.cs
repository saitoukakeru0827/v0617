using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0617
{
    public partial class Form1 : Form
    {
        int vx = -10, vy = -10,score = 100;

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + ClientSize.Width);
            //MessageBox.Show("" + ClientSize.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left <= 0)
                vx = -vx;
            if (label1.Top <= 0)
                vy = -vy;
            if (label1.Left >= 680)
                vx = -vx;
            if (label1.Top >= 400)
                vy = -vy;
            label1.Left += vx;
            label1.Top += vy;
            score--;
            label2.Text = "Score " + score;
        }
    }
}
