using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negosud_Client.Models;

namespace Negosud_Client.Controls.SuppliersController
{
    public partial class SuppliersAddUpdate : UserControl
    {
        public SuppliersAddUpdate()
        {
            InitializeComponent();
        }

        private async void updateList()
        {
            if (Program.FilterValue.SuppliersId != "")
            {
                Supplier suppliers = new Supplier();
                //clients = await Client.GetOneClientsAsync(Program.FilterValue.ClientsId);
                TBCity.Text = suppliers.City;
                TBBusinessName.Text = suppliers.ContactFirstName;
                TBContactFirstName.Text = suppliers.StreetAddress;
                TBContactLastName.Text = suppliers.ContactLastName;
                TBContactMail.Text = suppliers.ContactMail;
                TBContactPhone.Text = suppliers.ContactPhone;
                TBStreetAddress.Text = suppliers.StreetAddress;
                TBPostCode.Text = suppliers.PostCode;
            }
        }

        private async void BTNVal_Click(object sender, EventArgs e)
        {
            if (Program.FilterValue.SuppliersId == "" || Program.FilterValue.SuppliersId == null)
            {
                Supplier suppliers = new Supplier();
                suppliers.PostCode = TBPostCode.Text;
                suppliers.StreetAddress = TBStreetAddress.Text;
                suppliers.ContactPhone = TBContactPhone.Text;
                suppliers.ContactMail= TBContactMail.Text;
                suppliers.ContactLastName = TBContactLastName.Text;
                suppliers.StreetAddress = TBStreetAddress.Text;
                suppliers.ContactFirstName = TBContactFirstName.Text;
                suppliers.City = TBCity.Text;
                bool valider = await Supplier.CreateSupplierAsync(suppliers);

                if (valider) { MessageBox.Show("Entré validé avec succés"); }
                else if (!valider) { MessageBox.Show("Modification refusé vérifiez les champs"); }
            }
            else
            {
                Client client = new Client();
                client.FirstName = TBContactFirstName.Text;
                client.LastName = TBContactLastName.Text;
                client.City = TBCity.Text;
                client.PostalCode = TBPostCode.Text;
                client.StreetAddress = TBStreetAddress.Text;
                client.Email = TBContactMail.Text;
                client.Phone = TBContactPhone.Text;
                bool valider = await Client.UpdateClientAsync(client);

                if (valider) { MessageBox.Show("Modification validé avec succés"); }
                else if (!valider) { MessageBox.Show("Modification refusé vérifiez les champs"); }
            }
        }

        private void ClientsInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.FilterValue.SuppliersId != null)
            {
                updateList();

            }
        }
    }
}
