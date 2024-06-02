using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VF_projekt
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        int score;
        int aiImage;

        Random rand = new Random();
        Random radiationPosition = new Random();

        bool goleft, goright;
        public Form1()
        {
            
            InitializeComponent();
            ResetGame();
        }
      
        private void positionAI(PictureBox radiation)
        {
            radiation.Top = radiationPosition.Next(100, 400) * -1;
            

            if ((string)radiation.Tag == "radiationLeft")
            {
                radiation.Left = radiationPosition.Next(5, 200);
            }
            if ((string)radiation.Tag == "radiationRight")
            {
                radiation.Left = radiationPosition.Next(245, 422);
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

        }


        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

        }


        private async void gameTimerEvent(object sender, EventArgs e)
        {

            scoreBoard.Text = "Score: " + score;
            score++;


            if (goleft == true && player.Left > 5)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Right < 465)
            {
                player.Left += playerSpeed;
            }

            floor1.Top += roadSpeed;
            floor2.Top += roadSpeed;

            if (floor2.Top > 519)
            {
                floor2.Top = -519;
            }
            if (floor1.Top > 519)
            {
                floor1.Top = -519;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            if (AI1.Top > 500)
            {
                positionAI(AI1);
            }

            if (AI2.Top > 500)
            {
                positionAI(AI2);
            }

            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver();
            }

            if (score > 40 && score < 50)
            {
                award.Image = Properties.Resources.bronze;
            }

            if (score > 50 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadSpeed = 20;
                trafficSpeed = 22;
            }

            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                roadSpeed = 25;
                trafficSpeed = 27;
            }


        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-3, 5);
            explosion.BackColor = Color.Transparent;

            award.Visible = true;
            award.BringToFront();

            btnStart.Enabled = true;

        }

        private void ResetGame()
        {
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goleft = false ;    
            goright = false ;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = radiationPosition.Next(200, 500) * -1;
            AI1.Left = radiationPosition.Next(5, 200);

            AI2.Top = radiationPosition.Next(200, 500) * -1;
            AI2.Left = radiationPosition.Next(245, 422);

            gameTimer.Start();
        }

        private void restart(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            System.Media.SoundPlayer playExplosion = new System.Media.SoundPlayer(Properties.Resources.radiation);  
            playExplosion.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
