
namespace Negosud_Client.Controls
{
    partial class ProducerControll
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
            this.BtnProducer = new System.Windows.Forms.Button();
            this.EditProducer = new System.Windows.Forms.Button();
            this.GVProducers = new System.Windows.Forms.DataGridView();
            this.BTNGVModifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVBTNInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GVBTNDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVProducers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProducer
            // 
            this.BtnProducer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.BtnProducer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducer.ForeColor = System.Drawing.Color.Transparent;
            this.BtnProducer.Location = new System.Drawing.Point(77, 60);
            this.BtnProducer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProducer.Name = "BtnProducer";
            this.BtnProducer.Size = new System.Drawing.Size(166, 45);
            this.BtnProducer.TabIndex = 1;
            this.BtnProducer.Text = "Créer Domaine";
            this.BtnProducer.UseVisualStyleBackColor = false;
            this.BtnProducer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // EditProducer
            // 
            this.EditProducer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.EditProducer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProducer.ForeColor = System.Drawing.Color.Transparent;
            this.EditProducer.Location = new System.Drawing.Point(275, 60);
            this.EditProducer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditProducer.Name = "EditProducer";
            this.EditProducer.Size = new System.Drawing.Size(166, 45);
            this.EditProducer.TabIndex = 2;
            this.EditProducer.Text = "Editer Domaine";
            this.EditProducer.UseVisualStyleBackColor = false;
            // 
            // GVProducers
            // 
            this.GVProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BTNGVModifier,
            this.GVBTNInfo,
            this.GVBTNDelete,
            this.Column1});
            this.GVProducers.Location = new System.Drawing.Point(77, 138);
            this.GVProducers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GVProducers.Name = "GVProducers";
            this.GVProducers.RowHeadersWidth = 62;
            this.GVProducers.RowTemplate.Height = 28;
            this.GVProducers.Size = new System.Drawing.Size(688, 188);
            this.GVProducers.TabIndex = 3;
            this.GVProducers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVProducers_CellContentClick);
            // 
            // BTNGVModifier
            // 
            this.BTNGVModifier.HeaderText = "Modifier";
            this.BTNGVModifier.MinimumWidth = 8;
            this.BTNGVModifier.Name = "BTNGVModifier";
            this.BTNGVModifier.Width = 150;
            // 
            // GVBTNInfo
            // 
            this.GVBTNInfo.HeaderText = "Info";
            this.GVBTNInfo.MinimumWidth = 8;
            this.GVBTNInfo.Name = "GVBTNInfo";
            this.GVBTNInfo.Text = "Info";
            this.GVBTNInfo.UseColumnTextForButtonValue = true;
            this.GVBTNInfo.Width = 150;
            // 
            // GVBTNDelete
            // 
            this.GVBTNDelete.HeaderText = "Supprimer";
            this.GVBTNDelete.MinimumWidth = 8;
            this.GVBTNDelete.Name = "GVBTNDelete";
            this.GVBTNDelete.Text = "Supprimer";
            this.GVBTNDelete.UseColumnTextForButtonValue = true;
            this.GVBTNDelete.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Modifier";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Modifier";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 150;
            // 
            // ProducerControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GVProducers);
            this.Controls.Add(this.EditProducer);
            this.Controls.Add(this.BtnProducer);
            this.Name = "ProducerControll";
            this.Size = new System.Drawing.Size(812, 438);
            ((System.ComponentModel.ISupportInitialize)(this.GVProducers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProducer;
        private System.Windows.Forms.Button EditProducer;
        private System.Windows.Forms.DataGridView GVProducers;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTNGVModifier;
        private System.Windows.Forms.DataGridViewButtonColumn GVBTNInfo;
        private System.Windows.Forms.DataGridViewButtonColumn GVBTNDelete;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
