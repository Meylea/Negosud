
namespace Negosud_Client.Controls
{
    partial class ProducerUC
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
            this.components = new System.ComponentModel.Container();
            this.BtnCreateProducer = new System.Windows.Forms.Button();
            this.BtnEditProducer = new System.Windows.Forms.Button();
            this.GVProducers = new System.Windows.Forms.DataGridView();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVBTNInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GVBTNDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreateProducer
            // 
            this.BtnCreateProducer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.BtnCreateProducer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateProducer.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCreateProducer.Location = new System.Drawing.Point(77, 60);
            this.BtnCreateProducer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreateProducer.Name = "BtnCreateProducer";
            this.BtnCreateProducer.Size = new System.Drawing.Size(166, 45);
            this.BtnCreateProducer.TabIndex = 1;
            this.BtnCreateProducer.Text = "Créer Domaine";
            this.BtnCreateProducer.UseVisualStyleBackColor = false;
            this.BtnCreateProducer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnEditProducer
            // 
            this.BtnEditProducer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.BtnEditProducer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditProducer.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditProducer.Location = new System.Drawing.Point(275, 60);
            this.BtnEditProducer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditProducer.Name = "BtnEditProducer";
            this.BtnEditProducer.Size = new System.Drawing.Size(166, 45);
            this.BtnEditProducer.TabIndex = 2;
            this.BtnEditProducer.Text = "Editer Domaine";
            this.BtnEditProducer.UseVisualStyleBackColor = false;
            // 
            // GVProducers
            // 
            this.GVProducers.AutoGenerateColumns = false;
            this.GVProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.GVBTNInfo,
            this.Column1,
            this.GVBTNDelete});
            this.GVProducers.DataSource = this.producerBindingSource;
            this.GVProducers.Location = new System.Drawing.Point(77, 138);
            this.GVProducers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GVProducers.Name = "GVProducers";
            this.GVProducers.RowHeadersWidth = 62;
            this.GVProducers.RowTemplate.Height = 28;
            this.GVProducers.Size = new System.Drawing.Size(688, 188);
            this.GVProducers.TabIndex = 3;
            this.GVProducers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVProducers_CellContentClick);
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataSource = typeof(Negosud_Client.Models.Producer);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.Width = 125;
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
            // Column1
            // 
            this.Column1.HeaderText = "Modifier";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Modifier";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 150;
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
            // producerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GVProducers);
            this.Controls.Add(this.BtnEditProducer);
            this.Controls.Add(this.BtnCreateProducer);
            this.Name = "producerUC";
            this.Size = new System.Drawing.Size(864, 427);
            ((System.ComponentModel.ISupportInitialize)(this.GVProducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateProducer;
        private System.Windows.Forms.Button BtnEditProducer;
        private System.Windows.Forms.DataGridView GVProducers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn GVBTNInfo;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn GVBTNDelete;
        private System.Windows.Forms.BindingSource producerBindingSource;
    }
}
