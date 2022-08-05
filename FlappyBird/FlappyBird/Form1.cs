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
        int scoreCount = 0;  //counts score
        int pipeSpeed = 7;  
        int gravity = 13;
          
           
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            bird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;

            pipeDown2.Left -= pipeSpeed;
            pipeUp2.Left -= pipeSpeed;

            pipeDown3.Left -= pipeSpeed;
            pipeUp3.Left -= pipeSpeed;
            // gameOver.Visible = false;  //visibility of pressing 'esc' or 'enter' is false.

            //brings back the pipes creating an illusion
            if (pipeDown.Left < -120) //random value
            {
                pipeDown.Left = 1820;  //approx value greater than screen width
                scoreCount++;
            }
           // Score.Text = "Score: " + scoreCount.ToString();
            if (pipeUp.Left < -150)
            {
                pipeUp.Left = 2032;  //approx value greater than screen width
                scoreCount++;
            }

            if (pipeDown2.Left < -156) //random value
            {
                pipeDown2.Left = 2036;  //approx value greater than screen width
                scoreCount++;
            }
            // Score.Text = "Score: " + scoreCount.ToString();
            if (pipeUp2.Left < -195)
            {
                pipeUp2.Left = 2253;  //approx value greater than screen width
                scoreCount++;
            }

            if (pipeDown3.Left < -220) //random value
            {
                pipeDown3.Left = 2400;  //approx value greater than screen width
                scoreCount++;
            }
            // Score.Text = "Score: " + scoreCount.ToString();
            if (pipeUp3.Left < -230)
            {
                pipeUp3.Left = 2580;  //approx value greater than screen width
                scoreCount++;
            }

            Score.Text = "Score: " + scoreCount.ToString();

            if (bird.Bounds.IntersectsWith(pipeDown.Bounds) || bird.Bounds.IntersectsWith(pipeUp.Bounds)||
                bird.Bounds.IntersectsWith(pipeDown2.Bounds) || bird.Bounds.IntersectsWith(pipeUp2.Bounds) ||
                bird.Bounds.IntersectsWith(pipeDown3.Bounds) || bird.Bounds.IntersectsWith(pipeUp3.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) )
            {
                // if any of the conditions are met from above then end the game.
                gameTimer.Stop();

                //this is the code for restart
                Score.Text += " Game Over !!! ";
                if ((MessageBox.Show("Would you like to play again?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    System.Environment.Exit(1);
                }
                //gameOver.Visible = true;  //visibility of pressing 'esc' or 'enter' becomes true as soon as game is over.
            }

            if (scoreCount > 5)
            {
                pipeSpeed = 10;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 13;  //movement of bird downward while the space key is released
            }
        }

       

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -13; //movement of bird upward while the space key is pressed.
            }
        }
    }
}
