using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace COMP212_Midterm_SalePOS
{
    /// <summary>
    /// This class defines a connection to a database.
    /// </summary>
    public class ConnectionClass
    {
        // PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public DataTable dt { get; set; }
        public OleDbCommand cmd { get; set; }
        public OleDbCommandBuilder cb { get; set;}
        public OleDbConnection con { get; set;}
        public OleDbDataAdapter da { get; set; }
        public OleDbDataReader rdr { get; set; }
        
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This constructor builds the connection string and dataadapter.
        /// </summary>
        public ConnectionClass()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database1.mdb");
        }

        // METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This method adds a row to the database based on field inputs.
        /// </summary>
        public void AddRow(string productID, string productName, string category, string quantity, string purchasePrice, string salePrice, string insertedBy, string description)
        {
            // declare variables
            string picFileName = "";
            byte[] pic;
            DateTime currentDate = DateTime.Today;
            OleDbCommand cmd = new OleDbCommand();

            // get path to picture
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Picture";
            ofd.Filter = "JPG Files|*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picFileName = ofd.FileName;
            }

            // prepare picture for storing in db
            pic = File.ReadAllBytes(picFileName);

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Product (ProductID, ProductName, Category, Quantity, PurchasePrice, SalePrice, InsertedBy, InsertionDate, Description, [Image])"
            + " VALUES (@ProductID, @ProductName, @Category, @Quantity, @PurchasePrice, @SalePrice, @InsertedBy, @InsertionDate, @Description, @Picture)";
            cmd.Parameters.AddWithValue("@ProductID", productID);
            cmd.Parameters.AddWithValue("@ProductName", productName);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
            cmd.Parameters.AddWithValue("@SalePrice", salePrice);
            cmd.Parameters.AddWithValue("@InsertedBy", insertedBy);
            cmd.Parameters.AddWithValue("@InsertionDate", currentDate);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@Picture", pic);
            cmd.Connection = con;


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry added to the database.", "Success");
            }
            catch (Exception)
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
        /// This method adds a row to the database based on field inputs.
        /// </summary>
        public void AddRow(string customerID, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Customer (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone)"
            + " VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone)";
            cmd.Parameters.AddWithValue("@CustomerID", customerID);
            cmd.Parameters.AddWithValue("@CompanyName", companyName);
            cmd.Parameters.AddWithValue("@ContactName", contactName);
            cmd.Parameters.AddWithValue("@ContactTitle", contactTitle);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Region", region);
            cmd.Parameters.AddWithValue("@PostalCode", postalCode);
            cmd.Parameters.AddWithValue("@Country", country);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry added to the database.", "Success");
            }
            catch (Exception)
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
        /// This method commits changes to the database.
        /// </summary>
        public void CommitChanges(string statement, DataTable dt)
        {
            da = new OleDbDataAdapter(statement, con);
            cb = new OleDbCommandBuilder(da);
            try
            {
                da.Update(dt);
                MessageBox.Show("Your changes have been committed to the database.", "Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad happened.", "Error");
                throw;
            }
        }

        /// <summary>
        /// This method deletes a customer from the database.
        /// </summary>
        public void DeleteRecord(string customerID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Customer where CustomerID = " + customerID;
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer deleted", "Success");
            }
            catch (Exception)
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
        /// This method edits a record in the database.
        /// </summary>
        public void EditRecord(string customerID, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Customer set CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @Phone where CustomerID = " + customerID ;
            cmd.Parameters.AddWithValue("@CompanyName", companyName);
            cmd.Parameters.AddWithValue("@ContactName", contactName);
            cmd.Parameters.AddWithValue("@ContactTitle", contactTitle);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Region", region);
            cmd.Parameters.AddWithValue("@PostalCode", postalCode);
            cmd.Parameters.AddWithValue("@Country", country);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer edited.", "Success");
            }
            catch (Exception)
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
        /// This method queries the database and returns the results in a datatable object.
        /// </summary>
        public DataTable QueryDatabase(string query)
        {
            // build query string
            cmd = new OleDbCommand(query, con);

            // query
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(rdr);
                return dt;
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
