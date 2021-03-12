
using Negosud_Client.Models;

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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Information = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRechercheVente = new System.Windows.Forms.Button();
            this.RechercheVente = new System.Windows.Forms.TextBox();
            this.CreateCommand = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCommandLinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCommandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCommandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.ClientName,
            this.statusDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.clientCommandLinesDataGridViewTextBoxColumn,
            this.Information});
            this.dataGridView1.DataSource = this.clientCommandBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 496);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 125;
            // 
            // Information
            // 
            this.Information.HeaderText = "Information";
            this.Information.MinimumWidth = 6;
            this.Information.Name = "Information";
            this.Information.Text = "Information";
            this.Information.UseColumnTextForButtonValue = true;
            this.Information.Width = 125;
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
            this.btnRechercheVente.Click += new System.EventHandler(this.btnRechercheVente_Click);
            // 
            // RechercheVente
            // 
            this.RechercheVente.Location = new System.Drawing.Point(63, 34);
            this.RechercheVente.Name = "RechercheVente";
            this.RechercheVente.Size = new System.Drawing.Size(254, 22);
            this.RechercheVente.TabIndex = 2;
            // 
            // CreateCommand
            // 
            this.CreateCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.CreateCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCommand.ForeColor = System.Drawing.Color.Transparent;
            this.CreateCommand.Location = new System.Drawing.Point(566, 22);
            this.CreateCommand.Name = "CreateCommand";
            this.CreateCommand.Size = new System.Drawing.Size(165, 38);
            this.CreateCommand.TabIndex = 3;
            this.CreateCommand.Text = "Créer Vente";
            this.CreateCommand.UseVisualStyleBackColor = false;
            this.CreateCommand.Click += new System.EventHandler(this.CreateCommand_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(151)))), ((int)(((byte)(66)))));
            this.Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.Transparent;
            this.Update.Location = new System.Drawing.Point(806, 22);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(165, 38);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientCommandLinesDataGridViewTextBoxColumn
            // 
            this.clientCommandLinesDataGridViewTextBoxColumn.DataPropertyName = "ClientCommandLines";
            this.clientCommandLinesDataGridViewTextBoxColumn.HeaderText = "ClientCommandLines";
            this.clientCommandLinesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientCommandLinesDataGridViewTextBoxColumn.Name = "clientCommandLinesDataGridViewTextBoxColumn";
            this.clientCommandLinesDataGridViewTextBoxColumn.Visible = false;
            this.clientCommandLinesDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientCommandBindingSource
            // 
            this.clientCommandBindingSource.DataSource = typeof(Negosud_Client.Models.ClientCommand);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Update);
            this.Controls.Add(this.CreateCommand);
            this.Controls.Add(this.RechercheVente);
            this.Controls.Add(this.btnRechercheVente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sale";
            this.Size = new System.Drawing.Size(1189, 565);
            this.Load += new System.EventHandler(this.Sale_Load);
            this.VisibleChanged += new System.EventHandler(this.Sale_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCommandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRechercheVente;
        private System.Windows.Forms.TextBox RechercheVente;
        private System.Windows.Forms.Button CreateCommand;
        private System.Windows.Forms.BindingSource clientCommandBindingSource;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCommandLinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Information;
    }
}
