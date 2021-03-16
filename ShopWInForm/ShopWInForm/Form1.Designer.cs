
namespace ShopWInForm
{
    partial class Form1
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
            this.LoadDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShopList)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopList
            // 
            this.ShopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopList.Location = new System.Drawing.Point(12, 12);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(499, 307);
            this.ShopList.TabIndex = 0;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(517, 12);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(184, 27);
            this.LoadDataButton.TabIndex = 1;
            this.LoadDataButton.Text = "Загрузить";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.ShopList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ShopList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShopList;
        private System.Windows.Forms.Button LoadDataButton;
    }
}

