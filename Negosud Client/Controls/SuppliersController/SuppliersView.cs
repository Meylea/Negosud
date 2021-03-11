using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negosud_Client.Controls.SuppliersController
{
    public partial class SuppliersView : UserControl
    {

        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public SuppliersView()
        {
            InitializeComponent();
        }

        private async void updateList()
        {
            //GVCustomer.DataSource = await Client.GetClientsAsync();
        }

        private async void updateList(string searchElement)
        {
            //GVCustomer.DataSource = await Client.GetClientsAsync(searchElement);
        }

        private void GVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clickBtn != null)
            {
                object value = GVSuppliers.Rows[e.RowIndex].Cells[0].Value;

                if (GVSuppliers.Columns[e.ColumnIndex].HeaderText != "Supprimer")
                {
                    Program.FilterValue.ClientsId = value.ToString();
                    clickBtn(GVSuppliers.Columns[e.ColumnIndex].HeaderText);
                }
                else
                {
                    DeletedRow(value.ToString());
                }
            }
        }

        private void DeletedRow(string idUser)
        {
            //Client.DeleteRowAsync(idUser);
            updateList();
        }

        private void BTNAddSuppliers_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn("CreateSuppliers");
            }
        }

        private void ClientsView_VisibleChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            updateList(TBSearchSuppliers.Text);
        }
    }
}
