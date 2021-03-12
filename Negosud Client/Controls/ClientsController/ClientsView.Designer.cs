
using System.Windows.Forms;

namespace Negosud_Client
{
    partial class ClientsView
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
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.GVCustomer = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCommandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnTest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GVBTNDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GVBTNUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.BtnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCustomer.Location = new System.Drawing.Point(73, 27);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(187, 56);
            this.BtnCustomer.TabIndex = 0;
            this.BtnCustomer.Text = "Créer client";
            this.BtnCustomer.UseVisualStyleBackColor = false;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // GVCustomer
            // 
            this.GVCustomer.AutoGenerateColumns = false;
            this.GVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.clientCommandsDataGridViewTextBoxColumn,
            this.BtnTest,
            this.GVBTNDelete,
            this.GVBTNUpdate});
            this.GVCustomer.DataSource = this.clientBindingSource;
            this.GVCustomer.Location = new System.Drawing.Point(73, 116);
            this.GVCustomer.Name = "GVCustomer";
            this.GVCustomer.RowHeadersWidth = 62;
            this.GVCustomer.RowTemplate.Height = 28;
            this.GVCustomer.Size = new System.Drawing.Size(1047, 254);
            this.GVCustomer.TabIndex = 2;
            this.GVCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCustomer_CellContentClick);
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "Id";
            this.ClientId.HeaderText = "Id";
            this.ClientId.MinimumWidth = 8;
            this.ClientId.Name = "ClientId";
            this.ClientId.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.streetAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Code Postal";
            this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientCommandsDataGridViewTextBoxColumn
            // 
            this.clientCommandsDataGridViewTextBoxColumn.DataPropertyName = "ClientCommands";
            this.clientCommandsDataGridViewTextBoxColumn.HeaderText = "Commandes";
            this.clientCommandsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clientCommandsDataGridViewTextBoxColumn.Name = "clientCommandsDataGridViewTextBoxColumn";
            this.clientCommandsDataGridViewTextBoxColumn.Width = 150;
            // 
            // BtnTest
            // 
            this.BtnTest.HeaderText = "Info";
            this.BtnTest.MinimumWidth = 8;
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Text = "Info";
            this.BtnTest.UseColumnTextForButtonValue = true;
            this.BtnTest.Width = 150;
            // 
            // GVBTNDelete
            // 
            this.GVBTNDelete.HeaderText = "Supprimer";
            this.GVBTNDelete.MinimumWidth = 8;
            this.GVBTNDelete.Name = "GVBTNDelete";
            this.GVBTNDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GVBTNDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GVBTNDelete.Text = "Supprimer";
            this.GVBTNDelete.UseColumnTextForButtonValue = true;
            this.GVBTNDelete.Width = 150;
            // 
            // GVBTNUpdate
            // 
            this.GVBTNUpdate.HeaderText = "Modifier";
            this.GVBTNUpdate.MinimumWidth = 8;
            this.GVBTNUpdate.Name = "GVBTNUpdate";
            this.GVBTNUpdate.Text = "Modifier";
            this.GVBTNUpdate.UseColumnTextForButtonValue = true;
            this.GVBTNUpdate.Width = 150;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Negosud_Client.Models.Client);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GVCustomer);
            this.Controls.Add(this.BtnCustomer);
            this.Name = "ClientsView";
            this.Size = new System.Drawing.Size(1216, 402);
            this.VisibleChanged += new System.EventHandler(this.ClientsView_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.DataGridView GVCustomer;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource clientBindingSource;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientCommandsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn BtnTest;
        private DataGridViewButtonColumn GVBTNDelete;
        private DataGridViewButtonColumn GVBTNUpdate;
    }
}
