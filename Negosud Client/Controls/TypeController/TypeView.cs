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


                Models.Type.DeleteTypeAsync(value.ToString());
                updateList();
            
        }

        private async void BtnAjouterType_Click(object sender, EventArgs e)
        {
                Models.Type types = new Models.Type();
                types.Name = TBAddType.Text;

                bool valider = await Models.Type.CreateTypeAsync(types);

            if (valider) { MessageBox.Show("Modification validé avec succés"); }
                else if (!valider) { MessageBox.Show("Modification refusé vérifiez les champs"); }
            }

        private void TypeView_VisibleChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private async void updateList()
        {
            GVType.DataSource = await Models.Type.GetTypesAsync();
        }
    }
}

