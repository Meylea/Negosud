
namespace Negosud_Client
{
    partial class Provider
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
            this.createProvider = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Provider_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider_Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Provider_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Provider_Info = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // createProvider
            // 
            this.createProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.createProvider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProvider.ForeColor = System.Drawing.Color.Transparent;
            this.createProvider.Location = new System.Drawing.Point(61, 51);
            this.createProvider.Name = "createProvider";
            this.createProvider.Size = new System.Drawing.Size(216, 53);
            this.createProvider.TabIndex = 0;
            this.createProvider.Text = "Créer Fournisseur";
            this.createProvider.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Provider_Id,
            this.Provider_Nom,
            this.Provider_Update,
            this.Provider_Delete,
            this.Provider_Info});
            this.dataGridView1.Location = new System.Drawing.Point(33, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // Provider_Id
            // 
            this.Provider_Id.HeaderText = "Id";
            this.Provider_Id.MinimumWidth = 8;
            this.Provider_Id.Name = "Provider_Id";
            this.Provider_Id.Width = 150;
            // 
            // Provider_Nom
            // 
            this.Provider_Nom.HeaderText = "Nom";
            this.Provider_Nom.MinimumWidth = 8;
            this.Provider_Nom.Name = "Provider_Nom";
            this.Provider_Nom.Width = 150;
            // 
            // Provider_Update
            // 
            this.Provider_Update.HeaderText = "";
            this.Provider_Update.MinimumWidth = 8;
            this.Provider_Update.Name = "Provider_Update";
            this.Provider_Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Provider_Update.Width = 150;
            // 
            // Provider_Delete
            // 
            this.Provider_Delete.HeaderText = "";
            this.Provider_Delete.MinimumWidth = 8;
            this.Provider_Delete.Name = "Provider_Delete";
            this.Provider_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Provider_Delete.Width = 150;
            // 
            // Provider_Info
            // 
            this.Provider_Info.HeaderText = "";
            this.Provider_Info.MinimumWidth = 8;
            this.Provider_Info.Name = "Provider_Info";
            this.Provider_Info.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Provider_Info.Width = 150;
            // 
            // Provider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.createProvider);
            this.Name = "Provider";
            this.Size = new System.Drawing.Size(867, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createProvider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider_Nom;
        private System.Windows.Forms.DataGridViewButtonColumn Provider_Update;
        private System.Windows.Forms.DataGridViewButtonColumn Provider_Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Provider_Info;
    }
}
