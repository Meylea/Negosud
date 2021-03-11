using Negosud_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negosud_Client.Controls
{
    public partial class ClientsInformation : UserControl
    {
        public ClientsInformation()
        {
            InitializeComponent();
        }

        /*private async void updateList()
        {
            if (Program.FilterValue.ClientsId != "")
            {
                Client clients = new Client();
                clients = await Client.GetOneClientsAsync(Program.FilterValue.ClientsId);
                NameUser.Text = clients.FirstName;
                SurnameUser.Text = clients.LastName;
                MailUser.Text = clients.Email;
                CityUser.Text = clients.City;
                PhoneUser.Text = clients.Phone;
                RueUser.Text = clients.StreetAddress;
                CPUser.Text = clients.PostalCode;
            }
        }*/

        private void ClientsInformation_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.FilterValue.ClientsId != null)
            {
                updateList();
            }
        }
    }
}
