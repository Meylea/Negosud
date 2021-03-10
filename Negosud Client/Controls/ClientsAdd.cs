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

namespace Negosud_Client
{
    public partial class ClientsInfo : UserControl
    {
        public ClientsInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsDTO client = new ClientsDTO();
            string errorMessage = null;
            client.FirstName = TBName.Text;
            client.LastName = TBSurname.Text;
            client.Phone = TBPhone.Text;
            client.Email = TBMail.Text;
            client.PostalCode = TBCP.Text;
            client.StreetAddress = TBAddress.Text;
            client.City = TBCity.Text;
            ClientsDTO.CreateProductAsync(client);
            MessageBox.Show("valider");
            
        }

        private void TBId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
