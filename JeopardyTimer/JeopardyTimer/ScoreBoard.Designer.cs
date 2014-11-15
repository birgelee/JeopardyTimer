namespace JeopardyTimer
{
    partial class ScoreBoard
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
            this.playerLabel1 = new System.Windows.Forms.Label();
            this.playerLabel2 = new System.Windows.Forms.Label();
            this.playerLabel3 = new System.Windows.Forms.Label();
            this.playerLabel4 = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.TextBox();
            this.player2Score = new System.Windows.Forms.TextBox();
            this.player3Score = new System.Windows.Forms.TextBox();
            this.player4Score = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerLabel1
            // 
            this.playerLabel1.AutoSize = true;
            this.playerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playerLabel1.Location = new System.Drawing.Point(24, 1);
            this.playerLabel1.Name = "playerLabel1";
            this.playerLabel1.Size = new System.Drawing.Size(121, 31);
            this.playerLabel1.TabIndex = 0;
            this.playerLabel1.Text = "Player 1:";
            // 
            // playerLabel2
            // 
            this.playerLabel2.AutoSize = true;
            this.playerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playerLabel2.Location = new System.Drawing.Point(235, 1);
            this.playerLabel2.Name = "playerLabel2";
            this.playerLabel2.Size = new System.Drawing.Size(121, 31);
            this.playerLabel2.TabIndex = 1;
            this.playerLabel2.Text = "Player 2:";
            // 
            // playerLabel3
            // 
            this.playerLabel3.AutoSize = true;
            this.playerLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playerLabel3.Location = new System.Drawing.Point(450, 1);
            this.playerLabel3.Name = "playerLabel3";
            this.playerLabel3.Size = new System.Drawing.Size(121, 31);
            this.playerLabel3.TabIndex = 2;
            this.playerLabel3.Text = "Player 3:";
            // 
            // playerLabel4
            // 
            this.playerLabel4.AutoSize = true;
            this.playerLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.playerLabel4.Location = new System.Drawing.Point(651, 1);
            this.playerLabel4.Name = "playerLabel4";
            this.playerLabel4.Size = new System.Drawing.Size(121, 31);
            this.playerLabel4.TabIndex = 3;
            this.playerLabel4.Text = "Player 4:";
            // 
            // player1Score
            // 
            this.player1Score.BackColor = System.Drawing.Color.Blue;
            this.player1Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.player1Score.ForeColor = System.Drawing.Color.White;
            this.player1Score.Location = new System.Drawing.Point(151, 1);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(78, 31);
            this.player1Score.TabIndex = 4;
            this.player1Score.Text = "Player 1";
            // 
            // player2Score
            // 
            this.player2Score.BackColor = System.Drawing.Color.Blue;
            this.player2Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.player2Score.ForeColor = System.Drawing.Color.White;
            this.player2Score.Location = new System.Drawing.Point(362, 1);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(82, 31);
            this.player2Score.TabIndex = 5;
            this.player2Score.Text = "Player 1";
            // 
            // player3Score
            // 
            this.player3Score.BackColor = System.Drawing.Color.Blue;
            this.player3Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player3Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.player3Score.ForeColor = System.Drawing.Color.White;
            this.player3Score.Location = new System.Drawing.Point(577, 1);
            this.player3Score.Name = "player3Score";
            this.player3Score.Size = new System.Drawing.Size(68, 31);
            this.player3Score.TabIndex = 6;
            this.player3Score.Text = "Player 1";
            // 
            // player4Score
            // 
            this.player4Score.BackColor = System.Drawing.Color.Blue;
            this.player4Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player4Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.player4Score.ForeColor = System.Drawing.Color.White;
            this.player4Score.Location = new System.Drawing.Point(778, 1);
            this.player4Score.Name = "player4Score";
            this.player4Score.Size = new System.Drawing.Size(80, 31);
            this.player4Score.TabIndex = 7;
            this.player4Score.Text = "Player 1";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(858, 41);
            this.Controls.Add(this.player4Score);
            this.Controls.Add(this.player3Score);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.playerLabel4);
            this.Controls.Add(this.playerLabel3);
            this.Controls.Add(this.playerLabel2);
            this.Controls.Add(this.playerLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreBoard";
            this.ShowInTaskbar = false;
            this.Text = "Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel1;
        private System.Windows.Forms.Label playerLabel2;
        private System.Windows.Forms.Label playerLabel3;
        private System.Windows.Forms.Label playerLabel4;

        private System.Windows.Forms.TextBox player1Score;
        private System.Windows.Forms.TextBox player2Score;
        private System.Windows.Forms.TextBox player3Score;
        private System.Windows.Forms.TextBox player4Score;
    }
}