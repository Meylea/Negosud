
namespace Negosud_Client.Controls.SuppliersController
{
    partial class SuppliersView
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
            this.GVSuppliers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNGVModifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVBTNInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GVBTNDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTNAddSuppliers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GVSuppliers
            // 
            this.GVSuppliers.AutoGenerateColumns = false;
            this.GVSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.BTNGVModifier,
            this.businessNameDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.contactLastNameDataGridViewTextBoxColumn,
            this.contactFirstNameDataGridViewTextBoxColumn,
            this.contactPhoneDataGridViewTextBoxColumn,
            this.contactMailDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.GVBTNInfo,
            this.GVBTNDelete,
            this.Column1});
            this.GVSuppliers.DataSource = this.supplierBindingSource;
            this.GVSuppliers.Location = new System.Drawing.Point(139, 326);
            this.GVSuppliers.Name = "GVSuppliers";
            this.GVSuppliers.RowHeadersWidth = 62;
            this.GVSuppliers.RowTemplate.Height = 28;
            this.GVSuppliers.Size = new System.Drawing.Size(902, 235);
            this.GVSuppliers.TabIndex = 0;
            this.GVSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVSuppliers_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // BTNGVModifier
            // 
            this.BTNGVModifier.HeaderText = "Modifier";
            this.BTNGVModifier.MinimumWidth = 8;
            this.BTNGVModifier.Name = "BTNGVModifier";
            this.BTNGVModifier.Visible = false;
            this.BTNGVModifier.Width = 150;
            // 
            // businessNameDataGridViewTextBoxColumn
            // 
            this.businessNameDataGridViewTextBoxColumn.DataPropertyName = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.HeaderText = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.businessNameDataGridViewTextBoxColumn.Name = "businessNameDataGridViewTextBoxColumn";
            this.businessNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactLastNameDataGridViewTextBoxColumn
            // 
            this.contactLastNameDataGridViewTextBoxColumn.DataPropertyName = "ContactLastName";
            this.contactLastNameDataGridViewTextBoxColumn.HeaderText = "ContactLastName";
            this.contactLastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactLastNameDataGridViewTextBoxColumn.Name = "contactLastNameDataGridViewTextBoxColumn";
            this.contactLastNameDataGridViewTextBoxColumn.Visible = false;
            this.contactLastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactFirstNameDataGridViewTextBoxColumn
            // 
            this.contactFirstNameDataGridViewTextBoxColumn.DataPropertyName = "ContactFirstName";
            this.contactFirstNameDataGridViewTextBoxColumn.HeaderText = "ContactFirstName";
            this.contactFirstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactFirstNameDataGridViewTextBoxColumn.Name = "contactFirstNameDataGridViewTextBoxColumn";
            this.contactFirstNameDataGridViewTextBoxColumn.Visible = false;
            this.contactFirstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "ContactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            this.contactPhoneDataGridViewTextBoxColumn.Visible = false;
            this.contactPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactMailDataGridViewTextBoxColumn
            // 
            this.contactMailDataGridViewTextBoxColumn.DataPropertyName = "ContactMail";
            this.contactMailDataGridViewTextBoxColumn.HeaderText = "ContactMail";
            this.contactMailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactMailDataGridViewTextBoxColumn.Name = "contactMailDataGridViewTextBoxColumn";
            this.contactMailDataGridViewTextBoxColumn.Visible = false;
            this.contactMailDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.Visible = false;
            this.itemsDataGridViewTextBoxColumn.Width = 150;
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
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Negosud_Client.Models.Supplier);
            // 
            // BTNAddSuppliers
            // 
            this.BTNAddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddSuppliers.Location = new System.Drawing.Point(183, 190);
            this.BTNAddSuppliers.Name = "BTNAddSuppliers";
            this.BTNAddSuppliers.Size = new System.Drawing.Size(166, 53);
            this.BTNAddSuppliers.TabIndex = 1;
            this.BTNAddSuppliers.Text = "Ajouter fournisseur";
            this.BTNAddSuppliers.UseVisualStyleBackColor = true;
            this.BTNAddSuppliers.Click += new System.EventHandler(this.BTNAddSuppliers_Click);
            // 
            // SuppliersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTNAddSuppliers);
            this.Controls.Add(this.GVSuppliers);
            this.Name = "SuppliersView";
            this.Size = new System.Drawing.Size(1118, 678);
            this.VisibleChanged += new System.EventHandler(this.SuppliersView_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GVSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVSuppliers;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button BTNAddSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTNGVModifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn GVBTNInfo;
        private System.Windows.Forms.DataGridViewButtonColumn GVBTNDelete;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
