﻿
namespace ShopWInForm
{
    partial class ShopByHirutsu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShopList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возрастаниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.убываниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ShopList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopList
            // 
            this.ShopList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.sale,
            this.DiscountPrice,
            this.StartSale,
            this.EndSale});
            this.ShopList.Location = new System.Drawing.Point(12, 28);
            this.ShopList.Name = "ShopList";
            this.ShopList.ReadOnly = true;
            this.ShopList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShopList.Size = new System.Drawing.Size(889, 360);
            this.ShopList.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // sale
            // 
            this.sale.HeaderText = "sale";
            this.sale.Name = "sale";
            this.sale.ReadOnly = true;
            // 
            // DiscountPrice
            // 
            this.DiscountPrice.HeaderText = "Discount Price";
            this.DiscountPrice.Name = "DiscountPrice";
            this.DiscountPrice.ReadOnly = true;
            // 
            // StartSale
            // 
            this.StartSale.HeaderText = "Start Sale";
            this.StartSale.Name = "StartSale";
            this.StartSale.ReadOnly = true;
            // 
            // EndSale
            // 
            this.EndSale.HeaderText = "End Sale";
            this.EndSale.Name = "EndSale";
            this.EndSale.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem1,
            this.добавитьТоварToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.открытьToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem1
            // 
            this.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1";
            this.OpenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem1.Text = "открыть";
            this.OpenToolStripMenuItem1.Click += new System.EventHandler(this.OpenToolStripMenuItem1_Click);
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PriceToolStripMenuItem,
            this.SaleToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по:";
            // 
            // PriceToolStripMenuItem
            // 
            this.PriceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.возрастаниюToolStripMenuItem,
            this.убываниюToolStripMenuItem});
            this.PriceToolStripMenuItem.Name = "PriceToolStripMenuItem";
            this.PriceToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.PriceToolStripMenuItem.Text = "Цене";
            // 
            // возрастаниюToolStripMenuItem
            // 
            this.возрастаниюToolStripMenuItem.Name = "возрастаниюToolStripMenuItem";
            this.возрастаниюToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.возрастаниюToolStripMenuItem.Text = "возрастанию";
            this.возрастаниюToolStripMenuItem.Click += new System.EventHandler(this.PriceUpToolStripMenuItem_Click);
            // 
            // убываниюToolStripMenuItem
            // 
            this.убываниюToolStripMenuItem.Name = "убываниюToolStripMenuItem";
            this.убываниюToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.убываниюToolStripMenuItem.Text = "убыванию";
            this.убываниюToolStripMenuItem.Click += new System.EventHandler(this.PriceDownToolStripMenuItem_Click);
            // 
            // SaleToolStripMenuItem
            // 
            this.SaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.возрастаниюToolStripMenuItem1,
            this.убываниюToolStripMenuItem1});
            this.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem";
            this.SaleToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.SaleToolStripMenuItem.Text = "Скидке";
            // 
            // возрастаниюToolStripMenuItem1
            // 
            this.возрастаниюToolStripMenuItem1.Name = "возрастаниюToolStripMenuItem1";
            this.возрастаниюToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.возрастаниюToolStripMenuItem1.Text = "возрастанию";
            this.возрастаниюToolStripMenuItem1.Click += new System.EventHandler(this.SaleUpToolStripMenuItem1_Click);
            // 
            // убываниюToolStripMenuItem1
            // 
            this.убываниюToolStripMenuItem1.Name = "убываниюToolStripMenuItem1";
            this.убываниюToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.убываниюToolStripMenuItem1.Text = "убыванию";
            this.убываниюToolStripMenuItem1.Click += new System.EventHandler(this.SaleDownToolStripMenuItem1_Click);
            // 
            // ShopByHirutsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 463);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShopByHirutsu";
            this.Text = "ShopByHirutsu";
            ((System.ComponentModel.ISupportInitialize)(this.ShopList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShopList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndSale;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возрастаниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem убываниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
    }
}
