using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negosud_Client;
using Negosud_Client.Models; 
namespace Negosud_Client
{
    public partial class ClientsView : UserControl
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public ClientsView()
        {
            InitializeComponent();
            updateList();
        }

        private async void updateList()
        {
            GVCustomer.DataSource = await Client.GetClientsAsync();
        }

        private async void searchList(string searchElement)
        {
            GVCustomer.DataSource = await Client.GetClientsByDataAsync(searchElement);
        }

        private void GVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clickBtn != null)
            {
                object value = GVCustomer.Rows[e.RowIndex].Cells[0].Value;
                
                if(GVCustomer.Columns[e.ColumnIndex].HeaderText != "Supprimer")
                {
                    Program.FilterValue.ClientsId = value.ToString();
                    clickBtn(GVCustomer.Columns[e.ColumnIndex].HeaderText);
                }
                else
                {
                    DeletedRow(value.ToString());
                }
            }
        }

        private void DeletedRow(string idUser)
        {
                Client.DeleteClientAsync(idUser);
                updateList();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn("CreateClient");
            }
        }

        private void ClientsView_VisibleChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            searchList(TBSearchCustomer.Text);
        }
    }
}
