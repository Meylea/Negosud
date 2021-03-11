using System;
using System.Windows.Forms;
using Negosud_Client.Models;

namespace Negosud_Client.Controls
{
    public partial class ProducerControll : UserControl
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;


        public ProducerControll()
        {
            InitializeComponent();
            updateList();
        }

        private async void updateList()
        {
            GVProducers.DataSource = await Producer.GetProducersAsync();
        }


        private void BtnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void GVProducers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clickBtn != null)
            {
                object value = GVProducers.Rows[e.RowIndex].Cells[0].Value;

                if (GVProducers.Columns[e.ColumnIndex].HeaderText != "Supprimer")
                {
                    Program.FilterValue.ProducersId = value.ToString();
                    clickBtn(GVProducers.Columns[e.ColumnIndex].HeaderText);
                }
                else
                {
                    DeletedRow(value.ToString());
                }
            }
        }

        private void DeletedRow(string idProducer)
        {
            Producer.DeleteRowAsync(idProducer);
            updateList();
        }


    }
}
