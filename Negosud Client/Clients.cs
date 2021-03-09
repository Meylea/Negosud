﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negosud_Client;
namespace Negosud_Client
{
    public partial class Clients : UserControl
    {

        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public Clients()
        {
            InitializeComponent();
        }

        private void GVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(GVCustomer.Columns[e.ColumnIndex].HeaderText);
            if (clickBtn != null)
            {
                clickBtn(GVCustomer.Columns[e.ColumnIndex].HeaderText);
            }
            //Visible = false;
        }
    }
}
