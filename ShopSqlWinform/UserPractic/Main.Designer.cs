namespace UserPractic
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датеПроведенияСкидкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(662, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.обновитьToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // товарToolStripMenuItem
            // 
            this.товарToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem1,
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem});
            this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            this.товарToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.товарToolStripMenuItem.Text = "Товар";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.button1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.button3_Click);
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиюToolStripMenuItem,
            this.ценеToolStripMenuItem,
            this.скидкеToolStripMenuItem,
            this.датеПроведенияСкидкиToolStripMenuItem});
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поискToolStripMenuItem1.Text = "Поиск";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // названиюToolStripMenuItem
            // 
            this.названиюToolStripMenuItem.Name = "названиюToolStripMenuItem";
            this.названиюToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.названиюToolStripMenuItem.Text = "Название";
            this.названиюToolStripMenuItem.Click += new System.EventHandler(this.FindProducts);
            // 
            // ценеToolStripMenuItem
            // 
            this.ценеToolStripMenuItem.Name = "ценеToolStripMenuItem";
            this.ценеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ценеToolStripMenuItem.Text = "Цену";
            this.ценеToolStripMenuItem.Click += new System.EventHandler(this.FindProducts);
            // 
            // скидкеToolStripMenuItem
            // 
            this.скидкеToolStripMenuItem.Name = "скидкеToolStripMenuItem";
            this.скидкеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.скидкеToolStripMenuItem.Text = "Скидку";
            this.скидкеToolStripMenuItem.Click += new System.EventHandler(this.FindProducts);
            // 
            // датеПроведенияСкидкиToolStripMenuItem
            // 
            this.датеПроведенияСкидкиToolStripMenuItem.Name = "датеПроведенияСкидкиToolStripMenuItem";
            this.датеПроведенияСкидкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.датеПроведенияСкидкиToolStripMenuItem.Text = "Дату проведения";
            this.датеПроведенияСкидкиToolStripMenuItem.Click += new System.EventHandler(this.FindProducts);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скидкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датеПроведенияСкидкиToolStripMenuItem;
    }
}

