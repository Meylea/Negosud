
namespace Negosud_Client
{
    partial class SaleDetail
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
            this.btnsupprimerVente = new System.Windows.Forms.Button();
            this.IdArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticle});
            this.dataGridView1.Location = new System.Drawing.Point(3, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(815, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnsupprimerVente
            // 
            this.btnsupprimerVente.BackColor = System.Drawing.Color.Red;
            this.btnsupprimerVente.ForeColor = System.Drawing.Color.Transparent;
            this.btnsupprimerVente.Location = new System.Drawing.Point(636, 17);
            this.btnsupprimerVente.Name = "btnsupprimerVente";
            this.btnsupprimerVente.Size = new System.Drawing.Size(182, 32);
            this.btnsupprimerVente.TabIndex = 1;
            this.btnsupprimerVente.Text = "Supprimer la vente";
            this.btnsupprimerVente.UseVisualStyleBackColor = false;
            // 
            // IdArticle
            // 
            this.IdArticle.HeaderText = "Id Article";
            this.IdArticle.MinimumWidth = 6;
            this.IdArticle.Name = "IdArticle";
            this.IdArticle.Width = 125;
            // 
            // SaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsupprimerVente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SaleDetail";
            this.Size = new System.Drawing.Size(821, 440);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticle;
        private System.Windows.Forms.Button btnsupprimerVente;
    }
}
