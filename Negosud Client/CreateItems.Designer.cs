
namespace Negosud_Client
{
    partial class CreateItems
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.boxPriceLabel = new System.Windows.Forms.Label();
            this.producerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.unitPriceBox = new System.Windows.Forms.TextBox();
            this.boxPriceBox = new System.Windows.Forms.TextBox();
            this.producerBox = new System.Windows.Forms.ComboBox();
            this.supplierBox = new System.Windows.Forms.ComboBox();
            this.validateItem = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.imgLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(47, 42);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nom";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(47, 202);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(86, 25);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Quantité";
            this.QuantityLabel.Click += new System.EventHandler(this.QuantityLabel_Click);
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.Location = new System.Drawing.Point(47, 252);
            this.unitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(113, 25);
            this.unitPriceLabel.TabIndex = 2;
            this.unitPriceLabel.Text = "Prix unitaire";
            // 
            // boxPriceLabel
            // 
            this.boxPriceLabel.AutoSize = true;
            this.boxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPriceLabel.Location = new System.Drawing.Point(47, 305);
            this.boxPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boxPriceLabel.Name = "boxPriceLabel";
            this.boxPriceLabel.Size = new System.Drawing.Size(131, 25);
            this.boxPriceLabel.TabIndex = 3;
            this.boxPriceLabel.Text = "Prix en carton";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerLabel.Location = new System.Drawing.Point(47, 366);
            this.producerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(107, 25);
            this.producerLabel.TabIndex = 4;
            this.producerLabel.Text = "Producteur";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(47, 98);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(57, 25);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.Location = new System.Drawing.Point(47, 426);
            this.supplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(115, 25);
            this.supplierLabel.TabIndex = 6;
            this.supplierLabel.Text = "Fournisseur";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(47, 149);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(70, 25);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Année";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(228, 34);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(827, 30);
            this.nameBox.TabIndex = 8;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.Location = new System.Drawing.Point(228, 142);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(827, 30);
            this.yearBox.TabIndex = 10;
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(228, 194);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(827, 30);
            this.quantityBox.TabIndex = 11;
            // 
            // unitPriceBox
            // 
            this.unitPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceBox.Location = new System.Drawing.Point(228, 245);
            this.unitPriceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unitPriceBox.Name = "unitPriceBox";
            this.unitPriceBox.Size = new System.Drawing.Size(827, 30);
            this.unitPriceBox.TabIndex = 12;
            // 
            // boxPriceBox
            // 
            this.boxPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPriceBox.Location = new System.Drawing.Point(228, 298);
            this.boxPriceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxPriceBox.Name = "boxPriceBox";
            this.boxPriceBox.Size = new System.Drawing.Size(827, 30);
            this.boxPriceBox.TabIndex = 13;
            // 
            // producerBox
            // 
            this.producerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerBox.FormattingEnabled = true;
            this.producerBox.Location = new System.Drawing.Point(228, 356);
            this.producerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(827, 33);
            this.producerBox.TabIndex = 14;
            // 
            // supplierBox
            // 
            this.supplierBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(228, 416);
            this.supplierBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(827, 33);
            this.supplierBox.TabIndex = 15;
            // 
            // validateItem
            // 
            this.validateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateItem.Location = new System.Drawing.Point(52, 556);
            this.validateItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.validateItem.Name = "validateItem";
            this.validateItem.Size = new System.Drawing.Size(160, 37);
            this.validateItem.TabIndex = 16;
            this.validateItem.Text = "Valider";
            this.validateItem.UseVisualStyleBackColor = true;
            this.validateItem.Click += new System.EventHandler(this.add_Click);
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(228, 89);
            this.typeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(827, 33);
            this.typeBox.TabIndex = 17;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(341, 498);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 18;
            // 
            // imgLabel
            // 
            this.imgLabel.AutoSize = true;
            this.imgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgLabel.Location = new System.Drawing.Point(47, 490);
            this.imgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(143, 25);
            this.imgLabel.TabIndex = 19;
            this.imgLabel.Text = "URL de l\'image";
            // 
            // imageBox
            // 
            this.imageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox.Location = new System.Drawing.Point(228, 486);
            this.imageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(827, 30);
            this.imageBox.TabIndex = 20;
            // 
            // CreateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.imgLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.validateItem);
            this.Controls.Add(this.supplierBox);
            this.Controls.Add(this.producerBox);
            this.Controls.Add(this.boxPriceBox);
            this.Controls.Add(this.unitPriceBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.producerLabel);
            this.Controls.Add(this.boxPriceLabel);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateItems";
            this.Size = new System.Drawing.Size(1273, 626);
            this.VisibleChanged += new System.EventHandler(this.CreateItems_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label boxPriceLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox unitPriceBox;
        private System.Windows.Forms.TextBox boxPriceBox;
        private System.Windows.Forms.ComboBox producerBox;
        private System.Windows.Forms.ComboBox supplierBox;
        private System.Windows.Forms.Button validateItem;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label imgLabel;
        private System.Windows.Forms.TextBox imageBox;
    }
}
