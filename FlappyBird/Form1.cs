using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;

            if(pipeTop.Left < -150)
            {
                pipeTop.Left = 445;
            }

            if (pipeBottom.Left < -130)
            {
                pipeBottom.Left = 500;
            }

            if (bird.Bounds.IntersectsWith(pipeTop.Bounds) || bird.Bounds.IntersectsWith(pipeBottom.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }

        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
        }

    }
}
