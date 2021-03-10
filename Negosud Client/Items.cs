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
        public Items()
        {
            InitializeComponent();
            UpdateList();
        }

        public async void UpdateList()
        {
            ItemsView.DataSource = await Item.GetItemsAsync();
        }
    }
}
