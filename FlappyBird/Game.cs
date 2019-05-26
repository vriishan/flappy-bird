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
    public partial class Game : Form
    {
        bool jumping = false;
        int pipeSpeed = 3;
        int gravity = 1;
        int IScore = 0;
        int velocity = 0;
        int increaseSpeedCount = 0;
        bool hasPassedFirst = false;
        bool hasPassedSecond = false;
        bool firstTime = true;

        public Game()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;             
            InitializeComponent();            
        }

        //protected override void OnPaintBackground(PaintEventArgs e) { /* Do nothing */ }

        protected override void OnPaint(PaintEventArgs e)
        {
            // If there is an image and it has a location, 
            // paint it when the Form is repainted.
            base.OnPaint(e);                   
        }

        public void DrawString(string score)
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            //string drawString = "Sample Text";
            System.Drawing.Font drawFont = new System.Drawing.Font("04b_19", 26, FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);            
            float x = 150.0F;
            float y = 40.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(score, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pipeBottom_2.SendToBack();
            pipeTop_2.SendToBack();
            pipeTop.SendToBack();
            pipeBottom.SendToBack();            
            //using (Graphics g = Graphics.FromImage("C:\\Users\\Vrushab\\C#\\repos\\FB\\flappy-bird\\FlappyBird\\assets\\images\\bird.png")) ;
            //GameController 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            DrawString(IScore.ToString());
            if (IScore - increaseSpeedCount >= 10)
            {
                pipeSpeed += 1;
                increaseSpeedCount += 5;
            }
            velocity += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            pipeTop_2.Left -= pipeSpeed;
            pipeBottom_2.Left -= pipeSpeed;
            flappyBird.Top += velocity;           

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom_2.Bounds))
            {
                endGame();
            }
            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop_2.Bounds))
            {
                endGame();
            }            

            if (pipeBottom.Left < -80 || pipeTop.Left < -80)
            {                
                pipeBottom.Left = 500;
                pipeTop.Left = 500;                
                generatePipesFirst();                            
                hasPassedFirst = true;
            }            

            if ((pipeTop_2.Left < -400 || pipeBottom_2.Left < -400) && firstTime == true)
            {
                pipeBottom_2.Left = 500;
                pipeTop_2.Left = 500;
                generatePipesSecond();
                firstTime = false;
                hasPassedSecond = true;
            }

            if ((pipeTop_2.Left < -80 || pipeBottom_2.Left < -80) && firstTime == false)
            {
                pipeBottom_2.Left = 500;
                pipeTop_2.Left = 500;
                generatePipesSecond();
                firstTime = false;
                hasPassedSecond = true;
            }


            if ((pipeBottom.Left < 100 || pipeTop.Left < 100) && (hasPassedFirst==true))
            {
                IScore += 1;                                
                hasPassedFirst = false;
            }

            if ((pipeBottom_2.Left < 100 || pipeTop_2.Left < 100) && (hasPassedSecond==true))                
            {
                IScore += 1;
                hasPassedSecond = false;
            }          
        }

        private void generatePipesFirst()
        {
            Random rand = new Random();
            int top_verticalValue = rand.Next(-300, -5);
            pipeTop.Location = new Point(pipeTop.Location.X, top_verticalValue);
            int bottom_verticalValue = pipeTop.Height - Math.Abs(top_verticalValue) + 150;
            pipeBottom.Location = new Point(pipeBottom.Location.X, bottom_verticalValue);            
        }

        private void generatePipesSecond()
        {
            Random rand = new Random();
            int top_verticalValue = rand.Next(-295, 15);
            pipeTop_2.Location = new Point(pipeTop_2.Location.X, top_verticalValue);
            int bottom_verticalValue = pipeTop_2.Height - Math.Abs(top_verticalValue) + 150;
            pipeBottom_2.Location = new Point(pipeBottom_2.Location.X, bottom_verticalValue);
        }
    

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gameTimer.Enabled = true;
                getReady.Visible = false;
                jumping = true;
                velocity = -10;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                //velocity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            //label2.Visible = true;
            this.Hide();
            var gameOverForm = new GameOver(IScore);
            gameOverForm.Closed += (s, args) => this.Close();
            gameOverForm.Show();
            //label3.Text = "Your final score is: " + IScore;
            //label3.Visible = true;
            //label4.Visible = true;
        }       
    }
}
