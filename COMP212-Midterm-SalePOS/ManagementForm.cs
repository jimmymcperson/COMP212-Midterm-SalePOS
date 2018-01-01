using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;

namespace COMP212_Midterm_SalePOS
{
    /// <summary>
    /// This class defines a form for managing the menu.
    /// </summary>
    public partial class ManagementForm : Form
    {
        // PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public ConnectionClass Connection { get; set; }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This constructor initializes the connection and builds the form.
        /// </summary>
        public ManagementForm()
        {
            Connection = new ConnectionClass();
            InitializeComponent();
        }

        // EVENT HANDLERS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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
            RefreshForm();
        }
        

        /// <summary>
        /// This handler refreshes the form.
        /// </summary>
        private void RefreshButton_Click(object sender, System.EventArgs e)
        {
            RefreshForm();
        }
        

        /// <summary>
        /// This hander queries the database based on Category.
        /// </summary>
        private void SearchCategoryComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SearchCategoryComboBox.SelectedIndex != -1)
            {
                SearchQuery("Category", SearchCategoryComboBox.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// This handler queries the database based on ProductID.
        /// </summary>
        private void SearchProductIDTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!SearchProductIDTextBox.Text.Equals(""))
            {
                SearchQuery("ProductID", int.Parse(SearchProductIDTextBox.Text));
            }
        }

        /// <summary>
        /// This handler queries the database based on ProductName.
        /// </summary>
        private void SearchProductNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (!SearchProductNameTextBox.Text.Equals(""))
            {
                SearchQuery("ProductName", SearchProductNameTextBox.Text);
            }
        }

        // METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        ///// <summary>
        ///// This method queries the database and returns the results in a datatable object.
        ///// </summary>
        //private DataTable QueryDatabase(string query)
        //{
        //    // connect to db
        //    OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database1.mdb");

        //    // build query string
        //    OleDbCommand cmd = new OleDbCommand(query, con);

        //    // query
        //    try
        //    {
        //        con.Open();
        //        OleDbDataReader rdr = cmd.ExecuteReader();
        //        DataTable dt = new DataTable();
        //        dt.Load(rdr);
        //        return dt;
        //    }
        //    catch (System.Exception)
        //    {
        //        MessageBox.Show("Something bad happened.", "Error");
        //        throw;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        /// <summary>
        /// This method refreshes datasource reliant elements.
        /// </summary>
        private void RefreshForm()
        {
            // clean search forms
            SearchProductIDTextBox.Text = "";
            SearchCategoryComboBox.SelectedIndex = -1;
            SearchProductNameTextBox.Text = "";

            // Clean combo boxes for population
            CategoryComboBox.Items.Clear();
            SearchCategoryComboBox.Items.Clear();

            // display user
            UserTextBox.Text = Program.loginForm.UsernameTextBox.Text;

            // display ID
            int idQueryResult = (Connection.QueryDatabase("select MAX(ProductID) from Product").Rows[0].Field<int>(0)) + 1;
            IDTextBox.Text = idQueryResult.ToString();

            // populate table
            ProductsDataGridView.DataSource = Connection.QueryDatabase("select * from Product");

            // connect to db, query distinct categories
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
                    SearchCategoryComboBox.Items.Add(rdr.GetString(0));
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
        /// This method queries the database for entries that fit the search criteria and displays it.
        /// </summary>
        private void SearchQuery(string SearchCriteria, int SearchCriteriaValue)
        {
            string searchQueryString = string.Format("select * from Product where {0} = {1}", SearchCriteria, SearchCriteriaValue);
            ProductsDataGridView.DataSource = Connection.QueryDatabase(searchQueryString);
        }

        /// <summary>
        /// This method queries the database for entries that fit the search criteria and displays it.
        /// </summary>
        private void SearchQuery(string SearchCriteria, string SearchCriteriaValue)
        {
            string searchQueryString = string.Format("select * from Product where {0} like '{1}%'", SearchCriteria, SearchCriteriaValue);
            ProductsDataGridView.DataSource = Connection.QueryDatabase(searchQueryString);
        }
    }
}
