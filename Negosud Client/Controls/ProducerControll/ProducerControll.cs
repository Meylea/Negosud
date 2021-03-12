using System;
using System.Windows.Forms;
using Negosud_Client.Models;

namespace Negosud_Client.Controls
{
    public partial class ProducerUC : UserControl
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public ProducerUC()
        {
            InitializeComponent();
            updateList();
        }

        private async void updateList()
        {
            GVProducers.DataSource = await Producer.GetProducersAsync();
        }


        private async void BtnCustomer_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer();
            producer.Name = TBProducer.Text;
            await Producer.CreateProducerAsync(producer);
            updateList();
        }

        private async void GVProducers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clickBtn != null)
            {
                object value = GVProducers.Rows[e.RowIndex].Cells[0].Value;

                if (GVProducers.Columns[e.ColumnIndex].HeaderText == "Modifier")
                {
                    object NewValue = GVProducers.Rows[e.RowIndex].Cells[3].Value;
                    Producer ProducerToUpdate= await Producer.GetOneProducerAsync(Int32.Parse(value.ToString()));
                    ProducerToUpdate.Name = NewValue.ToString();
                    await Producer.UpdateProducerAsync(ProducerToUpdate,value.ToString());
                }
                else
                {
                    DeletedRow(value.ToString());
                }
                updateList();
            }
        }

        private void DeletedRow(string idProducer)
        {
            Producer.DeleteRowAsync(idProducer);
            updateList();
        }

        private void ProducerUC_VisibleChanged(object sender, EventArgs e)
        {
            updateList();
        }
    }
}
