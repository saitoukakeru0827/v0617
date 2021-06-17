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
        int vx1 = rand.Next(-10,11), vy1 = rand.Next(-10, 11), score = 100, vx2 = rand.Next(-10, 11), vy2 = rand.Next(-10, 11), vx3 = rand.Next(-10, 11), vy3 = rand.Next(-10, 11);
        static Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("" + ClientSize.Width);
            //MessageBox.Show("" + ClientSize.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width );
            label1.Top = rand.Next(ClientSize.Height - label1.Height );
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);
            label5.Left = rand.Next(ClientSize.Width - label5.Width);
            label5.Top = rand.Next(ClientSize.Height - label5.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label3.Text = $"{fpos.X}, {fpos.Y}";
            label3.Left = fpos.X - label3.Width/2;
            label3.Top = fpos.Y - label3.Height/2;
            if (label1.Left <= 0)
                vx1 = -vx1;
            if (label1.Top <= 0)
                vy1 = -vy1;
            if (label1.Left >= ClientSize.Width- label1.Width )
                vx1 = -vx1;
            if (label1.Top >= ClientSize.Height- label1.Height )
                vy1 = -vy1;
            if (label4.Left <= 0)
                vx2 = -vx2;
            if (label4.Top <= 0)
                vy2 = -vy2;
            if (label4.Left >= ClientSize.Width - label4.Width)
                vx2 = -vx2;
            if (label4.Top >= ClientSize.Height - label4.Height)
                vy2 = -vy2;
            if (label5.Left <= 0)
                vx3 = -vx3;
            if (label5.Top <= 0)
                vy3 = -vy3;
            if (label5.Left >= ClientSize.Width - label5.Width)
                vx3 = -vx3;
            if (label5.Top >= ClientSize.Height - label5.Height)
                vy3 = -vy3;
            label1.Left += vx1;
            label1.Top += vy1;
            label4.Left += vx2;
            label4.Top += vy2;
            label5.Left += vx3;
            label5.Top += vy3;
            score--;
            label2.Text = "Score " + score;
            /*if(score==0)
            {
                vx = -vx;
                vy = -vy;
            }*/

            /*if (    (fpos.X >= label1.Left) 
                 && (fpos.X < label1.Right) 
                 && (fpos.Y >= label1.Top) 
                 && (fpos.Y < label1.Bottom)
                )
                timer1.Enabled = false;*/
            if ((fpos.X >= label1.Left)
                 && (fpos.X < label1.Right)
                 && (fpos.Y >= label1.Top)
                 && (fpos.Y < label1.Bottom)
                )
                label1.Visible = false;
            if ((fpos.X >= label4.Left)
                 && (fpos.X < label4.Right)
                 && (fpos.Y >= label4.Top)
                 && (fpos.Y < label4.Bottom)
                )
                label4.Visible = false;
            if ((fpos.X >= label5.Left)
                 && (fpos.X < label5.Right)
                 && (fpos.Y >= label5.Top)
                 && (fpos.Y < label5.Bottom)
                )
                label5.Visible = false;
            if (!(label1.Visible)
                 && !(label4.Visible)
                 && !(label5.Visible)
                )
                timer1.Enabled = false;
        }
    }
}
