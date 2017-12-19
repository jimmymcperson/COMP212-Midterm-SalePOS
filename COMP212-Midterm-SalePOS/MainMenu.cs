using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Midterm_POSSystem
{
    /// <summary>
    /// This class defines the main menu (POS).
    /// </summary>
    public partial class MainMenu : Form
    {
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        // METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This handler closes the application when the form is closed.
        /// </summary>
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
