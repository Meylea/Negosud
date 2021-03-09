
namespace Negosud_Client
{
    partial class Clients
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
            this.TBAddCustomer = new System.Windows.Forms.TextBox();
            this.GVCustomer = new System.Windows.Forms.DataGridView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomer)).BeginInit();
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.GVCustomer);
            this.Controls.Add(this.TBAddCustomer);
            this.Controls.Add(this.BtnCustomer);
            this.Name = "Clients";
            this.Size = new System.Drawing.Size(1071, 402);
            ((System.ComponentModel.ISupportInitialize)(this.GVCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.TextBox TBAddCustomer;
        private System.Windows.Forms.DataGridView GVCustomer;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
