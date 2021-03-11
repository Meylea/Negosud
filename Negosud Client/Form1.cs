using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negosud_Client;
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
        }

        private void Items1_ClickBtn(string button)
        {
            if (button == "createItem" || button == "Edit")
            {
                AllVisibleFalse();
                createItems1.Visible = true;
                if (button == "Edit") createItems1.InitializeSelectBoxes();
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

        private void SuppliersView1_clickBtn(string touche)
        {
            clients1.Visible = false;
            provider1.Visible = false;
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

        private void createItems1_VisibleChanged(object sender, EventArgs e)
        {
            if (!items1.Visible)
            {
                Program.itemId = null;
            }
        }
    }
}
