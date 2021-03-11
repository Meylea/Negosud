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

namespace Negosud_Client.Controls.SuppliersController
{
    public partial class SuppliersAddUpdate : UserControl
    {
        public SuppliersAddUpdate()
        {
            InitializeComponent();
        }

        private async void updateList()
        {
            if (Program.FilterValue.SuppliersId == "" || Program.FilterValue.SuppliersId == null)
            {
                /*Supplier suppliers = new Supplier();
                //clients = await Client.GetOneClientsAsync(Program.FilterValue.ClientsId);
                TBCity.Text = suppliers.City;
                TBBusinessName.Text = suppliers.ContactFirstName;
                TBContactFirstName.Text = suppliers.StreetAddress;
                TBContactLastName.Text = suppliers.ContactLastName;
                TBContactMail.Text = suppliers.ContactMail;
                TBContactPhone.Text = suppliers.ContactPhone;
                TBStreetAddress.Text = suppliers.StreetAddress;
                TBPostCode.Text = suppliers.PostCode;*/
            }
            if (Program.FilterValue.SuppliersId != "")
            {
                Supplier suppliers = new Supplier();
                suppliers = await Supplier.GetOneSupplierAsync(Int32.Parse(Program.FilterValue.SuppliersId));
                TBCity.Text = suppliers.City;
                TBBusinessName.Text = suppliers.BusinessName;
                TBContactFirstName.Text = suppliers.ContactFirstName;
                TBContactLastName.Text = suppliers.ContactLastName;
                TBContactMail.Text = suppliers.ContactMail;
                TBContactPhone.Text = suppliers.ContactPhone;
                TBStreetAddress.Text = suppliers.StreetAddress;
                TBPostCode.Text = suppliers.PostCode;
            }
        }

        private async void BTNValider_Click(object sender, EventArgs e)
        {
            if (Program.FilterValue.SuppliersId == "" || Program.FilterValue.SuppliersId == null)
            {
                Supplier suppliers = new Supplier();
                
                suppliers.BusinessName = TBBusinessName.Text;
                suppliers.PostCode = TBPostCode.Text;
                suppliers.StreetAddress = TBStreetAddress.Text;
                suppliers.ContactPhone = TBContactPhone.Text;
                suppliers.ContactMail = TBContactMail.Text;
                suppliers.ContactLastName = TBContactLastName.Text;
                suppliers.StreetAddress = TBStreetAddress.Text;
                suppliers.ContactFirstName = TBContactFirstName.Text;
                suppliers.City = TBCity.Text;
                bool valider = await Supplier.CreateSupplierAsync(suppliers);

                if (valider) { MessageBox.Show("Entré validé avec succés"); }
                else if (!valider) { MessageBox.Show("Modification refusé vérifiez les champs"); }
            }
            else
            {

                Supplier suppliers = new Supplier();
                suppliers.Id = Int32.Parse(Program.FilterValue.SuppliersId);
                suppliers.BusinessName = TBBusinessName.Text;
                suppliers.PostCode = TBPostCode.Text;
                suppliers.StreetAddress = TBStreetAddress.Text;
                suppliers.ContactPhone = TBContactPhone.Text;
                suppliers.ContactMail = TBContactMail.Text;
                suppliers.ContactLastName = TBContactLastName.Text;
                suppliers.StreetAddress = TBStreetAddress.Text;
                suppliers.ContactFirstName = TBContactFirstName.Text;
                suppliers.City = TBCity.Text;
                bool valider = await Supplier.UpdateSupplierAsync(suppliers);

                if (valider) { MessageBox.Show("Modification validé avec succés"); }
                else if (!valider) { MessageBox.Show("Modification refusé vérifiez les champs"); }
            }
        }

        private void SuppliersAddUpdate_VisibleChanged(object sender, EventArgs e)
        {
            if (Program.FilterValue.SuppliersId != null)
            {
                updateList();

            }
        }
    }
}
