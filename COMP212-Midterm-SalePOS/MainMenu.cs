using System;
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
        public DataRow CurrentRow { get; set; }
        public string Username { get; set; }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public MainMenu()
        {
            Connection = new ConnectionClass();
            CurrentRow = null;
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
        /// This handler adds the product to the cart.
        /// </summary>
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (CurrentRow != null)
            {
                CartDataGridView.Rows.Add(CurrentRow[0], CurrentRow[1], 1, CurrentRow[4]);
            }
        }

        /// <summary>
        /// This handler clears all items from the cart.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CartDataGridView.Rows.Clear();
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
        /// This handler refreshes the menu on load.
        /// </summary>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            int BillNoQueryResult;
            RefreshMenu("select * from Product where Category = 'Food'", FoodFlowLayoutPanel);
            RefreshMenu("select * from Product where Category = 'Drink'", DrinkFlowLayoutPanel);
            RefreshMenu("select * from Product where Category = 'Movie'", MovieFlowLayoutPanel);
            BillNoQueryResult = (Connection.QueryDatabase("select MAX(OrderID) from [Order]").Rows[0].Field<int>(0)) + 1;
            BillNoTextBox.Text = BillNoQueryResult.ToString();
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
            FoodFlowLayoutPanel.Controls.Clear();
            DrinkFlowLayoutPanel.Controls.Clear();
            MovieFlowLayoutPanel.Controls.Clear();
            RefreshMenu("select * from Product where Category = 'Food'", FoodFlowLayoutPanel);
            RefreshMenu("select * from Product where Category = 'Drink'", DrinkFlowLayoutPanel);
            RefreshMenu("select * from Product where Category = 'Movie'", MovieFlowLayoutPanel);
        }

        /// <summary>
        /// This handler removes items from the cart.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CartDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in CartDataGridView.SelectedRows)
                {
                    CartDataGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        /// <summary>
        /// This handler updates the menu based on search text.
        /// </summary>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FoodFlowLayoutPanel.Controls.Clear();
            DrinkFlowLayoutPanel.Controls.Clear();
            MovieFlowLayoutPanel.Controls.Clear();
            RefreshMenu(string.Format("select * from Product where Category = 'Food' and ProductName like '{0}%'", SearchTextBox.Text), FoodFlowLayoutPanel);
            RefreshMenu(string.Format("select * from Product where Category = 'Drink' and ProductName like '{0}%'", SearchTextBox.Text), FoodFlowLayoutPanel);
            RefreshMenu(string.Format("select * from Product where Category = 'Movie' and ProductName like '{0}%'", SearchTextBox.Text), FoodFlowLayoutPanel);
        }

        // METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This method refreshes the product menus.
        /// </summary>
        private void RefreshMenu(string query, FlowLayoutPanel tab)
        {
            DataTable dt = Connection.QueryDatabase(query);
            foreach (DataRow row in dt.Rows)
            {
                PictureBox pic = new PictureBox();
                // memory stream will let Image object ready the byte array as a stream to construct image
                MemoryStream ms;

                // define picture box
                pic.Name = string.Format(row[1].ToString() + "PictureBox");
                pic.Size = new Size(100, 100);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                // get picture binary data to define image property
                byte[] imgBin = (byte[])row[9];
                ms = new MemoryStream(imgBin);
                pic.Image = Image.FromStream(ms);

                // create handler for image click event
                void pic_Click(object sender, EventArgs e)
                {
                    CurrentRow = row;
                    DescriptionTextBox.Text = (string)row[8];
                }
                pic.Click += pic_Click;

                // add picturebox to the menu
                tab.Controls.Add(pic);
                ms.Dispose();
            }
        }
    }
}
