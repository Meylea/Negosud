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
using static Negosud_Client.Clients;

namespace Negosud_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clients1.Visible = false;
            suppliers1.Visible = false;
            clientsInfo1.Visible = false;

            clients1.clickBtn += new DelegateClickBtn(Form1_clickBtn);
            
        }

        //Display page Client
        private void BtnClient_Click(object sender, EventArgs e)
        {
            AllVisibleFalse();
            clients1.Visible = true;
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

        }

        private void AllVisibleFalse()
        {
            clients1.Visible = false;
            suppliers1.Visible = false;
            clientsInfo1.Visible = false;
        }

        //Fonction récupération page 
        private void Form1_clickBtn(string touche)
        {
            if (touche == "Supprimer")
            {
                AllVisibleFalse();
            }
            if (touche == "Info")
            {
                AllVisibleFalse();
                clientsInfo1.Visible = true;
            }
            if (touche == "Command")
            {
                AllVisibleFalse();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
