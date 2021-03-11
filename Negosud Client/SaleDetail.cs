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
    public partial class SaleDetail : UserControl
    {
        public SaleDetail()
        {
            InitializeComponent();
            UpdateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void UpdateList()
        {
            dataGridView1.DataSource = await Item.GetItemsAsync();
        }

       
    }
}
