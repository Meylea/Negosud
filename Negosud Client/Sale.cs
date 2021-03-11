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
    public partial class Sale : UserControl
    {
        public delegate void DelegateClickBtn(string button);
        public event DelegateClickBtn ClickBtn;
        public Sale()
        {
            InitializeComponent();
            updateList();
        }

        private async void updateList()
        {
            dataGridView1.DataSource = await ClientCommand.GetClientCommandsAsync();
        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        
        private async void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await ClientCommand.GetClientCommandsAsync();
        }

        private void CréerVente_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnRechercheVente_Click(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(RechercheVente.Text, out int recherche);

            if (success)
            {
                
                dataGridView1.DataSource = await ClientCommand.GetOneClientCommandAsync(recherche);
                RechercheVente.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClickBtn != null)
            {
                ClickBtn(dataGridView1.Columns[e.ColumnIndex].HeaderText);
            }
        }
    }
    
}
