using Negosud_Client.Models;
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
        public delegate void DelegateClickBtn(string button);
        public event DelegateClickBtn ClickBtn;
        public SaleDetail()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void UpdateList()
        {

            StatutCommande.Text = Program.ClientCommandValue.ClientCommandValueStatus;
            DateCommande.Text = Program.ClientCommandValue.ClientCommandValueDate;
            IdCommande.Text = Program.ClientCommandValue.ClientCommandValueId;
            ClientNom.Text = Program.ClientCommandValue.ClientCommandValueName;
            dataGridView1.DataSource = await ClientCommandLine.GetClientCommandLinesAsync();
            Program.ClientCommandValue.ClientCommandValueStatus = "";
            Program.ClientCommandValue.ClientCommandValueDate = "";
            Program.ClientCommandValue.ClientCommandValueId = "";
            Program.ClientCommandValue.ClientCommandValueName = "";
        }

        private void btnsupprimerVente_Click(object sender, EventArgs e)
        {

        }

        private void IdCommande_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaleDetail_VisibleChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (clickBtn != null)
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Supprimer")
                {
                    DeletedRow(value.ToString());
                }


            }
        }*/
    }
}
