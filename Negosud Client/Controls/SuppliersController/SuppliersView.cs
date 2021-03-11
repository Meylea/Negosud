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
    public partial class SuppliersView : UserControl
    {

        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public SuppliersView()
        {
            InitializeComponent();
            updateList();
        }

        private async void updateList()
        {
            GVSuppliers.DataSource = await Supplier.GetSuppliersAsync();
        }

        private async void updateList(string searchElement)
        {
            //GVSuppliers.DataSource = await Supplier.UpdateSupplierAsync(searchElement);
        }


        private void DeletedRow(string idUser)
        {
            Supplier.DeleteSupplierAsync(idUser);
            updateList();
        }

        private void BTNAddSuppliers_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn("CreateSuppliers");
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            //updateList(TBSearchSuppliers.Text);
        }

        private void SuppliersView_Load(object sender, EventArgs e)
        {

        }

        private void SuppliersView_VisibleChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void GVSuppliers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (clickBtn != null)
            {
                object value = GVSuppliers.Rows[e.RowIndex].Cells[0].Value;
                Program.FilterValue.SuppliersId = value.ToString();
                if (GVSuppliers.Columns[e.ColumnIndex].HeaderText != "Supprimer")
                {
                    
                    clickBtn(GVSuppliers.Columns[e.ColumnIndex].HeaderText);
                }
                else
                {
                    DeletedRow(value.ToString());
                }
            }
        }
    }
}
