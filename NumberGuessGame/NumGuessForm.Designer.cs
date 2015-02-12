namespace NumberGuessGame
{
    partial class NumGuessForm
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
            this.lblUpperLimit = new System.Windows.Forms.Label();
            this.lblLowerLimit = new System.Windows.Forms.Label();
            this.txtUpperLimit = new System.Windows.Forms.TextBox();
            this.txtLowerLimit = new System.Windows.Forms.TextBox();
            this.lblUserGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.btnSubmitGuess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpperLimit
            // 
            this.lblUpperLimit.AutoSize = true;
            this.lblUpperLimit.Location = new System.Drawing.Point(5, 19);
            this.lblUpperLimit.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblUpperLimit.Name = "lblUpperLimit";
            this.lblUpperLimit.Size = new System.Drawing.Size(209, 35);
            this.lblUpperLimit.TabIndex = 1;
            this.lblUpperLimit.Text = "Upper Limit:";
            // 
            // lblLowerLimit
            // 
            this.lblLowerLimit.AutoSize = true;
            this.lblLowerLimit.Location = new System.Drawing.Point(4, 99);
            this.lblLowerLimit.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblLowerLimit.Name = "lblLowerLimit";
            this.lblLowerLimit.Size = new System.Drawing.Size(210, 35);
            this.lblLowerLimit.TabIndex = 2;
            this.lblLowerLimit.Text = "Lower Limit:";
            // 
            // txtUpperLimit
            // 
            this.txtUpperLimit.Location = new System.Drawing.Point(238, 19);
            this.txtUpperLimit.Name = "txtUpperLimit";
            this.txtUpperLimit.ReadOnly = true;
            this.txtUpperLimit.Size = new System.Drawing.Size(100, 43);
            this.txtUpperLimit.TabIndex = 3;
            // 
            // txtLowerLimit
            // 
            this.txtLowerLimit.Location = new System.Drawing.Point(238, 99);
            this.txtLowerLimit.Name = "txtLowerLimit";
            this.txtLowerLimit.ReadOnly = true;
            this.txtLowerLimit.Size = new System.Drawing.Size(100, 43);
            this.txtLowerLimit.TabIndex = 4;
            // 
            // lblUserGuess
            // 
            this.lblUserGuess.AutoSize = true;
            this.lblUserGuess.Location = new System.Drawing.Point(5, 171);
            this.lblUserGuess.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblUserGuess.Name = "lblUserGuess";
            this.lblUserGuess.Size = new System.Drawing.Size(202, 35);
            this.lblUserGuess.TabIndex = 5;
            this.lblUserGuess.Text = "Your Guess:";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(238, 163);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 43);
            this.txtGuess.TabIndex = 6;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(12, 407);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(833, 81);
            this.btnStartGame.TabIndex = 7;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnEndGame
            // 
            this.btnEndGame.Enabled = false;
            this.btnEndGame.Location = new System.Drawing.Point(12, 494);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(833, 81);
            this.btnEndGame.TabIndex = 8;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // btnSubmitGuess
            // 
            this.btnSubmitGuess.Location = new System.Drawing.Point(366, 19);
            this.btnSubmitGuess.Name = "btnSubmitGuess";
            this.btnSubmitGuess.Size = new System.Drawing.Size(449, 195);
            this.btnSubmitGuess.TabIndex = 9;
            this.btnSubmitGuess.Text = "Submit Guess";
            this.btnSubmitGuess.UseVisualStyleBackColor = true;
            this.btnSubmitGuess.Click += new System.EventHandler(this.btnSubmitGuess_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.lblUserGuess);
            this.panel1.Controls.Add(this.lblLowerLimit);
            this.panel1.Controls.Add(this.lblUpperLimit);
            this.panel1.Controls.Add(this.btnSubmitGuess);
            this.panel1.Controls.Add(this.txtGuess);
            this.panel1.Controls.Add(this.txtLowerLimit);
            this.panel1.Controls.Add(this.txtUpperLimit);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 305);
            this.panel1.TabIndex = 10;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(11, 251);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(259, 35);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Temporary Text";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setLimitsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // setLimitsToolStripMenuItem
            // 
            this.setLimitsToolStripMenuItem.Name = "setLimitsToolStripMenuItem";
            this.setLimitsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.setLimitsToolStripMenuItem.Text = "Set Limits";
            this.setLimitsToolStripMenuItem.Click += new System.EventHandler(this.OnSetLimit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.Name = "Form1";
            this.Text = "Number Guessing Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpperLimit;
        private System.Windows.Forms.Label lblLowerLimit;
        public System.Windows.Forms.TextBox txtUpperLimit;
        public System.Windows.Forms.TextBox txtLowerLimit;
        private System.Windows.Forms.Label lblUserGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Button btnSubmitGuess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLimitsToolStripMenuItem;
    }
}

