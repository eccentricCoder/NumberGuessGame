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
    public partial class SetLimitsForm : Form
    {
        public int UpperLimit { get; private set; }
        public int LowerLimit { get; private set; }


        public NumberGuessGameEngine Game { get;  private set; }
        public NumGuessForm GameForm { get;  private set; }

        public SetLimitsForm(NumberGuessGameEngine game, NumGuessForm form)
        {
            InitializeComponent();
            UpperLimit = 100;
            LowerLimit = 0;
            lblMessage.Visible = true;
            Game = game;
            GameForm = form;
            this.btnClose.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int upperLimit, lowerLimit;
            bool upperSuccess, lowerSuccess;

            lowerSuccess = Int32.TryParse(txtLowerLimit.Text, out lowerLimit);
            upperSuccess = Int32.TryParse(txtUpperLimit.Text, out upperLimit);

            if (lowerSuccess && upperSuccess)
            {
                if (lowerLimit <= upperLimit - 5)
                {
                    UpperLimit = upperLimit;
                    LowerLimit = lowerLimit;
                    Game.UpperLimit = this.UpperLimit;
                    Game.LowerLimit = this.LowerLimit;
                    if (GameForm.isGameStarted == true)
                    {
                        GameForm.txtLowerLimit.Text = this.LowerLimit.ToString();
                        GameForm.txtUpperLimit.Text = this.UpperLimit.ToString();
                    }
                    Game.GenerateNewSecretNumber();
                }
                else
                {
                    MessageBox.Show(
                        string.Format("The values you have entered are not within the minimum distance. Please try again." +
                        " The limits have not been changed."));
                }
            }

            else
            {
                MessageBox.Show(string.Format("One of the values you entered is invalid."));
            }

            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
