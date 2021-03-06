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
    public partial class SuppliersInfo : UserControl
    {
        public SuppliersInfo()
        {
            InitializeComponent();
        }

        private async void updateList()
        {
            if (Program.FilterValue.ClientsId != "")
            {
                Supplier suppliers = new Supplier();
                //clients = await Client.GetOneClientsAsync(Program.FilterValue.ClientsId);
                LBusinessName.Text = suppliers.BusinessName;
                LCity.Text = suppliers.City;
                LContactLastName.Text = suppliers.ContactLastName;
                LContactMail.Text = suppliers.ContactMail;
                LContactPhone.Text = suppliers.ContactPhone;
                LPostCode.Text = suppliers.PostCode;
                LStreetAddress.Text = suppliers.StreetAddress;
                LName.Text = suppliers.ContactFirstName;
            }
        }

        private void ClientsInformation_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.FilterValue.ClientsId != null)
            {
                updateList();
            }
        }
    }
}
