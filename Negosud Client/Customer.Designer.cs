
namespace Negosud_Client
{
    partial class Customer
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
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.TBAddCustomer = new System.Windows.Forms.TextBox();
            this.GVCustomer = new System.Windows.Forms.DataGridView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Id_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Client_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.info_Client = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Command_Client = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
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
            // 
            // TBAddCustomer
            // 
            this.TBAddCustomer.Location = new System.Drawing.Point(362, 45);
            this.TBAddCustomer.Name = "TBAddCustomer";
            this.TBAddCustomer.Size = new System.Drawing.Size(330, 26);
            this.TBAddCustomer.TabIndex = 1;
            // 
            // GVCustomer
            // 
            this.GVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Client,
            this.Nom_Client,
            this.Client_Update,
            this.Client_Delete,
            this.info_Client,
            this.Command_Client});
            this.GVCustomer.Location = new System.Drawing.Point(73, 118);
            this.GVCustomer.Name = "GVCustomer";
            this.GVCustomer.RowHeadersWidth = 62;
            this.GVCustomer.RowTemplate.Height = 28;
            this.GVCustomer.Size = new System.Drawing.Size(968, 254);
            this.GVCustomer.TabIndex = 2;
            this.GVCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVCustomer_CellContentClick);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(532, 283);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 3;
            // 
            // Id_Client
            // 
            this.Id_Client.HeaderText = "Id";
            this.Id_Client.MinimumWidth = 8;
            this.Id_Client.Name = "Id_Client";
            this.Id_Client.Width = 150;
            // 
            // Nom_Client
            // 
            this.Nom_Client.HeaderText = "Nom";
            this.Nom_Client.MinimumWidth = 8;
            this.Nom_Client.Name = "Nom_Client";
            this.Nom_Client.Width = 150;
            // 
            // Client_Update
            // 
            this.Client_Update.HeaderText = "Modifier";
            this.Client_Update.MinimumWidth = 8;
            this.Client_Update.Name = "Client_Update";
            this.Client_Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Client_Update.Width = 150;
            // 
            // Client_Delete
            // 
            this.Client_Delete.HeaderText = "Supprimer";
            this.Client_Delete.MinimumWidth = 8;
            this.Client_Delete.Name = "Client_Delete";
            this.Client_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Client_Delete.Width = 150;
            // 
            // info_Client
            // 
            this.info_Client.HeaderText = "Info";
            this.info_Client.MinimumWidth = 8;
            this.info_Client.Name = "info_Client";
            this.info_Client.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.info_Client.Width = 150;
            // 
            // Command_Client
            // 
            this.Command_Client.HeaderText = "Command";
            this.Command_Client.MinimumWidth = 8;
            this.Command_Client.Name = "Command_Client";
            this.Command_Client.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Command_Client.Width = 150;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.GVCustomer);
            this.Controls.Add(this.TBAddCustomer);
            this.Controls.Add(this.BtnCustomer);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(1071, 402);
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.TextBox TBAddCustomer;
        private System.Windows.Forms.DataGridView GVCustomer;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Client;
        private System.Windows.Forms.DataGridViewButtonColumn Client_Update;
        private System.Windows.Forms.DataGridViewButtonColumn Client_Delete;
        private System.Windows.Forms.DataGridViewButtonColumn info_Client;
        private System.Windows.Forms.DataGridViewButtonColumn Command_Client;
    }
}
