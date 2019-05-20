using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdJakubSpr
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// bool control jump
        /// </summary>
        bool jumping = false;
                
        /// <summary>
        /// speed of pipe aproach
        /// </summary>
        int pipeSpeed = 5;

        /// <summary>
        /// gravity
        /// </summary>
        int gravity = 5;

        /// <summary>
        /// player's score
        /// </summary>
        int score = 0;

        
       


        public Form1()
        {
            InitializeComponent();

         //   labelEndGameCredit1.Text = "Game Over!";
         //   labelEndGameCredit2.Text = "Your final score is: " + score;
         //   labelEndGameCredit3.Text = "Game designed by Jakub Sprzaczkowski";

         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// timer function, also separate thread
        /// controls characters movements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // setting random variable to shift pipes
            Random shift = new Random();
            int shiftUp = shift.Next(90, 400); //shifts upper pipe right/left
            int shiftDown = shift.Next(50, 410); //shifts bottom pipe right/left
           
         
            // need to try set pipes changes their position up and down, not only left/right

            //////////////////////////////////////
            ///
            ///pictureBoxPipeBottom is upper pipe, and PipeTop is lower one - my dismiss
            pictureBoxPipeBottom.Left -= pipeSpeed;
            pictureBoxPipeTop.Left -= pipeSpeed;
            pictureBoxFlappyBird.Top += gravity;
            pictureBoxPipeTop.Height = 230;


            // checking if pipes left out of the screen, then pushing back - animation
            if (pictureBoxPipeBottom.Left <- 80)
                {
                //top pipe
                    pictureBoxPipeBottom.Left = shiftDown;
                //    pictureBoxPipeBottom.Top = shiftVerUp;
                    score += 1;
                    labelScore.Text = "Your score: " + score;
            }
            //bottom pipe
            else if (pictureBoxPipeTop.Left <- 95)
                {
                int shiftVerUp = shift.Next(250, 320); //shifts pipes verticaly
                pictureBoxPipeTop.Left = shiftUp;
        //           /* pictureBoxPipeTop.Top =*/ pictureBoxPipeTop.Height = shiftVerUp;
                    score += 1;
                    labelScore.Text = "Your score: " + score;

            }


            //conditions for notcolising objects
            if (pictureBoxFlappyBird.Bounds.IntersectsWith(pictureBoxGround.Bounds))
            { EndGame(); }
            else if (pictureBoxFlappyBird.Bounds.IntersectsWith(pictureBoxPipeBottom.Bounds))
            { EndGame(); }
            else if (pictureBoxFlappyBird.Bounds.IntersectsWith(pictureBoxPipeTop.Bounds))
            { EndGame(); }

        }

        /// <summary>
        /// key down function, movement up, decreases gravity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InGameKeyDown(object sender, KeyEventArgs e)
        {
            
            //condition for rising up
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -7;
            }
        }

        /// <summary>
        /// key up function, movement down, increases gravity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InGameKeyUp(object sender, KeyEventArgs e)
        {
           
            //condition for falling
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }

       

        /// <summary>
        /// end game function
        /// </summary>
        private void EndGame()
        {
            GameTimer.Stop();
            labelEndGameCredit1.Visible = true;
            labelEndGameCredit1.Text = "Game Over!";
            labelEndGameCredit2.Visible = true;
            labelEndGameCredit2.Text = "Your final score is: " + score;
            labelEndGameCredit3.Visible = true;
            labelEndGameCredit3.Text = "Game designed by Jakub Sprzaczkowski";
            MessageBox.Show("Your score is: " + score);
        }

        private void labelScore_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxPipeBottom_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
