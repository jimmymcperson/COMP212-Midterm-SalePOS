using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace COMP212_Midterm_SalePOS
{
    /// <summary>
    /// This class defines a form for managing the menu.
    /// </summary>
    public partial class ManagementForm : Form
    {
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public ManagementForm()
        {
            InitializeComponent();
        }

        // METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This handler clears data from search criteria controls.
        /// </summary>
        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            SearchByComboBox.SelectedIndex = -1;
            SearchTextBox.Text = "";
        }

        /// <summary>
        /// This handler hides the form and shows the main menu when the form is "closed".
        /// </summary>
        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                Program.mainMenu.Show();
            }
        }

        /// <summary>
        /// This handler updates form values when form is opened.
        /// </summary>
        private void ManagementForm_Shown(object sender, System.EventArgs e)
        {
            // display user
            UserTextBox.Text = Program.loginForm.UsernameTextBox.Text;
            // fill data table
            this.productTableAdapter.Fill(this.database1DataSet.Product);

            // connect to db, query distinct categories, open connection, execute query into reader
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database1.mdb");
            OleDbCommand cmd = new OleDbCommand("select distinct Category from Product", con);

            try
            {
                con.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();
                // populate combobox with categories
                foreach (var row in rdr)
                {
                    CategoryComboBox.Items.Add(rdr.GetString(0));
                    SearchByComboBox.Items.Add(rdr.GetString(0));
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Something bad happened.", "Error");
                throw;
            }
            finally
            {
                con.Close();
            }

        }

        /// <summary>
        /// This handler queries the database for entries that fit the search criteria.
        /// </summary>
        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            // connect to db
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database1.mdb");
            OleDbCommand cmd;

            // this if-else tree sets queries depending on which search criterion fields are filled/empty
            if (SearchByComboBox.SelectedItem == null && SearchTextBox.Text.Equals(""))
            {
                cmd = new OleDbCommand("select * from Product", con);
            }
            else if (SearchByComboBox.SelectedItem == null)
            {
                string searchEntry = SearchTextBox.Text;
                cmd = new OleDbCommand("select * from Product where ProductName = '" + searchEntry +"'", con);
            }
            else if (SearchByComboBox.SelectedItem != null && SearchTextBox.Text.Equals(""))
            {
                string searchByEntry = SearchByComboBox.SelectedItem.ToString();
                cmd = new OleDbCommand("select * from Product where Category = '" + searchByEntry + "'", con);
            }
            else
            {
                string searchEntry = SearchTextBox.Text;
                string searchByEntry = SearchByComboBox.SelectedItem.ToString();
                cmd = new OleDbCommand("select * from Product where ProductName = '" + searchEntry + "' and Category = '" + searchByEntry + "'", con);
            }

            // display query on the table
            try
            {
                con.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                ProductsDataGridView.DataSource = dt;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Something bad happened.", "Error");
                throw;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
