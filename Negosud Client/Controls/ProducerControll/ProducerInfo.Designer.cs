
namespace Negosud_Client.Controls.ProducerControll
{
    partial class ProducerInfo
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
            this.LNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IdProducer = new System.Windows.Forms.TextBox();
            this.NameProducer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LNom
            // 
            this.LNom.AutoSize = true;
            this.LNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNom.Location = new System.Drawing.Point(69, 48);
            this.LNom.Name = "LNom";
            this.LNom.Size = new System.Drawing.Size(28, 25);
            this.LNom.TabIndex = 1;
            this.LNom.Text = "Id";
            this.LNom.Click += new System.EventHandler(this.LNom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Domaine";
            // 
            // IdProducer
            // 
            this.IdProducer.Location = new System.Drawing.Point(174, 52);
            this.IdProducer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdProducer.Name = "IdProducer";
            this.IdProducer.Size = new System.Drawing.Size(304, 22);
            this.IdProducer.TabIndex = 9;
            // 
            // NameProducer
            // 
            this.NameProducer.Location = new System.Drawing.Point(174, 106);
            this.NameProducer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameProducer.Name = "NameProducer";
            this.NameProducer.Size = new System.Drawing.Size(304, 22);
            this.NameProducer.TabIndex = 10;
            // 
            // ProducerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameProducer);
            this.Controls.Add(this.IdProducer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LNom);
            this.Name = "ProducerInfo";
            this.Size = new System.Drawing.Size(541, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdProducer;
        private System.Windows.Forms.TextBox NameProducer;
    }
}
