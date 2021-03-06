using System;
using System.Windows.Forms;
using static Negosud_Client.ClientsView;

namespace Negosud_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllVisibleFalse();

            clients1.clickBtn += new DelegateClickBtn(Clients1_clickBtn);
            //suppliers1.clickBtn += new DelegateClickBtn(SuppliersView1_clickBtn);
            items1.ClickBtn += Items1_ClickBtn;
            ProducerControll.clickBtn += ProducerControll_ClickBtn;
            sale1.ClickBtn += Sale1_clickBtn;
            createCmd1.ClickBtn += CreateCmd1_ClickBtn;
        }

        private void CreateCmd1_ClickBtn(string button)
        {
            AllVisibleFalse();
            sale1.Visible = true;
        }

        private void Items1_ClickBtn(string button)
        {
            if (button == "createItem" || button == "Edit")
            {
                AllVisibleFalse();
                createItems1.Visible = true;
                if (button == "Edit") createItems1.InitializeSelectBoxes();
            }
            if (button == "Info")
            {
                AllVisibleFalse();
                itemInfo1.Visible = true;
                itemInfo1.UpdateInfo();
            }
            if (button == "InventoryBtn")
            {
                AllVisibleFalse();
                inventory1.Visible = true;
                inventory1.UpdateList();
            }
        }

        //Display page Client
        private void BtnClient_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            clients1.Visible = true;
            Program.FilterValue.ClientsId = "";
        }

        //Display page Fournisseur
        private void BtnFournisseur_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            suppliers1.Visible = true;
        }

        //Display page Vente
        private void BtnVente_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            sale1.Visible = true;
        }

        //Display page Achat
        private void BtnAchat_Click(object sender, EventArgs e)
        {

        }

        //Display page Catalogue
        private void BtnCatalogue_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            items1.Visible = true;
        }
        private void BtnProducer_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            items1.Visible = true;
        }

        private void AllVisibleFalse()
        {
            clients1.Visible = false;
            suppliers1.Visible = false;
            clientsInfo1.Visible = false;
            clientsInformation1.Visible = false;
            suppliersAddUpdate1.Visible = false;
            suppliersInfo1.Visible = false;
            items1.Visible = false;
            createItems1.Visible = false;
            itemInfo1.Visible = false;
            inventory1.Visible = false;
            sale1.Visible = false;
            saleDetail1.Visible = false;
            createCmd1.Visible = false;

            ProducerControll.Visible = false;
            producerInfo1.Visible = false;      
            
        }

        //Fonction récupération page 
        private void Clients1_clickBtn(string touche)
        {
            if (touche == "Supprimer")
            {
                AllVisibleFalse();
                clientsInfo1.Visible = true;
            }
            if (touche == "CreateClient")
            {
                AllVisibleFalse();
                clientsInfo1.Visible = true;
            }
            if(touche == "Info")
            {
                AllVisibleFalse();
                clientsInformation1.Visible = true;
            }
            if (touche == "Modifier")
            {
                AllVisibleFalse();
                clientsInfo1.Visible = true;
            }
        }

        private void ProducerControll_ClickBtn(string touche)
        {
            if (touche == "CreateProducer")
            {
                AllVisibleFalse();
                clientsInfo1.Visible = true;
            }
            if (touche == "Modifier") 
            {
                AllVisibleFalse();
                clientsInfo1.Visible = true;
            }
        }

        private void Sale1_clickBtn(string touche)
        {
            if (touche == "Information")
            {
                AllVisibleFalse();
                saleDetail1.Visible = true;
            }
            if (touche == "CreateCommand")
            {
                AllVisibleFalse();
                createCmd1.Visible = true;
            }
        }

        private void SuppliersView1_clickBtn(string touche)
        {
            clients1.Visible = false;
            if(touche == "Client")
            {

                AllVisibleFalse();
                clientsInfo1.Visible = true;
            }            
            if (touche == "CreateSuppliers")
            {

                AllVisibleFalse();
                suppliersAddUpdate1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnProducer_Click_1(object sender, EventArgs e)
        {
            AllVisibleFalse();
            ProducerControll.Visible = true;
        }
    }
}
