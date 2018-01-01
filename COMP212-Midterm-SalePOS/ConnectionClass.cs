using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

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
        /// This method commits changes to the database.
        /// </summary>
        public void CommitChanges(string statement, DataTable dt)
        {
            
            da = new OleDbDataAdapter(statement, con);
            cb = new OleDbCommandBuilder(da);
            try
            {
                da.Update(dt);
                MessageBox.Show("Your changes have been committed to the database.","Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Something bad happened.", "Error");
                throw;
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
