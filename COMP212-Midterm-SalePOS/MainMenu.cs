﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMP212_Midterm_SalePOS
{
    /// <summary>
    /// This class defines the main menu (POS).
    /// </summary>
    public partial class MainMenu : Form
    {
        // PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public ConnectionClass Connection { get; set; }
        public string Username { get; set; }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public MainMenu()
        {
            Connection = new ConnectionClass();
            InitializeComponent();
        }

        // EVENT HANDLERS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This handler opens the about box.
        /// </summary>
        private void AboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.Show();
        }

        /// <summary>
        /// This handler opens the customer form.
        /// </summary>
        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.customerForm.Show();
        }

        /// <summary>
        /// This handler sends the user back to the login form.
        /// </summary>
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.loginForm.Show();
        }

        /// <summary>
        /// This handler updates the status bar with the selected window.
        /// </summary>
        private void MainMenu_Activated(object sender, EventArgs e)
        {
            CurrentFormToolStripStatusLabel.Text = "Main Menu";
        }

        /// <summary>
        /// This handler closes the application when the form is closed.
        /// </summary>
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This handler opens the management form when the management button is clicked.
        /// </summary>
        private void ManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.managementForm.Show();
        }

        /// <summary>
        /// This handler refreshes the product menu.
        /// </summary>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DataTable dt = Connection.QueryDatabase("select * from Product");
            foreach (DataRow row in dt.Rows)
            {
                PictureBox pic = new PictureBox();
                // memory stream will let Image object ready the byte array as a stream to construct image
                MemoryStream ms;
                pic.Name = string.Format(row[1].ToString() + "PictureBox");
                pic.Size = new Size(100, 100);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                // get picture binary data
                byte[] imgBin = (byte[])row[9];
                ms = new MemoryStream(imgBin);
                pic.Image = Image.FromStream(ms);
                FoodFlowLayoutPanel.Controls.Add(pic);
                ms.Dispose();
            }
        }
    }
}
