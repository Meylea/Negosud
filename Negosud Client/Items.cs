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

namespace Negosud_Client
{
    public partial class Items : UserControl
    {
        public delegate void DelegateClickBtn(string button);
        public event DelegateClickBtn ClickBtn;

        public Items()
        {
            InitializeComponent();
            UpdateList();
        }

        public async void UpdateList()
        {
           // ItemsView.DataSource = await Item.GetItemsAsync();
        }

        private void ItemsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != ItemsView.Columns["Edit"].Index) return;
            if (ClickBtn != null)
            {
                ClickBtn("Edit");
                Program.itemId = int.Parse(ItemsView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void createItem_Click(object sender, EventArgs e)
        {
            if (ClickBtn != null)
            {
                ClickBtn(((Button)sender).Name);
            }
        }
    }
}
