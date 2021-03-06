using Negosud_Client.Models;
using System;
using System.Windows.Forms;

namespace Negosud_Client.Controls
{
    public partial class ClientsInfo : UserControl
    {
        public ClientsInfo()
        {
            InitializeComponent();

        }

        private async void updateList()
        {
            if (Program.FilterValue.ClientsId != "")
            {
                Client clients = new Client();
                clients = await Client.GetOneClientAsync(int.Parse(Program.FilterValue.ClientsId));
                TBCity.Text = clients.City;
                TBCP.Text = clients.PostalCode;
                TBRue.Text = clients.StreetAddress;
                TBMail.Text = clients.Email;
                TBSurname.Text = clients.LastName;
                TBTelephone.Text = clients.Phone;
                TBName.Text = clients.FirstName;
            }
        }

        private async void BTNVal_Click(object sender, EventArgs e)
        {
            if (Program.FilterValue.ClientsId == "" || Program.FilterValue.ClientsId == null)
            {
                Client client = new Client();
                client.FirstName = TBName.Text;
                client.LastName = TBSurname.Text;
                client.City = TBCity.Text;
                client.PostalCode = TBCP.Text;
                client.StreetAddress = TBRue.Text;
                client.Email = TBMail.Text;
                client.Phone = TBTelephone.Text;
                bool valider = await Client.CreateClientAsync(client);

                if (valider) { MessageBox.Show("Entré validé avec succés"); }
                else if (!valider) { MessageBox.Show("Modification refusé vérifiez les champs"); }
            }
            else
            {
                Client client = new Client();
                client.FirstName = TBName.Text;
                client.LastName = TBSurname.Text;
                client.City = TBCity.Text;
                client.PostalCode = TBCP.Text;
                client.StreetAddress = TBRue.Text;
                client.Email = TBMail.Text;
                client.Phone = TBTelephone.Text;
                bool valider = await Client.UpdateClientAsync(client);

                if (valider) { MessageBox.Show("Modification validé avec succés"); }
                else if (!valider) { MessageBox.Show("Modification refusé vérifiez les champs"); }
            }
        }

        private void ClientsInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.FilterValue.ClientsId != null)
            {
                updateList();
                
            }
        }
    }
}
