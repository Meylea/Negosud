
namespace Negosud_Client
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClient = new System.Windows.Forms.Button();
            this.BtnFournisseur = new System.Windows.Forms.Button();
            this.BtnVente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCatalogue = new System.Windows.Forms.Button();
            this.itemInfo1 = new Negosud_Client.ItemInfo();
            this.sale1 = new Negosud_Client.Sale();
            this.suppliersInfo1 = new Negosud_Client.Controls.SuppliersController.SuppliersInfo();
            this.suppliersAddUpdate1 = new Negosud_Client.Controls.SuppliersController.SuppliersAddUpdate();
            this.suppliers1 = new Negosud_Client.Controls.SuppliersController.SuppliersView();
            this.clientsInformation1 = new Negosud_Client.Controls.ClientsInformation();
            this.clientsInfo1 = new Negosud_Client.Controls.ClientsInfo();
            this.createItems1 = new Negosud_Client.CreateItems();
            this.items1 = new Negosud_Client.Items();
            this.clients1 = new Negosud_Client.ClientsView();
            this.inventory1 = new Negosud_Client.Inventory();
            this.BtnProducer = new System.Windows.Forms.Button();
            this.ProducerControll = new Negosud_Client.Controls.ProducerUC();
            this.producerInfo1 = new Negosud_Client.Controls.ProducerControll.ProducerInfo();
            this.saleDetail1 = new Negosud_Client.SaleDetail();
            this.createCmd1 = new Negosud_Client.CreateCmd();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Negosud";
            // 
            // BtnClient
            // 
            this.BtnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.BtnClient.FlatAppearance.BorderSize = 0;
            this.BtnClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.ForeColor = System.Drawing.Color.Transparent;
            this.BtnClient.Location = new System.Drawing.Point(72, 170);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(181, 59);
            this.BtnClient.TabIndex = 1;
            this.BtnClient.Text = "Client";
            this.BtnClient.UseVisualStyleBackColor = false;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // BtnFournisseur
            // 
            this.BtnFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.BtnFournisseur.FlatAppearance.BorderSize = 0;
            this.BtnFournisseur.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnFournisseur.ForeColor = System.Drawing.Color.Transparent;
            this.BtnFournisseur.Location = new System.Drawing.Point(72, 254);
            this.BtnFournisseur.Name = "BtnFournisseur";
            this.BtnFournisseur.Size = new System.Drawing.Size(181, 59);
            this.BtnFournisseur.TabIndex = 2;
            this.BtnFournisseur.Text = "Fournisseur";
            this.BtnFournisseur.UseVisualStyleBackColor = false;
            this.BtnFournisseur.Click += new System.EventHandler(this.BtnFournisseur_Click);
            // 
            // BtnVente
            // 
            this.BtnVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.BtnVente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnVente.ForeColor = System.Drawing.Color.Transparent;
            this.BtnVente.Location = new System.Drawing.Point(72, 339);
            this.BtnVente.Name = "BtnVente";
            this.BtnVente.Size = new System.Drawing.Size(181, 59);
            this.BtnVente.TabIndex = 3;
            this.BtnVente.Text = "Vente";
            this.BtnVente.UseVisualStyleBackColor = false;
            this.BtnVente.Click += new System.EventHandler(this.BtnVente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bienvenue";
            // 
            // BtnCatalogue
            // 
            this.BtnCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.BtnCatalogue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCatalogue.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCatalogue.Location = new System.Drawing.Point(72, 433);
            this.BtnCatalogue.Name = "BtnCatalogue";
            this.BtnCatalogue.Size = new System.Drawing.Size(181, 59);
            this.BtnCatalogue.TabIndex = 16;
            this.BtnCatalogue.Text = "Catalogue";
            this.BtnCatalogue.UseVisualStyleBackColor = false;
            this.BtnCatalogue.Click += new System.EventHandler(this.BtnCatalogue_Click);
            // 
            // itemInfo1
            // 
            this.itemInfo1.Location = new System.Drawing.Point(273, 109);
            this.itemInfo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemInfo1.Name = "itemInfo1";
            this.itemInfo1.Size = new System.Drawing.Size(773, 464);
            this.itemInfo1.TabIndex = 17;
            this.itemInfo1.Visible = false;
            // 
            // sale1
            // 
            this.sale1.Location = new System.Drawing.Point(289, 66);
            this.sale1.Name = "sale1";
            this.sale1.Size = new System.Drawing.Size(1079, 425);
            this.sale1.TabIndex = 9;
            // 
            // suppliersInfo1
            // 
            this.suppliersInfo1.Location = new System.Drawing.Point(384, 163);
            this.suppliersInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersInfo1.Name = "suppliersInfo1";
            this.suppliersInfo1.Size = new System.Drawing.Size(559, 579);
            this.suppliersInfo1.TabIndex = 15;
            // 
            // suppliersAddUpdate1
            // 
            this.suppliersAddUpdate1.Location = new System.Drawing.Point(337, 82);
            this.suppliersAddUpdate1.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersAddUpdate1.Name = "suppliersAddUpdate1";
            this.suppliersAddUpdate1.Size = new System.Drawing.Size(779, 708);
            this.suppliersAddUpdate1.TabIndex = 14;
            // 
            // suppliers1
            // 
            this.suppliers1.Location = new System.Drawing.Point(292, 119);
            this.suppliers1.Margin = new System.Windows.Forms.Padding(2);
            this.suppliers1.Name = "suppliers1";
            this.suppliers1.Size = new System.Drawing.Size(1120, 597);
            this.suppliers1.TabIndex = 13;
            // 
            // clientsInformation1
            // 
            this.clientsInformation1.Location = new System.Drawing.Point(357, 82);
            this.clientsInformation1.Margin = new System.Windows.Forms.Padding(2);
            this.clientsInformation1.Name = "clientsInformation1";
            this.clientsInformation1.Size = new System.Drawing.Size(843, 660);
            this.clientsInformation1.TabIndex = 12;
            // 
            // clientsInfo1
            // 
            this.clientsInfo1.Location = new System.Drawing.Point(273, 64);
            this.clientsInfo1.Margin = new System.Windows.Forms.Padding(2);
            this.clientsInfo1.Name = "clientsInfo1";
            this.clientsInfo1.Size = new System.Drawing.Size(755, 702);
            this.clientsInfo1.TabIndex = 11;
            // 
            // createItems1
            // 
            this.createItems1.Location = new System.Drawing.Point(337, 64);
            this.createItems1.Margin = new System.Windows.Forms.Padding(4);
            this.createItems1.Name = "createItems1";
            this.createItems1.Size = new System.Drawing.Size(857, 509);
            this.createItems1.TabIndex = 10;
            this.createItems1.Visible = false;
            // 
            // items1
            // 
            this.items1.Location = new System.Drawing.Point(315, 64);
            this.items1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.items1.Name = "items1";
            this.items1.Size = new System.Drawing.Size(858, 428);
            this.items1.TabIndex = 9;
            this.items1.Visible = false;
            // 
            // clients1
            // 
            this.clients1.Location = new System.Drawing.Point(292, 179);
            this.clients1.Margin = new System.Windows.Forms.Padding(2);
            this.clients1.Name = "clients1";
            this.clients1.Size = new System.Drawing.Size(1071, 402);
            this.clients1.TabIndex = 10;
            // 
            // inventory1
            // 
            this.inventory1.Location = new System.Drawing.Point(259, 82);
            this.inventory1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(868, 532);
            this.inventory1.TabIndex = 18;
            this.inventory1.Visible = false;
            // 
            // BtnProducer
            // 
            this.BtnProducer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.BtnProducer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnProducer.ForeColor = System.Drawing.Color.Transparent;
            this.BtnProducer.Location = new System.Drawing.Point(72, 609);
            this.BtnProducer.Name = "BtnProducer";
            this.BtnProducer.Size = new System.Drawing.Size(181, 58);
            this.BtnProducer.TabIndex = 18;
            this.BtnProducer.Text = "Domaine";
            this.BtnProducer.UseVisualStyleBackColor = false;
            this.BtnProducer.Click += new System.EventHandler(this.BtnProducer_Click_1);
            // 
            // ProducerControll
            // 
            this.ProducerControll.Location = new System.Drawing.Point(315, 69);
            this.ProducerControll.Name = "ProducerControll";
            this.ProducerControll.Size = new System.Drawing.Size(812, 438);
            this.ProducerControll.TabIndex = 19;
            // 
            // producerInfo1
            // 
            this.producerInfo1.Location = new System.Drawing.Point(384, 119);
            this.producerInfo1.Name = "producerInfo1";
            this.producerInfo1.Size = new System.Drawing.Size(541, 279);
            this.producerInfo1.TabIndex = 20;
            // 
            // saleDetail1
            // 
            this.saleDetail1.Location = new System.Drawing.Point(315, 44);
            this.saleDetail1.Name = "saleDetail1";
            this.saleDetail1.Size = new System.Drawing.Size(955, 516);
            this.saleDetail1.TabIndex = 17;
            // 
            // createCmd1
            // 
            this.createCmd1.Location = new System.Drawing.Point(273, 23);
            this.createCmd1.Name = "createCmd1";
            this.createCmd1.Size = new System.Drawing.Size(671, 591);
            this.createCmd1.TabIndex = 19;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1585, 1055);
            this.Controls.Add(this.producerInfo1);
            this.Controls.Add(this.ProducerControll);
            this.Controls.Add(this.createCmd1);
            this.Controls.Add(this.inventory1);
            this.Controls.Add(this.itemInfo1);
            this.Controls.Add(this.saleDetail1);
            this.Controls.Add(this.sale1);
            this.Controls.Add(this.BtnProducer);
            this.Controls.Add(this.BtnCatalogue);
            this.Controls.Add(this.suppliersInfo1);
            this.Controls.Add(this.suppliersAddUpdate1);
            this.Controls.Add(this.suppliers1);
            this.Controls.Add(this.clientsInformation1);
            this.Controls.Add(this.clientsInfo1);
            this.Controls.Add(this.createItems1);
            this.Controls.Add(this.items1);
            this.Controls.Add(this.clients1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVente);
            this.Controls.Add(this.BtnFournisseur);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negosud";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button BtnFournisseur;
        private System.Windows.Forms.Button BtnVente;
      
        private ClientsView clients1;
        private Controls.ClientsInfo clientsInfo1;
        private Controls.ClientsInformation clientsInformation1;
        private Controls.SuppliersController.SuppliersView suppliers1;
        private Controls.SuppliersController.SuppliersAddUpdate suppliersAddUpdate1;
        private Controls.SuppliersController.SuppliersInfo suppliersInfo1;
        private Items items1;
        private CreateItems createItems1;
        private System.Windows.Forms.Label label2;
        private Sale sale1;
        private System.Windows.Forms.Button BtnCatalogue;
        private ItemInfo itemInfo1;
        private Inventory inventory1;
        private System.Windows.Forms.Button BtnProducer;
        private Controls.ProducerUC ProducerControll;
        private Controls.ProducerControll.ProducerInfo producerInfo1;
        private SaleDetail saleDetail1;
        private CreateCmd createCmd1;
    }
}

