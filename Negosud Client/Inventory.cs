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
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
            // UpdateList();
        }

        public async void UpdateList()
        {
            InventoryView.DataSource = await Item.GetItemsAsync();
        }

        private void Inventory_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
