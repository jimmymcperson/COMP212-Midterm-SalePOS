using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP212_Midterm_SalePOS
{
    /// <summary>
    /// This class defines a set of controls for managing customer information.
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        // PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public ConnectionClass Connection { get; set; }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public UserControl1()
        {
            Connection = new ConnectionClass();
            InitializeComponent();
        }

        // EVENT HANDLERS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This handler adds a customer to the database.
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (NoEmptyFields())
            {
                Connection.AddRow(int.Parse(CustomerIDTextBox.Text), CompanyNameTextBox.Text, ContactNameTextBox.Text, ContactTitleTextBox.Text, AddressTextBox.Text, CityTextBox.Text, RegionTextBox.Text, PostalCodeTextBox.Text, CountryTextBox.Text, PhoneTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please fill out all the fields.", "Error");
            }
        }

        // METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This method checks that the required fields for row insertion are not empty.
        /// </summary>
        private bool NoEmptyFields()
        {
            bool result = true;
            result &= !CustomerIDTextBox.Text.Equals("");
            result &= !CompanyNameTextBox.Text.Equals("");
            result &= !ContactNameTextBox.Text.Equals("");
            result &= !ContactTitleTextBox.Text.Equals("");
            result &= !AddressTextBox.Text.Equals("");
            result &= !CityTextBox.Text.Equals("");
            result &= !RegionTextBox.Text.Equals("");
            result &= !PostalCodeTextBox.Text.Equals("");
            result &= !CountryTextBox.Text.Equals("");
            result &= !PhoneTextBox.Text.Equals("");
            return result;
        }

        /// <summary>
        /// This handler clears as all the text in the form.
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CustomerIDTextBox.Text = "";
            CompanyNameTextBox.Text = "";
            ContactNameTextBox.Text = "";
            ContactTitleTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            RegionTextBox.Text = "";
            PostalCodeTextBox.Text = "";
            CountryTextBox.Text = "";
            PhoneTextBox.Text = "";

        }
    }
}
