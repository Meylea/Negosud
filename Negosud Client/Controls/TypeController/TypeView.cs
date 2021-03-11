using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negosud_Client.Controls.TypeController
{
    public partial class TypeView : UserControl
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public TypeView()
        {
            InitializeComponent();
        }

        private void GVType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = GVType.Rows[e.RowIndex].Cells[0].Value;

            if (clickBtn != null)
            {
                    //DeletedRow(value.ToString());
            }
        }
    }
}
