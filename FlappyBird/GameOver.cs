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
using System.Data.SqlClient;

namespace FlappyBird
{
    public partial class GameOver : Form
    {
        int highScore;
        int playerScore;

        private void getHighScore()
        {
            StreamReader sw = new StreamReader("highscore.txt");
            highScore = Convert.ToInt32(sw.ReadLine());
            sw.Close();
        }


        public GameOver(int playerScore)
        {
            this.playerScore = playerScore;
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
            ActiveControl = textBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerPlayer();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerPlayer();
            this.Hide();          
            var game = new Game();
            game.Closed += (s, args) => this.Close();
            game.Show();           
        }

        private void registerPlayer()
        {
            string playername = textBox1.Text;
            playername = playername.Replace(" ", "");
            if (playername.Equals(""))
            {
                playername = "unknown";
            }
            playername = playername.Trim();
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Server=localhost;Database=master;Trusted_Connection=True;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "USE Flappy";
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Database selected!");
                string insert_query_command = "INSERT INTO player_data VALUES ('" + playername + "'," + playerScore + ")";
                using (SqlCommand insert_command = new SqlCommand(insert_query_command, cnn))
                {
                    insert_command.ExecuteNonQuery();
                    MessageBox.Show("Player registered!");
                }
            }
        }
    }
}
