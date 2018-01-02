using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Midterm_SalePOS
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This handler hides the form and shows the main menu when the form is "closed".
        /// </summary>
        private void AboutBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Program.mainMenu.Show();
            }
        }

        /// <summary>
        /// This handler hides the form and shows the main menu when the user clicks "ok".
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mainMenu.Show();
        }
    }
}
