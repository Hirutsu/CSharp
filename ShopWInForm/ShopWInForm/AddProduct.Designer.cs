
namespace ShopWInForm
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameProductTB = new System.Windows.Forms.TextBox();
            this.PriceProductTB = new System.Windows.Forms.TextBox();
            this.SaleProductTB = new System.Windows.Forms.TextBox();
            this.SaleStartTB = new System.Windows.Forms.TextBox();
            this.SaleEndTB = new System.Windows.Forms.TextBox();
            this.NameProductLab = new System.Windows.Forms.Label();
            this.PriceProductLab = new System.Windows.Forms.Label();
            this.SaleProductLab = new System.Windows.Forms.Label();
            this.SaleStartProductLab = new System.Windows.Forms.Label();
            this.SaleEndProductLab = new System.Windows.Forms.Label();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameProductTB
            // 
            this.NameProductTB.Location = new System.Drawing.Point(168, 8);
            this.NameProductTB.Name = "NameProductTB";
            this.NameProductTB.Size = new System.Drawing.Size(100, 20);
            this.NameProductTB.TabIndex = 0;
            // 
            // PriceProductTB
            // 
            this.PriceProductTB.Location = new System.Drawing.Point(168, 37);
            this.PriceProductTB.Name = "PriceProductTB";
            this.PriceProductTB.Size = new System.Drawing.Size(100, 20);
            this.PriceProductTB.TabIndex = 1;
            // 
            // SaleProductTB
            // 
            this.SaleProductTB.Location = new System.Drawing.Point(168, 66);
            this.SaleProductTB.Name = "SaleProductTB";
            this.SaleProductTB.Size = new System.Drawing.Size(100, 20);
            this.SaleProductTB.TabIndex = 2;
            // 
            // SaleStartTB
            // 
            this.SaleStartTB.Location = new System.Drawing.Point(168, 92);
            this.SaleStartTB.Name = "SaleStartTB";
            this.SaleStartTB.Size = new System.Drawing.Size(100, 20);
            this.SaleStartTB.TabIndex = 3;
            // 
            // SaleEndTB
            // 
            this.SaleEndTB.Location = new System.Drawing.Point(168, 119);
            this.SaleEndTB.Name = "SaleEndTB";
            this.SaleEndTB.Size = new System.Drawing.Size(100, 20);
            this.SaleEndTB.TabIndex = 4;
            // 
            // NameProductLab
            // 
            this.NameProductLab.AutoSize = true;
            this.NameProductLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameProductLab.Location = new System.Drawing.Point(12, 9);
            this.NameProductLab.Name = "NameProductLab";
            this.NameProductLab.Size = new System.Drawing.Size(76, 17);
            this.NameProductLab.TabIndex = 5;
            this.NameProductLab.Text = "Название:";
            // 
            // PriceProductLab
            // 
            this.PriceProductLab.AutoSize = true;
            this.PriceProductLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceProductLab.Location = new System.Drawing.Point(12, 38);
            this.PriceProductLab.Name = "PriceProductLab";
            this.PriceProductLab.Size = new System.Drawing.Size(47, 17);
            this.PriceProductLab.TabIndex = 6;
            this.PriceProductLab.Text = "Цена:";
            // 
            // SaleProductLab
            // 
            this.SaleProductLab.AutoSize = true;
            this.SaleProductLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleProductLab.Location = new System.Drawing.Point(12, 67);
            this.SaleProductLab.Name = "SaleProductLab";
            this.SaleProductLab.Size = new System.Drawing.Size(59, 17);
            this.SaleProductLab.TabIndex = 7;
            this.SaleProductLab.Text = "Скидка:";
            // 
            // SaleStartProductLab
            // 
            this.SaleStartProductLab.AutoSize = true;
            this.SaleStartProductLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleStartProductLab.Location = new System.Drawing.Point(12, 93);
            this.SaleStartProductLab.Name = "SaleStartProductLab";
            this.SaleStartProductLab.Size = new System.Drawing.Size(145, 17);
            this.SaleStartProductLab.TabIndex = 8;
            this.SaleStartProductLab.Text = "Начало проведения:";
            // 
            // SaleEndProductLab
            // 
            this.SaleEndProductLab.AutoSize = true;
            this.SaleEndProductLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleEndProductLab.Location = new System.Drawing.Point(12, 120);
            this.SaleEndProductLab.Name = "SaleEndProductLab";
            this.SaleEndProductLab.Size = new System.Drawing.Size(136, 17);
            this.SaleEndProductLab.TabIndex = 9;
            this.SaleEndProductLab.Text = "Конец проведения:";
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(83, 148);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(110, 39);
            this.ButtonAddProduct.TabIndex = 10;
            this.ButtonAddProduct.Text = "Добавить товар";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(280, 199);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.SaleEndProductLab);
            this.Controls.Add(this.SaleStartProductLab);
            this.Controls.Add(this.SaleProductLab);
            this.Controls.Add(this.PriceProductLab);
            this.Controls.Add(this.NameProductLab);
            this.Controls.Add(this.SaleEndTB);
            this.Controls.Add(this.SaleStartTB);
            this.Controls.Add(this.SaleProductTB);
            this.Controls.Add(this.PriceProductTB);
            this.Controls.Add(this.NameProductTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProduct";
            this.Text = "Добавление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameProductTB;
        private System.Windows.Forms.TextBox PriceProductTB;
        private System.Windows.Forms.TextBox SaleProductTB;
        private System.Windows.Forms.TextBox SaleStartTB;
        private System.Windows.Forms.TextBox SaleEndTB;
        private System.Windows.Forms.Label NameProductLab;
        private System.Windows.Forms.Label PriceProductLab;
        private System.Windows.Forms.Label SaleProductLab;
        private System.Windows.Forms.Label SaleStartProductLab;
        private System.Windows.Forms.Label SaleEndProductLab;
        private System.Windows.Forms.Button ButtonAddProduct;
    }
}