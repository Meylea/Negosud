
namespace Negosud_Client
{
    partial class Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryView = new System.Windows.Forms.DataGridView();
            this.Validate = new System.Windows.Forms.Button();
            this.NewQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indiquez la nouvelle valeur dans la colonne vide";
            // 
            // InventoryView
            // 
            this.InventoryView.AutoGenerateColumns = false;
            this.InventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.producerNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.NewQuantity,
            this.supplierNameDataGridViewTextBoxColumn,
            this.typeIdDataGridViewTextBoxColumn,
            this.imgUrlDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.boxPriceDataGridViewTextBoxColumn,
            this.producerIdDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.InventoryView.DataSource = this.itemBindingSource;
            this.InventoryView.Location = new System.Drawing.Point(44, 83);
            this.InventoryView.Name = "InventoryView";
            this.InventoryView.Size = new System.Drawing.Size(725, 363);
            this.InventoryView.TabIndex = 1;
            // 
            // Validate
            // 
            this.Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validate.Location = new System.Drawing.Point(633, 452);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(136, 35);
            this.Validate.TabIndex = 2;
            this.Validate.Text = "Valider";
            this.Validate.UseVisualStyleBackColor = true;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // NewQuantity
            // 
            this.NewQuantity.HeaderText = "Nouvelle quantité";
            this.NewQuantity.Name = "NewQuantity";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Année";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 50;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // producerNameDataGridViewTextBoxColumn
            // 
            this.producerNameDataGridViewTextBoxColumn.DataPropertyName = "ProducerName";
            this.producerNameDataGridViewTextBoxColumn.HeaderText = "Producteur";
            this.producerNameDataGridViewTextBoxColumn.Name = "producerNameDataGridViewTextBoxColumn";
            this.producerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.producerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 50;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeIdDataGridViewTextBoxColumn
            // 
            this.typeIdDataGridViewTextBoxColumn.DataPropertyName = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.HeaderText = "TypeId";
            this.typeIdDataGridViewTextBoxColumn.Name = "typeIdDataGridViewTextBoxColumn";
            this.typeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // imgUrlDataGridViewTextBoxColumn
            // 
            this.imgUrlDataGridViewTextBoxColumn.DataPropertyName = "ImgUrl";
            this.imgUrlDataGridViewTextBoxColumn.HeaderText = "ImgUrl";
            this.imgUrlDataGridViewTextBoxColumn.Name = "imgUrlDataGridViewTextBoxColumn";
            this.imgUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // boxPriceDataGridViewTextBoxColumn
            // 
            this.boxPriceDataGridViewTextBoxColumn.DataPropertyName = "BoxPrice";
            this.boxPriceDataGridViewTextBoxColumn.HeaderText = "BoxPrice";
            this.boxPriceDataGridViewTextBoxColumn.Name = "boxPriceDataGridViewTextBoxColumn";
            this.boxPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // producerIdDataGridViewTextBoxColumn
            // 
            this.producerIdDataGridViewTextBoxColumn.DataPropertyName = "ProducerId";
            this.producerIdDataGridViewTextBoxColumn.HeaderText = "ProducerId";
            this.producerIdDataGridViewTextBoxColumn.Name = "producerIdDataGridViewTextBoxColumn";
            this.producerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Negosud_Client.Models.Item);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(44, 473);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 13);
            this.MessageLabel.TabIndex = 3;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.Validate);
            this.Controls.Add(this.InventoryView);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(868, 532);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InventoryView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boxPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label MessageLabel;
    }
}
