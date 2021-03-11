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
    public partial class Form1 : Form
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;
        
        public Form1()
        {
            InitializeComponent();
            client1.Visible = false;
            provider1.Visible = false;
            clickBtn += Form1_clickBtn;
            items1.ClickBtn += Items1_ClickBtn;
        }

        private void Items1_ClickBtn(string button)
        {
            if (button == "createItem" || button == "Edit")
            {
                client1.Visible = false;
                provider1.Visible = false;
                items1.Visible = false;
                createItems1.Visible = true;
                if (button == "Edit") createItems1.InitializeSelectBoxes();
            }
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void BtnFournisseur_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void BtnVente_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void BtnAchat_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void BtnCatalogue_Click(object sender, EventArgs e)
        {
            client1.Visible = false;
            provider1.Visible = false;
            createItems1.Visible = false;
            items1.Visible = true;
        }

        private void Form1_clickBtn(string touche)
        {
            client1.Visible = false;
            provider1.Visible = false;
            if(touche == "Client")
            {
                client1.Visible = true;
            }
            if (touche == "Fournisseur")
            {
                provider1.Visible = true;
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
