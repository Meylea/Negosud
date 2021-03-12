using System;
using System.Windows.Forms;
using Negosud_Client.Models;

namespace Negosud_Client
{
    public partial class ItemInfo : UserControl
    {
        public ItemInfo()
        {
            InitializeComponent();
        }

        public async void UpdateInfo()
        {
            Item item = await Item.GetOneItemAsync(int.Parse(Program.itemId.ToString()));
            NameLabel.Text = item.Name;
            YearResult.Text = item.Year;
            TypeResult.Text = item.TypeName;
            ProducerResult.Text = item.ProducerName;
            SupplierResult.Text = item.SupplierName;
            UnitPriceResult.Text = item.UnitPrice.ToString();
            BoxPriceResult.Text = item.BoxPrice.ToString();
            QuantityResult.Text = item.Quantity.ToString();
            ImgUrlResult.Text = item.ImgUrl;
            if (item.ImgUrl != null)
            {
                ImageBox.Load(item.ImgUrl);
            }
        }

        // Resets the itemId global variable as soon as the user leaves the page
        private void ItemInfo_VisibleChanged(object sender, EventArgs e)
        {
            if (((ItemInfo)sender).Visible == false)
            {
                Program.itemId = null;
            }
        }
    }
}
