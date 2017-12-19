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

        public int FailedLoginAttempts { get; set; }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        // METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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
                try
                {
                    // connect to db, query username and pass, open connection, execute query into reader
                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database1.mdb");
                    OleDbCommand cmd = new OleDbCommand("select * from Accounts where Username = '" + UsernameTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'", con);
                    con.Open();
                    OleDbDataReader rdr = cmd.ExecuteReader();

                    // if username and password match, continue program
                    if (rdr.HasRows)
                    {
                        FailedLoginAttempts = 0;
                        this.Hide();
                        Program.mainMenu.Show();
                    }
                    else
                    {
                        FailedLoginAttempts++;
                        MessageBox.Show("Incorrect login credentials.", "Login Failed");
                    }

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something bad happened.", "Error");
                    throw;
                }
            }
        }

        /// <summary>
        /// This handler initializes properties on load.
        /// </summary>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            FailedLoginAttempts = 0;
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
