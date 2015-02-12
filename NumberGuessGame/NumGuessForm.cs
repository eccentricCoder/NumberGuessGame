using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberGuessGame
{
    public partial class NumGuessForm : Form
    {
        public bool isGameStarted = false;
        NumberGuessGameEngine game;
        public SetLimitsForm setLimits { get; set; }

        public int Attempts { get; set; }
        private readonly int MaxAttempts;

        public NumGuessForm()
        {
            InitializeComponent();
            game = new NumberGuessGameEngine();
            setLimits = new SetLimitsForm(game, this);
            lblMessage.Text = string.Empty;
            MaxAttempts = 6;
            Attempts = 0;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            game.GenerateNewSecretNumber();
            txtLowerLimit.Text = setLimits.LowerLimit.ToString();
            txtUpperLimit.Text = setLimits.UpperLimit.ToString();
            panel1.Enabled = true;
            btnEndGame.Enabled = true;
            btnStartGame.Enabled = false;
            isGameStarted = true;
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            btnEndGame.Enabled = false;
            btnStartGame.Enabled = true;
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            int value = 0;
            string guess = txtGuess.Text;
            bool success = Int32.TryParse(guess, out value);

            if (!success)
            {
                lblMessage.Text = string.Format("You have entered invalid data. Please try again.");
            }
            else
            {
                if (value != game.SecretNumber)
                {
                    if (value < game.SecretNumber && value >= game.LowerLimit)
                    {
                        value += 1;
                        txtLowerLimit.Text = value.ToString();
                        game.LowerLimit = value;
                        lblMessage.Text = string.Format("Hmm... The number you picked seems a bit low.");
                    }
                    else if (value > game.SecretNumber && value <= game.UpperLimit)
                    {
                        value -= 1;
                        txtUpperLimit.Text = value.ToString();
                        game.UpperLimit = value;
                        lblMessage.Text = string.Format("Hmm... The number you picked seems a bit high.");
                    }
                    else
                    {
                        lblMessage.Text = string.Format("The value entered is outside of the range of limits.");
                    }

                    ++Attempts;
                    if (Attempts == MaxAttempts)
                    {
                        // Exit Game
                        EndGameMessage("You've run out of attempts. Would you like to play again?", "You Loose");
                    }
                    else
                    {
                        lblMessage.Text = string.Format("Attempts: {0}\t Max Attempts: {1}", Attempts, MaxAttempts);
                    }
                }

                if (value == game.SecretNumber)
                {
                    lblMessage.Text = string.Format("Congratulations, You've guessed the correct number!!!");

                    EndGameMessage("Congratulations, You've guessed the correct number!!! Would you like to play again or exit?",
                        "Congratulations");
                }
            }
        }

        private void EndGameMessage(string msg, string title)
        {
            var result = MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                game = new NumberGuessGameEngine(setLimits.LowerLimit, setLimits.UpperLimit);
                this.txtUpperLimit.Text = game.UpperLimit.ToString();
                this.txtLowerLimit.Text = game.LowerLimit.ToString();
                this.lblMessage.Text = string.Empty;
                this.txtGuess.Text = string.Empty;
                Attempts = 0;
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void OnSetLimit_Click(object sender, EventArgs e)
        {
            setLimits.Show();
        }

    }
}
