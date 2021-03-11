
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
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(37, 77);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nom";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(37, 207);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(70, 20);
            this.QuantityLabel.TabIndex = 1;
            this.QuantityLabel.Text = "Quantité";
            this.QuantityLabel.Click += new System.EventHandler(this.QuantityLabel_Click);
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.Location = new System.Drawing.Point(37, 248);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(90, 20);
            this.unitPriceLabel.TabIndex = 2;
            this.unitPriceLabel.Text = "Prix unitaire";
            // 
            // boxPriceLabel
            // 
            this.boxPriceLabel.AutoSize = true;
            this.boxPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPriceLabel.Location = new System.Drawing.Point(37, 291);
            this.boxPriceLabel.Name = "boxPriceLabel";
            this.boxPriceLabel.Size = new System.Drawing.Size(105, 20);
            this.boxPriceLabel.TabIndex = 3;
            this.boxPriceLabel.Text = "Prix en carton";
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerLabel.Location = new System.Drawing.Point(37, 340);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(87, 20);
            this.producerLabel.TabIndex = 4;
            this.producerLabel.Text = "Producteur";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(37, 123);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(43, 20);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.Location = new System.Drawing.Point(37, 389);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(93, 20);
            this.supplierLabel.TabIndex = 6;
            this.supplierLabel.Text = "Fournisseur";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(37, 164);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(56, 20);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Année";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(173, 71);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(621, 26);
            this.nameBox.TabIndex = 8;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.Location = new System.Drawing.Point(173, 158);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(621, 26);
            this.yearBox.TabIndex = 10;
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(173, 201);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(621, 26);
            this.quantityBox.TabIndex = 11;
            // 
            // unitPriceBox
            // 
            this.unitPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceBox.Location = new System.Drawing.Point(173, 242);
            this.unitPriceBox.Name = "unitPriceBox";
            this.unitPriceBox.Size = new System.Drawing.Size(621, 26);
            this.unitPriceBox.TabIndex = 12;
            // 
            // boxPriceBox
            // 
            this.boxPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPriceBox.Location = new System.Drawing.Point(173, 285);
            this.boxPriceBox.Name = "boxPriceBox";
            this.boxPriceBox.Size = new System.Drawing.Size(621, 26);
            this.boxPriceBox.TabIndex = 13;
            // 
            // producerBox
            // 
            this.producerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producerBox.FormattingEnabled = true;
            this.producerBox.Location = new System.Drawing.Point(173, 332);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(621, 28);
            this.producerBox.TabIndex = 14;
            // 
            // supplierBox
            // 
            this.supplierBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBox.FormattingEnabled = true;
            this.supplierBox.Location = new System.Drawing.Point(173, 381);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(621, 28);
            this.supplierBox.TabIndex = 15;
            // 
            // validateItem
            // 
            this.validateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateItem.Location = new System.Drawing.Point(41, 438);
            this.validateItem.Name = "validateItem";
            this.validateItem.Size = new System.Drawing.Size(120, 30);
            this.validateItem.TabIndex = 16;
            this.validateItem.Text = "Valider";
            this.validateItem.UseVisualStyleBackColor = true;
            this.validateItem.Click += new System.EventHandler(this.add_Click);
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(173, 115);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(621, 28);
            this.typeBox.TabIndex = 17;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(258, 448);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 18;
            // 
            // CreateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "CreateItems";
            this.Size = new System.Drawing.Size(955, 509);
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
    }
}
