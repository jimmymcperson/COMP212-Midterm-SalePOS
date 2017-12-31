using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

///
/// ==================================================================================================
/// App Name: POS System
/// Author: Jonathan Hao
/// Student#: 300869273
/// Date Created: December 18, 2017
/// Description: This app is a POS system for catering services.
/// Version: 0.0.4 - Updated ManagementForm.cs. Bound data to category.  Added some functionality to search.
/// TODO 
/// ==================================================================================================
/// 

namespace COMP212_Midterm_SalePOS
{
    /// <summary>
    /// This is the driver class of the program.
    /// </summary>
    static class Program
    {
        // Declaring form variables to initialize in main method
        public static LoginForm loginForm;
        public static MainMenu mainMenu;
        public static ManagementForm managementForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        /// <summary>
        /// This is the main method.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new LoginForm();
            mainMenu = new MainMenu();
            managementForm = new ManagementForm();
            Application.Run(loginForm);
        }
    }
}
