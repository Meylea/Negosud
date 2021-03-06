using System;
using System.Drawing;
using System.Windows.Forms;
using Negosud_Client.Models;

namespace Negosud_Client
{
    public partial class CreateItems : UserControl
    {
        public CreateItems()
        {
            InitializeComponent();
            InitializeSelectBoxes();
        }

        public async void InitializeSelectBoxes()
        {
            typeBox.DataSource = await Models.Type.GetTypesAsync();
            typeBox.DisplayMember = "Name";
            typeBox.ValueMember = "Id";

            producerBox.DataSource = await Producer.GetProducersAsync();
            producerBox.DisplayMember = "Name";
            producerBox.ValueMember = "Id";

            supplierBox.DataSource = await Supplier.GetSuppliersAsync();
            supplierBox.DisplayMember = "BusinessName";
            supplierBox.ValueMember = "Id";

            nameBox.Text = String.Empty;
            yearBox.Text = String.Empty;
            imageBox.Text = String.Empty;
            quantityBox.Text = String.Empty;
            unitPriceBox.Text = String.Empty;
            boxPriceBox.Text = String.Empty;

            if (Program.itemId != null)
            {
                Item item = await Item.GetOneItemAsync(Program.itemId ?? default);
                nameBox.Text = item.Name;
                typeBox.SelectedValue = item.TypeId;
                yearBox.Text = item.Year;
                producerBox.SelectedValue = item.ProducerId;
                supplierBox.SelectedValue = item.SupplierId;
                quantityBox.Text = item.Quantity.ToString();
                unitPriceBox.Text = item.UnitPrice.ToString();
                boxPriceBox.Text = item.BoxPrice.ToString();
                imageBox.Text = item.ImgUrl;
            }
        }

        private void QuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private async void add_Click(object sender, EventArgs e)
        {
            Item item  = new Item();
            string errorMessage = null;

            item.Name = nameBox.Text;
            item.TypeId = int.Parse(typeBox.SelectedValue.ToString());
            item.Year = yearBox.Text;
            item.ProducerId = int.Parse(producerBox.SelectedValue.ToString());
            item.SupplierId = int.Parse(supplierBox.SelectedValue.ToString());
            item.ImgUrl = imageBox.Text;

            if (int.TryParse(quantityBox.Text, out int quantityResult))
            {
                item.Quantity = quantityResult;
            } else errorMessage = "La quantité doit être un nombre entier.";

            if (double.TryParse(unitPriceBox.Text, out double unitPriceResult))
            {
                item.UnitPrice = unitPriceResult;
            } else errorMessage = "Le prix unitaire doit être un nombre entier ou décimal";

            if (double.TryParse(boxPriceBox.Text, out double boxPriceResult))
            {
                item.BoxPrice = boxPriceResult;
            } else errorMessage = "Le prix en carton doit être un nombre entier ou décimal";

            if (errorMessage == null)
            {
                bool success = false;
                if (Program.itemId != null)
                {
                    item.Id = Program.itemId ?? default;
                    success = await Item.UpdateItemAsync(item);
                } else
                {
                    success = await Item.CreateItemAsync(item);
                }
                
                if (success)
                {
                    showMessage("Le produit a bien été enregistré.");
                    InitializeSelectBoxes();
                }
                else
                {
                    showMessage("La communication avec la base de données a échoué.", true);
                }
            }
            else
            {
                showMessage(errorMessage, true);
            }
        }

        private void showMessage(string message, bool error = false)
        {
            if (error)
            {
                msgLabel.ForeColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                msgLabel.ForeColor = Color.FromArgb(0, 0, 0);
            }
            msgLabel.Text = message;
             
        }

        // Resets the itemId global variable as soon as the user leaves the page
        private void CreateItems_VisibleChanged(object sender, EventArgs e)
        {
            if (((CreateItems)sender).Visible == false)
            {
                Program.itemId = null;
                InitializeSelectBoxes();
            }
        }
    }
}
