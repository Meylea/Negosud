
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
            this.BtnAchat = new System.Windows.Forms.Button();
            this.BtnCatalogue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.provider1 = new Negosud_Client.Provider();
            this.client1 = new Negosud_Client.Customer();
            this.sale1 = new Negosud_Client.Sale();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 34);
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
            this.BtnClient.Location = new System.Drawing.Point(64, 136);
            this.BtnClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(161, 47);
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
            this.BtnFournisseur.Location = new System.Drawing.Point(64, 203);
            this.BtnFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFournisseur.Name = "BtnFournisseur";
            this.BtnFournisseur.Size = new System.Drawing.Size(161, 47);
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
            this.BtnVente.Location = new System.Drawing.Point(64, 271);
            this.BtnVente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVente.Name = "BtnVente";
            this.BtnVente.Size = new System.Drawing.Size(161, 47);
            this.BtnVente.TabIndex = 3;
            this.BtnVente.Text = "Vente";
            this.BtnVente.UseVisualStyleBackColor = false;
            this.BtnVente.Click += new System.EventHandler(this.BtnVente_Click);
            // 
            // BtnAchat
            // 
            this.BtnAchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.BtnAchat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAchat.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAchat.Location = new System.Drawing.Point(64, 340);
            this.BtnAchat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAchat.Name = "BtnAchat";
            this.BtnAchat.Size = new System.Drawing.Size(161, 47);
            this.BtnAchat.TabIndex = 4;
            this.BtnAchat.Text = "Achat";
            this.BtnAchat.UseVisualStyleBackColor = false;
            this.BtnAchat.Click += new System.EventHandler(this.BtnAchat_Click);
            // 
            // BtnCatalogue
            // 
            this.BtnCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.BtnCatalogue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCatalogue.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCatalogue.Location = new System.Drawing.Point(64, 410);
            this.BtnCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCatalogue.Name = "BtnCatalogue";
            this.BtnCatalogue.Size = new System.Drawing.Size(161, 47);
            this.BtnCatalogue.TabIndex = 5;
            this.BtnCatalogue.Text = "Catalogue";
            this.BtnCatalogue.UseVisualStyleBackColor = false;
            this.BtnCatalogue.Click += new System.EventHandler(this.BtnCatalogue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bienvenue";
            // 
            // provider1
            // 
            this.provider1.Location = new System.Drawing.Point(328, 136);
            this.provider1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.provider1.Name = "provider1";
            this.provider1.Size = new System.Drawing.Size(823, 390);
            this.provider1.TabIndex = 8;
            // 
            // client1
            // 
            this.client1.Location = new System.Drawing.Point(328, 136);
            this.client1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.client1.Name = "client1";
            this.client1.Size = new System.Drawing.Size(953, 390);
            this.client1.TabIndex = 7;
            // 
            // sale1
            // 
            this.sale1.Location = new System.Drawing.Point(328, 136);
            this.sale1.Name = "sale1";
            this.sale1.Size = new System.Drawing.Size(953, 321);
            this.sale1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 844);
            this.Controls.Add(this.sale1);
            this.Controls.Add(this.provider1);
            this.Controls.Add(this.client1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCatalogue);
            this.Controls.Add(this.BtnAchat);
            this.Controls.Add(this.BtnVente);
            this.Controls.Add(this.BtnFournisseur);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button BtnAchat;
        private System.Windows.Forms.Button BtnCatalogue;
        private System.Windows.Forms.Label label2;
        private Customer client1;
        private Provider provider1;
        private Sale sale1;
    }
}

