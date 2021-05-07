
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
            this.поискПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PriceFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleDateFindСкидкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LabInfoDelete = new System.Windows.Forms.Label();
            this.TextBoxForDelete = new System.Windows.Forms.TextBox();
            this.ButtonDeleteProd = new System.Windows.Forms.Button();
            this.папапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.павпToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.павпавпToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.сортироватьПоToolStripMenuItem,
            this.поискПоToolStripMenuItem,
            this.папапToolStripMenuItem});
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
            this.OpenToolStripMenuItem1.Text = "Открыть";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить";
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
            this.PriceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PriceToolStripMenuItem.Text = "Цене";
            // 
            // возрастаниюToolStripMenuItem
            // 
            this.возрастаниюToolStripMenuItem.Name = "возрастаниюToolStripMenuItem";
            this.возрастаниюToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.возрастаниюToolStripMenuItem.Text = "возрастанию";
            // 
            // убываниюToolStripMenuItem
            // 
            this.убываниюToolStripMenuItem.Name = "убываниюToolStripMenuItem";
            this.убываниюToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.убываниюToolStripMenuItem.Text = "убыванию";
            // 
            // SaleToolStripMenuItem
            // 
            this.SaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.возрастаниюToolStripMenuItem1,
            this.убываниюToolStripMenuItem1});
            this.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem";
            this.SaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaleToolStripMenuItem.Text = "Скидке";
            // 
            // возрастаниюToolStripMenuItem1
            // 
            this.возрастаниюToolStripMenuItem1.Name = "возрастаниюToolStripMenuItem1";
            this.возрастаниюToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.возрастаниюToolStripMenuItem1.Text = "возрастанию";
            // 
            // убываниюToolStripMenuItem1
            // 
            this.убываниюToolStripMenuItem1.Name = "убываниюToolStripMenuItem1";
            this.убываниюToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.убываниюToolStripMenuItem1.Text = "убыванию";
            // 
            // поискПоToolStripMenuItem
            // 
            this.поискПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameFindToolStripMenuItem,
            this.PriceFindToolStripMenuItem,
            this.SaleFindToolStripMenuItem,
            this.SaleDateFindСкидкиToolStripMenuItem});
            this.поискПоToolStripMenuItem.Name = "поискПоToolStripMenuItem";
            this.поискПоToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.поискПоToolStripMenuItem.Text = "Поиск по:";
            // 
            // NameFindToolStripMenuItem
            // 
            this.NameFindToolStripMenuItem.Name = "NameFindToolStripMenuItem";
            this.NameFindToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.NameFindToolStripMenuItem.Text = "Названию";
            // 
            // PriceFindToolStripMenuItem
            // 
            this.PriceFindToolStripMenuItem.Name = "PriceFindToolStripMenuItem";
            this.PriceFindToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.PriceFindToolStripMenuItem.Text = "Цене";
            // 
            // SaleFindToolStripMenuItem
            // 
            this.SaleFindToolStripMenuItem.Name = "SaleFindToolStripMenuItem";
            this.SaleFindToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SaleFindToolStripMenuItem.Text = "Скидке";
            // 
            // SaleDateFindСкидкиToolStripMenuItem
            // 
            this.SaleDateFindСкидкиToolStripMenuItem.Name = "SaleDateFindСкидкиToolStripMenuItem";
            this.SaleDateFindСкидкиToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.SaleDateFindСкидкиToolStripMenuItem.Text = "Проведению скидки";
            // 
            // LabInfoDelete
            // 
            this.LabInfoDelete.AutoSize = true;
            this.LabInfoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabInfoDelete.Location = new System.Drawing.Point(12, 403);
            this.LabInfoDelete.Name = "LabInfoDelete";
            this.LabInfoDelete.Size = new System.Drawing.Size(227, 17);
            this.LabInfoDelete.TabIndex = 4;
            this.LabInfoDelete.Text = "Введите id товара для удаления:";
            // 
            // TextBoxForDelete
            // 
            this.TextBoxForDelete.Location = new System.Drawing.Point(245, 403);
            this.TextBoxForDelete.Name = "TextBoxForDelete";
            this.TextBoxForDelete.Size = new System.Drawing.Size(55, 20);
            this.TextBoxForDelete.TabIndex = 5;
            // 
            // ButtonDeleteProd
            // 
            this.ButtonDeleteProd.Location = new System.Drawing.Point(316, 403);
            this.ButtonDeleteProd.Name = "ButtonDeleteProd";
            this.ButtonDeleteProd.Size = new System.Drawing.Size(95, 20);
            this.ButtonDeleteProd.TabIndex = 6;
            this.ButtonDeleteProd.Text = "Удалить товар";
            this.ButtonDeleteProd.UseVisualStyleBackColor = true;
            // 
            // папапToolStripMenuItem
            // 
            this.папапToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.павпToolStripMenuItem,
            this.павпавпToolStripMenuItem});
            this.папапToolStripMenuItem.Name = "папапToolStripMenuItem";
            this.папапToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.папапToolStripMenuItem.Text = "папап";
            // 
            // павпToolStripMenuItem
            // 
            this.павпToolStripMenuItem.Name = "павпToolStripMenuItem";
            this.павпToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.павпToolStripMenuItem.Text = "павп";
            // 
            // павпавпToolStripMenuItem
            // 
            this.павпавпToolStripMenuItem.Name = "павпавпToolStripMenuItem";
            this.павпавпToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.павпавпToolStripMenuItem.Text = "павпавп";
            // 
            // ShopByHirutsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 432);
            this.Controls.Add(this.ButtonDeleteProd);
            this.Controls.Add(this.TextBoxForDelete);
            this.Controls.Add(this.LabInfoDelete);
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
        private System.Windows.Forms.ToolStripMenuItem поискПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PriceFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaleFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaleDateFindСкидкиToolStripMenuItem;
        private System.Windows.Forms.Label LabInfoDelete;
        private System.Windows.Forms.TextBox TextBoxForDelete;
        private System.Windows.Forms.Button ButtonDeleteProd;
        private System.Windows.Forms.ToolStripMenuItem папапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem павпToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem павпавпToolStripMenuItem;
    }
}

