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

        private async void ItemsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || ClickBtn == null) return;

            if (e.ColumnIndex == ItemsView.Columns["Edit"].Index)
            {
                ClickBtn("Edit");
                Program.itemId = int.Parse(ItemsView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            if (e.ColumnIndex == ItemsView.Columns["Delete"].Index)
            {
                bool success =  await Item.DeleteItemAsync(int.Parse(ItemsView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                if (success)
                {
                    UpdateList();
                }
            }

            if (e.ColumnIndex == ItemsView.Columns["Info"].Index)
            {
                Program.itemId = int.Parse(ItemsView.Rows[e.RowIndex].Cells[0].Value.ToString());
                ClickBtn("Info");
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (ClickBtn != null)
            {
                ClickBtn(((Button)sender).Name);
            }
        }

        private void Items_VisibleChanged(object sender, EventArgs e)
        {
            if (((Items)sender).Visible == true)
            {
                UpdateList();
            }
        }
    }
}
