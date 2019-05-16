﻿using System;
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
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 1;
        int IScore = 0;
        int velocity = 0;
        int increaseSpeedCount = 0;

        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;            
            InitializeComponent();            
            label2.Text = "Game Over!";
            label3.Text = "Your final score is: " + IScore;
            label4.Text = "I made this game.";
            
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;            
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
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 150.0F;
            float y = 35.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(score, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (IScore - increaseSpeedCount >= 10)
            {
                pipeSpeed += 1;
                increaseSpeedCount = 5;
            }
            velocity += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += velocity;
            label1.Text = "" + IScore;

            Random rand = new Random();

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }

            if (pipeBottom.Left < -80 || pipeTop.Left < - 80)
            {
                pipeBottom.Left = 1000;
                pipeTop.Left = 1000;
                IScore += 1;
                DrawString(IScore.ToString());
                pipeTop.SendToBack();
                int top_verticalValue = rand.Next(-295, 0);
                pipeTop.Location = new Point(pipeTop.Location.X, top_verticalValue);
                int bottom_verticalValue = pipeTop.Height - Math.Abs(top_verticalValue) + 150;
                pipeBottom.Location = new Point(pipeBottom.Location.X, bottom_verticalValue);
            }           
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
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
            var gameOverForm = new Form3(IScore);
            gameOverForm.Closed += (s, args) => this.Close();
            gameOverForm.Show();
            //label3.Text = "Your final score is: " + IScore;
            //label3.Visible = true;
            //label4.Visible = true;
        } 
    }
}
