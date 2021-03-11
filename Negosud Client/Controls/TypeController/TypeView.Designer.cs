
namespace Negosud_Client.Controls.TypeController
{
    partial class TypeView
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
            this.GVType = new System.Windows.Forms.DataGridView();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAjouterType = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVBtnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GVType
            // 
            this.GVType.AutoGenerateColumns = false;
            this.GVType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.GVBtnSupprimer});
            this.GVType.DataSource = this.typeBindingSource;
            this.GVType.Location = new System.Drawing.Point(205, 299);
            this.GVType.Name = "GVType";
            this.GVType.RowHeadersWidth = 62;
            this.GVType.RowTemplate.Height = 28;
            this.GVType.Size = new System.Drawing.Size(366, 204);
            this.GVType.TabIndex = 0;
            this.GVType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVType_CellContentClick);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(Negosud_Client.Models.Type);
            // 
            // BtnAjouterType
            // 
            this.BtnAjouterType.Location = new System.Drawing.Point(93, 135);
            this.BtnAjouterType.Name = "BtnAjouterType";
            this.BtnAjouterType.Size = new System.Drawing.Size(153, 59);
            this.BtnAjouterType.TabIndex = 1;
            this.BtnAjouterType.Text = "Ajouter";
            this.BtnAjouterType.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 26);
            this.textBox1.TabIndex = 2;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
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
            // GVBtnSupprimer
            // 
            this.GVBtnSupprimer.HeaderText = "Supprimer";
            this.GVBtnSupprimer.MinimumWidth = 8;
            this.GVBtnSupprimer.Name = "GVBtnSupprimer";
            this.GVBtnSupprimer.Width = 150;
            // 
            // TypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnAjouterType);
            this.Controls.Add(this.GVType);
            this.Name = "TypeView";
            this.Size = new System.Drawing.Size(830, 610);
            ((System.ComponentModel.ISupportInitialize)(this.GVType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVType;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.Button BtnAjouterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn GVBtnSupprimer;
        private System.Windows.Forms.TextBox textBox1;
    }
}
