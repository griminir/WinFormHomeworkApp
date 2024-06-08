using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;
using DemoLibrary2._0;

namespace WinFormHomework
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> _addresses = new BindingList<AddressModel>();
        public PersonEntry()
        {
            InitializeComponent();

            AddressesList.DataSource = _addresses;
            AddressesList.DisplayMember = nameof(AddressModel.FullAddress);
        }

        private void AddNewAddressButton_Click(object sender, EventArgs e)
        {
            var entry = new AddressEntry(this);

            entry.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            _addresses.Add(address);
        }

        private void saveRecord_Click(object sender, EventArgs e)
        {
            var person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                IsActive = isActive.Checked,
                Addresses = _addresses.ToList()
            };
        }
    }
}
