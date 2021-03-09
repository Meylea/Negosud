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
    public partial class Client : UserControl
    {
        public Client()
        {
            InitializeComponent();
        }

        private void GVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GVCustomer.Columns[e.ColumnIndex].Name == "")
            {

            }
            if (GVCustomer.Columns[e.ColumnIndex].Name == "")
            {

            }
            if (GVCustomer.Columns[e.ColumnIndex].Name == "")
            {

            }
        }
    }
}
