using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingBallGame
{
    public partial class Form_FlyingBall : Form
    {
        public Form_FlyingBall()
        {
            InitializeComponent();
        }

        //ball place
        int placeX = 5, placeY = 5, life = 3;

        //ball hits
        private void BallHit()
        {
            //label top
            if (button_Ball.Top <= label_Top.Bottom)
                placeY = placeY * -1;

            //button control hit
            if (button_Ball.Bottom >= button_ControlTool.Top && button_Ball.Left >= button_ControlTool.Left && button_Ball.Right <= button_ControlTool.Right)
                placeY = placeY * -1;

            //right hit
            else if (button_Ball.Right >= label_Right.Left)
                placeX = placeX * -1;

            //left hit
            else if (button_Ball.Left <= label_Left.Right)
                placeX = placeX * -1;
        }

        //ball fail
        private void BallFail(object sender, EventArgs e)
        {
            if (button_Ball.Top >= label_Right.Bottom)
            {
                if (life > 0)
                {
                    timer1.Stop();
                    life--;
                    MessageBox.Show("You crashed! Life left :" + life.ToString());
                    Form_FlyingBall_Load(sender, e);
                }
                if (life == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Game Over! You don't have any life left!", "" , MessageBoxButtons.OK);
                }
            }

            //Life
            label_Life.Text = life.ToString();
        }

        //button base reset
        private void BallReturns()
        {
            button_Ball.Location = new Point(275, 200);
        }

        private void Form_FlyingBall_Load(object sender, EventArgs e)
        {
            BallReturns();
            timer1.Enabled = true;
        }

        private void Form_FlyingBall_MouseMove(object sender, MouseEventArgs e)
        {
            button_ControlTool.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BallHit();
            button_Ball.Location = new Point(button_Ball.Location.X + placeX, button_Ball.Location.Y + placeY);
            BallFail(sender, e);
        }
    }
}