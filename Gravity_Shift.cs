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
    public partial class Gravity_Shift : Form
    {
        private const int playerSize = 50;
        private const int enemySize = 30;
        private int enemySpeed = 5;
        public int score = 0;
        public int highScore = 0;
        public string stringScore;

        private int playerY;
        private int enemyX;
        private int enemy2X;
        private int enemy3X;
        private int enemy10X;
        private int enemy11X;
        private int enemy12X;
        private bool ongJump;
        private bool gravityShift;

        public Gravity_Shift()
        {
            InitializeComponent();
            MessageBox.Show("Elo! \n This is a gravity style game > - > \n \n Your goal is to reach 1500 score or above,\n while evading the Enemy (red) \n BY PRESSING SPACE \n \n Good luck!");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            StartBtn.Visible = false;
            InitializeGame();
        }

        private void InitializeGame()
        {
            playerY = ClientSize.Height - playerSize;
            enemyX = ClientSize.Width;
            enemy2X = ClientSize.Width;
            enemy3X = ClientSize.Width;
            enemy10X = ClientSize.Width;
            enemy11X = ClientSize.Width;
            enemy12X = ClientSize.Width;
            ongJump = false;
            gravityShift = false;
            gameTimer.Start();
        }



        private void jumpTimer_Tick(object sender, EventArgs e)
        {
            if (ongJump)
            {
                if (!gravityShift)
                {
                    playerY -= 10;
                    if (playerY <= 0)
                    {
                        jumpTimer.Stop();
                        fallTimer.Start();
                    }
                }
                else
                {
                    playerY += 10;
                    if (playerY >= ClientSize.Height - playerSize)
                    {
                        jumpTimer.Stop();
                        fallTimer.Start();
                    }
                }
            }

            Invalidate();
        }

        private void fallTimer_Tick(object sender, EventArgs e)
        {
            if (ongJump)
            {
                if (gravityShift)
                {
                    playerY -= 10;
                    if (playerY <= 0)
                    {
                        fallTimer.Stop();
                        ongJump = false;
                    }
                }
                else
                {
                    playerY += 10;
                    if (playerY >= ClientSize.Height - playerSize)
                    {
                        fallTimer.Stop();
                        ongJump = false;
                    }
                }
            }

            Invalidate();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            score++;
            enemyX -= enemySpeed;
            enemy2X -= enemySpeed;
            enemy3X -= enemySpeed;
            enemy10X -= enemySpeed;
            enemy11X -= enemySpeed;
            enemy12X -= enemySpeed;
            ScoreLbl.Text = "Score:  " + score;

            if (enemyX + enemySize < 0)
            {
                enemyX = ClientSize.Width;
            }
            if (enemy2X + 300 + enemySize < 0)
            {
                enemy2X = ClientSize.Width;
            }
            if (enemy3X + 600 + enemySize < 0)
            {
                enemy3X = ClientSize.Width;
            }
            if (enemy10X + 200 + enemySize < 0)
            {
                enemy10X = ClientSize.Width;
            }
            if (enemy11X + 700 + enemySize < 0)
            {
                enemy11X = ClientSize.Width;
            }
            if (enemy12X + 900 + enemySize < 0)
            {
                enemy12X = ClientSize.Width;
            }

            Rectangle playerRect = new Rectangle(50, playerY, playerSize, playerSize);
            Rectangle EnemyRect = new Rectangle(enemyX + 0, ClientSize.Height - enemySize, enemySize, enemySize);
            Rectangle EnemyRect2 = new Rectangle(enemy2X + 300, ClientSize.Height - enemySize, enemySize, enemySize);
            Rectangle EnemyRect3 = new Rectangle(enemy3X + 600, ClientSize.Height - enemySize, enemySize, enemySize);
            Rectangle EnemyRect10 = new Rectangle(enemy10X + 200, 0, enemySize, enemySize);
            Rectangle EnemyRect11 = new Rectangle(enemy11X + 700, 0, enemySize, enemySize);
            Rectangle EnemyRect12 = new Rectangle(enemy12X + 900, 0, enemySize, enemySize);

            if (playerRect.IntersectsWith(EnemyRect) || playerRect.IntersectsWith(EnemyRect2) || playerRect.IntersectsWith(EnemyRect3) || playerRect.IntersectsWith(EnemyRect10) || playerRect.IntersectsWith(EnemyRect11) || playerRect.IntersectsWith(EnemyRect12))
            {
                stringScore = Convert.ToString(score);

                if (score >= highScore)
                {
                    HighscoreLbl.Text = "Highscore:  " + score;
                    highScore = score;
                }
                score = 0;
                gameTimer.Stop();
                if (highScore >= 1500)
                {
                    MessageBox.Show("Game Over! \n BUT You have reached 1500 score or above, \n so here is your reward: \n \n CODE FOR MAIN FORM");
                }
                else
                {
                    MessageBox.Show("Game Over!");
                }
                StartBtn.Enabled = true;
                StartBtn.Visible = true;

            }

            Invalidate();
        }

 

        private void GravityShift_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            Rectangle playerRect = new Rectangle(50, playerY, playerSize, playerSize);
            Rectangle EnemyRect = new Rectangle(enemyX + 0, ClientSize.Height - enemySize, enemySize, enemySize);
            Rectangle EnemyRect2 = new Rectangle(enemy2X + 300, ClientSize.Height - enemySize, enemySize, enemySize);
            Rectangle EnemyRect3 = new Rectangle(enemy3X + 600, ClientSize.Height - enemySize, enemySize, enemySize);
            Rectangle EnemyRect10 = new Rectangle(enemy10X + 200, 0, enemySize, enemySize);
            Rectangle EnemyRect11 = new Rectangle(enemy11X + 700, 0, enemySize, enemySize);
            Rectangle EnemyRect12 = new Rectangle(enemy12X + 900, 0, enemySize, enemySize);

            g.FillRectangle(Brushes.Blue, playerRect);
            g.FillRectangle(Brushes.Red, EnemyRect);
            g.FillRectangle(Brushes.Red, EnemyRect2);
            g.FillRectangle(Brushes.Red, EnemyRect3);
            g.FillRectangle(Brushes.Red, EnemyRect10);
            g.FillRectangle(Brushes.Red, EnemyRect11);
            g.FillRectangle(Brushes.Red, EnemyRect12);
        }

        private void GravityShift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !ongJump)
            {
                if (gravityShift)
                {

                    if (playerY >= ClientSize.Height - playerSize)
                        playerY = ClientSize.Height - playerSize;

                }
                gravityShift = !gravityShift;
                ongJump = true;
                jumpTimer.Start();
            }
        }
    }
}
