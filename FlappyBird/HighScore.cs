using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateScoreList();
        }

        private void populateScoreList()
        {
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
            }
            sql = "select name, score from player_data order by score desc offset 0 rows fetch next 3 rows only";
            SqlDataReader dataReader;
            string Output = "";
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                dataReader = command.ExecuteReader();

                Label[] playerNameList = new Label[3];
                playerNameList[0] = player1Name;
                playerNameList[1] = player2Name;
                playerNameList[2] = player3Name;

                Label[] playerScoreList = new Label[3];
                playerScoreList[0] = player1Score;
                playerScoreList[1] = player2Score;
                playerScoreList[2] = player3Score;                                       
                int i = 0;
                while (dataReader.Read())
                {
                    playerNameList[i].Text = dataReader.GetValue(0).ToString();
                    playerScoreList[i].Text = dataReader.GetValue(1).ToString();
                    i++;
                }
                //MessageBox.Show(Output);
            }
            cnn.Close();
        }

        private void player1Name_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
