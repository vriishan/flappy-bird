using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlappyBird
{
    public partial class Form3 : Form
    {
        int highScore;

        private void getHighScore()
        {
            StreamReader sw = new StreamReader("highscore.txt");
            highScore = Convert.ToInt32(sw.ReadLine());
            sw.Close();
        }


        public Form3(int playerScore)
        {
            InitializeComponent();
            label2.Text = "Your Score: " + playerScore;
            getHighScore();
            updateScore(playerScore);
            label3.Text = "High Score: " + highScore;
        }

        private void updateScore(int playerScore)
        {
            if (playerScore > highScore)
            {
                StreamWriter sw = new StreamWriter("highscore.txt");
                sw.WriteLine(playerScore);
                highScore = playerScore;
                sw.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();          
            var game = new Form1();
            game.Closed += (s, args) => this.Close();
            game.Show();           
        }
    }
}
