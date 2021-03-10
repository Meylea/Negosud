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

        private void GVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(GVCustomer.Columns[e.ColumnIndex].HeaderText);
            }
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Name);
            }
        }

        private void ClientsView_VisibleChanged(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
