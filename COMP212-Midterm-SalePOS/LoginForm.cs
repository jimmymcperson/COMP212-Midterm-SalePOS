using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace COMP212_Midterm_SalePOS
{
    /// <summary>
    /// This class defines a login form.
    /// </summary>
    public partial class LoginForm : Form
    {

        // PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public ConnectionClass Connection { get; set; }
        public int FailedLoginAttempts { get; set; }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public LoginForm()
        {
            Connection = new ConnectionClass();
            FailedLoginAttempts = 0;
            InitializeComponent();
        }

        // EVENT HANDLERS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This handler disables lockout after 3 minutes.
        /// </summary>
        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            LockoutTimer.Stop();
            LoginButton.Enabled = true;
        }

        /// <summary>
        /// This handler verifies login credentials and continues the program.
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (FailedLoginAttempts >= 3)
            {
                // begin lockout
                LoginButton.Enabled = false;
                LockoutTimer.Start();
                FailedLoginAttempts = 0;
                MessageBox.Show("Too many login attempts.  Try again in 3 minutes.", "Lockout");
            }
            else
            {
                if (Connection.QueryDatabase("select * from Account where Username = '" + UsernameTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'").Rows.Count > 0)
                {
                    FailedLoginAttempts = 0;
                    Program.mainMenu.Username = UsernameTextBox.Text;
                    UsernameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    this.Hide();
                    Program.mainMenu.Show();
                }
                else
                {
                    FailedLoginAttempts++;
                    MessageBox.Show("Incorrect login credentials.", "Login Failed");
                }
            }
        }

        /// <summary>
        /// This handler shows characters instead of asterix when checked.
        /// </summary>
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
