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
        public delegate void DelegateClickBtn(string button);
        public event DelegateClickBtn ClickBtn;

        public ClientCommand clientCommand;
        
        public CreateCmd()
        {
            InitializeComponent();
            InitializeSelectBoxes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public async void InitializeSelectBoxes()
        {
            CBClient.DataSource = await Client.GetClientsAsync();
            CBClient.DisplayMember = "LastName";
            CBClient.ValueMember = "Id";

            ItemBox.DataSource = await Item.GetItemsAsync();
            ItemBox.DisplayMember = "Name";
            ItemBox.ValueMember = "Id";

        }

        private async void AddLineBtn_Click(object sender, EventArgs e)
        {
            ClientCommandLine clientCommandLine = new ClientCommandLine();

            clientCommandLine.ItemId = int.Parse(ItemBox.SelectedValue.ToString());
            Item item = await Item.GetOneItemAsync(clientCommandLine.ItemId);

            clientCommandLine.ItemName = item.Name + " " + item.Year;
            if (int.TryParse(TextQte.Text, out int result))
            {
                clientCommandLine.Quantity = result;
            }
            else
            {
                string message = "La quantité doit être un nombre entier.";
            }

            
            if (clientCommandLine.Quantity >= 6)
            {
                clientCommandLine.UnitPrice = item.BoxPrice;
            }
            else
            {
                clientCommandLine.UnitPrice = item.UnitPrice;
            }
            clientCommandLine.TotalPrice = clientCommandLine.UnitPrice * clientCommandLine.Quantity;

            if (clientCommand.ClientCommandLines == null) clientCommand.ClientCommandLines = new List<ClientCommandLine>();
            clientCommand.ClientCommandLines.Add(clientCommandLine);
            dataGridView1.DataSource = clientCommand.ClientCommandLines;
            ItemBox.Text = String.Empty;
            TextQte.Text = String.Empty;
        }

        private void CreateCmd_VisibleChanged(object sender, EventArgs e)
        {
            if (((CreateCmd)sender).Visible)
            {
                clientCommand = new ClientCommand();
            }
        }

        private async void ValidateBtn_Click(object sender, EventArgs e)
        {
            clientCommand.ClientId = int.Parse(CBClient.SelectedValue.ToString());
            clientCommand.Date = DateTime.Now;
            clientCommand.Status = "En cours";
            bool success = await ClientCommand.CreateClientCommandAsync(clientCommand);

            foreach (ClientCommandLine clientCommandLine in clientCommand.ClientCommandLines)
            {
                bool successLine = await ClientCommandLine.CreateClientCommandLineAsync(clientCommandLine);
            }
            ClickBtn(((Button)sender).Name);
        }
    }
}
