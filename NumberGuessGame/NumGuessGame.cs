using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NumberGuessGame
{
    static class NumGuessGame
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NumGuessForm());
        }
    }
}
