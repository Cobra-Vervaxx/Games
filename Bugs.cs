using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upg_finalni_projekt
{
    public partial class Bugs : Form
    {
        Random rnd = new Random();
        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 15;
        int enemySpeed;
        int attackSpeed;
        int playerLife = 3;

        public Bugs()
        {
            InitializeComponent();
            resetGame();
        }



        private void Bugs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void Bugs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                attack.Top = player.Top - 30;
                attack.Left = player.Left + (player.Width / 2);

            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            timer1.Start();
            enemySpeed = 6;
            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);
            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            score = 0;
            attackSpeed = 0;
            attack.Left = -300;
            shooting = false;


            txtScore.Text = score.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (enemyOne.Top > 720 || enemyTwo.Top > 720 || enemyThree.Top > 720)
            {
                playerLife--;
            }

            if (playerLife <= 0)
            {
                gameOver();
            }

            if (score == 5)
            {
                enemySpeed = 9;
            }
            if (score == 10)
            {
                enemySpeed = 11;
            }
            if (score == 15)
            {
                enemySpeed = 13;
                playerSpeed = 16;
            }
            if (score == 20)
            {
                enemySpeed = 17;
                playerSpeed = 19;
            }




            txtScore.Text = score.ToString();
            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;

            if (shooting == true)
            {
                attackSpeed = 20;
                attack.Top -= attackSpeed;
            }
            else
            {
                attack.Left = -300;
                attackSpeed = 0;
            }

            if (attack.Top < -30)
            {
                shooting = false;
            }

            if (attack.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;

            }
            if (attack.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -650;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;

            }
            if (attack.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;

            }


            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 688)
            {
                player.Left += playerSpeed;
            }
        }
        private void gameOver()
        {
            isGameOver = true;
            timer1.Stop();
            txtScore.Text += Environment.NewLine + "Game Over!!" + Environment.NewLine + "Press Enter to try again.";

        }
    }
}