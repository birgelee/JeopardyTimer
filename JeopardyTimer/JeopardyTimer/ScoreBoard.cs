using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyTimer
{
    public partial class ScoreBoard : Form
    {
        delegate void funct();
        KeyEventHandler EnterKeyHandlerFactory(funct handle)
        {
            return (sender, eventArgs) =>
            {
                if (eventArgs.KeyCode == Keys.Enter)
                {
                    eventArgs.Handled = true;
                    eventArgs.SuppressKeyPress = true;
                    handle();
                }
            };

        }

        void GiveMasterFormFocus()
        {
            this.playerLabel1.Focus();
        }
        public ScoreBoard()
        {
            InitializeComponent();
            
            player1Score.KeyDown += EnterKeyHandlerFactory(() => { GiveMasterFormFocus(); InsertPlayerScore(0); });
            player1Score.LostFocus += (x, y) => { GiveMasterFormFocus(); InsertPlayerScore(0); };

            player2Score.KeyDown += EnterKeyHandlerFactory(() => { GiveMasterFormFocus(); InsertPlayerScore(1); });
            player2Score.LostFocus += (x, y) => { GiveMasterFormFocus(); InsertPlayerScore(1); };

            player3Score.KeyDown += EnterKeyHandlerFactory(() => { GiveMasterFormFocus(); InsertPlayerScore(2); });
            player3Score.LostFocus += (x, y) => { GiveMasterFormFocus(); InsertPlayerScore(2); };

            player4Score.KeyDown += EnterKeyHandlerFactory(() => { GiveMasterFormFocus(); InsertPlayerScore(3); });
            player4Score.LostFocus += (x, y) => { GiveMasterFormFocus(); InsertPlayerScore(3); };
            this.TopMost = true;

        }

        private static Color selectedColor = Color.White;
        private static Color nonSelectedColor = Color.White;

        private static Color selectedBGColor = Color.BlueViolet;
        private static Color nonSelectedBGColor = Color.Blue;
        
        public void updateText()
        {
            this.TopMost = true;
            switch (Program.playerNumber + 1)
            {
                case 0:
                    playerLabel1.ForeColor = nonSelectedColor;
                    playerLabel2.ForeColor = nonSelectedColor;
                    playerLabel3.ForeColor = nonSelectedColor;
                    playerLabel4.ForeColor = nonSelectedColor;

                    playerLabel1.BackColor = nonSelectedBGColor;
                    playerLabel2.BackColor = nonSelectedBGColor;
                    playerLabel3.BackColor = nonSelectedBGColor;
                    playerLabel4.BackColor = nonSelectedBGColor;

                    break;
                case 1:
                    playerLabel1.ForeColor = selectedColor;
                    playerLabel1.BackColor = selectedBGColor;
                    break;
                case 2:
                    playerLabel2.ForeColor = selectedColor;
                    playerLabel2.BackColor = selectedBGColor;
                    break;
                case 3:
                    playerLabel3.ForeColor = selectedColor;
                    playerLabel3.BackColor = selectedBGColor;
                    break;
                case 4:
                    playerLabel4.ForeColor = selectedColor;
                    playerLabel4.BackColor = selectedBGColor;
                    break;
            }
            if (ShouldUpdateText())
            {
                player1Score.Text = "" + Program.playerPoints[0];

                player2Score.Text = "" + Program.playerPoints[1];

                player3Score.Text = "" + Program.playerPoints[2];

                player4Score.Text = "" + Program.playerPoints[3];
            }

        }


        public void InsertPlayerScore(int playerNumber)
        {
            try
            {
                int newScore;
                switch (playerNumber)
                {
                    case 0:
                        newScore = int.Parse(player1Score.Text);
                        break;
                    case 1:
                        newScore = int.Parse(player2Score.Text);
                        break;
                    case 2:
                        newScore = int.Parse(player3Score.Text);
                        break;
                    case 3:
                        newScore = int.Parse(player4Score.Text);
                        break;
                    default:
                        newScore = 0;
                        break;
                }
                Program.playerPoints[playerNumber] = newScore;
            }
            catch (Exception ex) { }


        }


        public bool ShouldUpdateText()
        {
            if (player1Score.Focused || player2Score.Focused || player3Score.Focused || player4Score.Focused)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
