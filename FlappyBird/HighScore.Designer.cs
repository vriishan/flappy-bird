namespace FlappyBird
{
    partial class HighScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player1Name = new System.Windows.Forms.Label();
            this.player3Score = new System.Windows.Forms.Label();
            this.player3Name = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "High Scores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(15, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 4);
            this.panel1.TabIndex = 1;
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(15, 142);
            this.player1Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(62, 17);
            this.player1Name.TabIndex = 2;
            this.player1Name.Text = "label2";
            this.player1Name.Click += new System.EventHandler(this.player1Name_Click);
            // 
            // player3Score
            // 
            this.player3Score.AutoSize = true;
            this.player3Score.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Score.Location = new System.Drawing.Point(231, 236);
            this.player3Score.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player3Score.Name = "player3Score";
            this.player3Score.Size = new System.Drawing.Size(62, 17);
            this.player3Score.TabIndex = 4;
            this.player3Score.Text = "label4";
            // 
            // player3Name
            // 
            this.player3Name.AutoSize = true;
            this.player3Name.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Name.Location = new System.Drawing.Point(15, 236);
            this.player3Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player3Name.Name = "player3Name";
            this.player3Name.Size = new System.Drawing.Size(62, 17);
            this.player3Name.TabIndex = 5;
            this.player3Name.Text = "label5";
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(15, 189);
            this.player2Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(62, 17);
            this.player2Name.TabIndex = 6;
            this.player2Name.Text = "label6";
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.Location = new System.Drawing.Point(231, 142);
            this.player1Score.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(62, 17);
            this.player1Score.TabIndex = 7;
            this.player1Score.Text = "label7";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.Location = new System.Drawing.Point(231, 189);
            this.player2Score.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(62, 17);
            this.player2Score.TabIndex = 8;
            this.player2Score.Text = "label8";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(92, 306);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(275, 360);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player3Name);
            this.Controls.Add(this.player3Score);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HighScore";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Label player3Score;
        private System.Windows.Forms.Label player3Name;
        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Button closeButton;
    }
}