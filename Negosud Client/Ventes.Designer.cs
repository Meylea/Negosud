
namespace Negosud_Client
{
    partial class Ventes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // IdVente
            // 
            this.IdVente.HeaderText = "Id";
            this.IdVente.MinimumWidth = 6;
            this.IdVente.Name = "IdVente";
            this.IdVente.Width = 125;
            // 
            // NomClient
            // 
            this.NomClient.HeaderText = "Nom";
            this.NomClient.MinimumWidth = 6;
            this.NomClient.Name = "NomClient";
            this.NomClient.Width = 125;
            // 
            // EditeVente
            // 
            this.EditeVente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditeVente.HeaderText = "Editer";
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
            // Ventes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ventes";
            this.Size = new System.Drawing.Size(801, 565);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomClient;
        private System.Windows.Forms.DataGridViewImageColumn EditeVente;
        private System.Windows.Forms.DataGridViewImageColumn SupprimerVente;
        private System.Windows.Forms.DataGridViewImageColumn InformationVente;
    }
}
