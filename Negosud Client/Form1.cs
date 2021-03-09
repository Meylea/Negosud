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
            clickBtn += Form1_clickBtn;
            
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
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void Form1_clickBtn(string touche)
        {
            if(touche == "Client")
            {
                client1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
