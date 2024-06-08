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
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;
        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void SaveAddressButton_Click(object sender, EventArgs e)
        {
            var address = new AddressModel
            {
                StreetAddress = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                ZipCode = zipCodeTextBox.Text
            };
            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
