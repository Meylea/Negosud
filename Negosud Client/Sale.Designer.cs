
namespace Negosud_Client
{
    partial class Sale
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRechercheVente = new System.Windows.Forms.Button();
            this.RechercheVente = new System.Windows.Forms.TextBox();
            this.CréerVente = new System.Windows.Forms.Button();
            this.IdVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditeVente = new System.Windows.Forms.DataGridViewImageColumn();
            this.SupprimerVente = new System.Windows.Forms.DataGridViewImageColumn();
            this.InformationVente = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVente,
            this.Statut,
            this.NomClient,
            this.EditeVente,
            this.SupprimerVente,
            this.InformationVente});
            this.dataGridView1.Location = new System.Drawing.Point(3, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRechercheVente
            // 
            this.btnRechercheVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.btnRechercheVente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercheVente.ForeColor = System.Drawing.Color.Transparent;
            this.btnRechercheVente.Location = new System.Drawing.Point(335, 22);
            this.btnRechercheVente.Name = "btnRechercheVente";
            this.btnRechercheVente.Size = new System.Drawing.Size(165, 38);
            this.btnRechercheVente.TabIndex = 1;
            this.btnRechercheVente.Text = "Recherche";
            this.btnRechercheVente.UseVisualStyleBackColor = false;
            // 
            // RechercheVente
            // 
            this.RechercheVente.Location = new System.Drawing.Point(63, 34);
            this.RechercheVente.Name = "RechercheVente";
            this.RechercheVente.Size = new System.Drawing.Size(254, 22);
            this.RechercheVente.TabIndex = 2;
            // 
            // CréerVente
            // 
            this.CréerVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.CréerVente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CréerVente.ForeColor = System.Drawing.Color.Transparent;
            this.CréerVente.Location = new System.Drawing.Point(566, 22);
            this.CréerVente.Name = "CréerVente";
            this.CréerVente.Size = new System.Drawing.Size(165, 38);
            this.CréerVente.TabIndex = 3;
            this.CréerVente.Text = "Créer Vente";
            this.CréerVente.UseVisualStyleBackColor = false;
            // 
            // IdVente
            // 
            this.IdVente.HeaderText = "Id";
            this.IdVente.MinimumWidth = 6;
            this.IdVente.Name = "IdVente";
            this.IdVente.Width = 125;
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.MinimumWidth = 6;
            this.Statut.Name = "Statut";
            this.Statut.Width = 125;
            // 
            // NomClient
            // 
            this.NomClient.HeaderText = "Date";
            this.NomClient.MinimumWidth = 6;
            this.NomClient.Name = "NomClient";
            this.NomClient.Width = 125;
            // 
            // EditeVente
            // 
            this.EditeVente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditeVente.HeaderText = "Editer";
            this.EditeVente.Image = ((System.Drawing.Image)(resources.GetObject("EditeVente.Image")));
            this.EditeVente.MinimumWidth = 6;
            this.EditeVente.Name = "EditeVente";
            this.EditeVente.Width = 51;
            // 
            // SupprimerVente
            // 
            this.SupprimerVente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SupprimerVente.HeaderText = "Supprimer";
            this.SupprimerVente.MinimumWidth = 6;
            this.SupprimerVente.Name = "SupprimerVente";
            this.SupprimerVente.Width = 79;
            // 
            // InformationVente
            // 
            this.InformationVente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InformationVente.HeaderText = "Information";
            this.InformationVente.MinimumWidth = 6;
            this.InformationVente.Name = "InformationVente";
            this.InformationVente.Width = 84;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CréerVente);
            this.Controls.Add(this.RechercheVente);
            this.Controls.Add(this.btnRechercheVente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sale";
            this.Size = new System.Drawing.Size(801, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRechercheVente;
        private System.Windows.Forms.TextBox RechercheVente;
        private System.Windows.Forms.Button CréerVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClient;
        private System.Windows.Forms.DataGridViewImageColumn EditeVente;
        private System.Windows.Forms.DataGridViewImageColumn SupprimerVente;
        private System.Windows.Forms.DataGridViewImageColumn InformationVente;
    }
}
