using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorRacing
{
    public partial class MotorRace : Form
    {
        public MotorRace()
        {
            InitializeComponent();
            label1.Visible = false;
            button1.Visible = false;
        }

        private void MotorRace_Load(object sender, EventArgs e)
        {

        }
        void coin(int speed)
        {
            int x, y;
            //coin1
            if (coin1.Top >= 500)
            {
                x = r.Next(180, 300);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            //coin2
            if (coin2.Top >= 500)
            {
                x = r.Next(280, 320);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
           
        }
        int collectedcoins = 0;

        void coincollected()
        {
            int x;

            if (cycle.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins += 1; ;
                label2.Text = "Coins = " + collectedcoins.ToString() ;
                x = r.Next(0, 180);
                coin1.Location = new Point(x, 0);
            }
            if (cycle.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins+=1;
                label2.Text = "Coins = " + collectedcoins.ToString();
                x = r.Next(0, 180);
                coin2.Location = new Point(x, 0);

            }

        }
        Random r = new Random();
        void obstacle(int speed)
        {
            int x, y;
            //obstacle1
            if (obstacle1.Top >= 500)
            {
                x = r.Next(160, 280);
                obstacle1.Location = new Point(x, 0);
            }
            else
            {
                obstacle1.Top += speed;
            }

            //obstacle2
            if (obstacle2.Top >= 500)
            {
                x = r.Next(270, 300);
                obstacle2.Location = new Point(x, 0);
            }
            else
            {
                obstacle2.Top += speed;
            }
            //obstacle3
            if (obstacle3.Top >= 500)
            {
                x = r.Next(290, 320);
                obstacle3.Location = new Point(x, 0);
            }
            else
            {
                obstacle3.Top += speed;
            }
        }


        void gameover()
        {
            if (cycle.Bounds.IntersectsWith(obstacle1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
            }
            if (cycle.Bounds.IntersectsWith(obstacle2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
            }
            if (cycle.Bounds.IntersectsWith(obstacle3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                button1.Visible = true;
            }
        }
        void MoveTree(int speed)
        {
            if (pictureBox6.Top>=500)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }
            if (pictureBox7.Top >= 500)
            {
                pictureBox7.Top = 0;
            }
            else
            {
                pictureBox7.Top += speed;
            }
            if (pictureBox8.Top >= 500)
            {
                pictureBox8.Top = 0;
            }
            else
            {
                pictureBox8.Top += speed;
            }
            if (pictureBox9.Top >= 500)
            {
                pictureBox9.Top = 0;
            }
            else
            {
                pictureBox9.Top += speed;
            }
        }
        void MoveLine(int speed)
        {
            //Line1
            if (pictureBox1.Top>=500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            //Line2
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            //Line 3
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gamespeed);
            MoveTree(gamespeed);
            obstacle(gamespeed);
            gameover();
            coin(gamespeed);
            coincollected();
            
        }
        int gamespeed;
        private void MotorRace_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==Keys.Left)
            {
                if (cycle.Left>130)
                
                   cycle.Left += -15;  
            }
            if (e.KeyCode==Keys.Right)
            {
                if(cycle.Right<350)
                cycle.Left += 15;
            }

            if(e.KeyCode==Keys.Up)
            {
                if (gamespeed<21)
                {
                    gamespeed++;
                }
            }
            if(e.KeyCode==Keys.Down)
            {
                if(gamespeed>0)
                {
                    gamespeed--;
                }
            }
                  
        }

        private void cycle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
