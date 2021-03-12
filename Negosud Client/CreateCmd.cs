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
    public partial class CreateCmd : UserControl
    {
        public CreateCmd()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public async void InitializeSelectBoxes()
        {
            CBClient.DataSource = await Client.GetClientsAsync();
            CBClient.DisplayMember = "LastName"/* + "FirstName"*/;
            CBClient.ValueMember = "Id";            

            if (Program.itemId != null)
            {
                Client client = await Client.GetOneClientAsync(Program.clientId ?? default);
                CBClient.SelectedValue = client.LastName;
/*                typeBox.SelectedValue = item.TypeId;
                yearBox.Text = item.Year;
                producerBox.SelectedValue = item.ProducerId;
                supplierBox.SelectedValue = item.SupplierId;
                quantityBox.Text = item.Quantity.ToString();
                unitPriceBox.Text = item.UnitPrice.ToString();
                boxPriceBox.Text = item.BoxPrice.ToString();
                imageBox.Text = item.ImgUrl;*/
            }
        }


    }
}
