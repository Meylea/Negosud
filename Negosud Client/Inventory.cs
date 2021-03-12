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

        private async void Validate_Click(object sender, EventArgs e)
        {
            string message = "Les champs ont été modifiés avec succès";
            foreach(DataGridViewRow row in InventoryView.Rows)
            {
                int id = int.Parse(row.Cells[0].Value.ToString());
                if (row.Cells[6].Value != null)
                {
                    string value = row.Cells[6].Value.ToString();
                    if (int.TryParse(value, out int result))
                    {
                        Item item = await Item.GetOneItemAsync(id);
                        item.Quantity = result;
                        bool success = await Item.UpdateItemAsync(item);
                        if (!success) message = "Une erreur a été rencontrée lors de la mise à jour des champs";
                    }
                }
            }
            MessageLabel.Text = message;
            UpdateList();
        }
    }
}
