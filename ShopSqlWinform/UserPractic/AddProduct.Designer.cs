namespace UserPractic
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
            this.components = new System.ComponentModel.Container();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Sale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DTP_StartSale = new System.Windows.Forms.DateTimePicker();
            this.DTP_EndSale = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Price
            // 
            this.TB_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.TB_Price.Location = new System.Drawing.Point(129, 37);
            this.TB_Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(106, 32);
            this.TB_Price.TabIndex = 0;
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Name.Location = new System.Drawing.Point(8, 37);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(106, 32);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_Sale
            // 
            this.TB_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.TB_Sale.Location = new System.Drawing.Point(244, 37);
            this.TB_Sale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Sale.Name = "TB_Sale";
            this.TB_Sale.Size = new System.Drawing.Size(106, 32);
            this.TB_Sale.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(239, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Скидка";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(8, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DTP_StartSale
            // 
            this.DTP_StartSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DTP_StartSale.Location = new System.Drawing.Point(244, 73);
            this.DTP_StartSale.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_StartSale.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.DTP_StartSale.MinDate = new System.DateTime(1960, 6, 8, 0, 0, 0, 0);
            this.DTP_StartSale.Name = "DTP_StartSale";
            this.DTP_StartSale.Size = new System.Drawing.Size(106, 18);
            this.DTP_StartSale.TabIndex = 4;
            this.DTP_StartSale.Value = new System.DateTime(1998, 8, 16, 0, 0, 0, 0);
            // 
            // DTP_EndSale
            // 
            this.DTP_EndSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.DTP_EndSale.Location = new System.Drawing.Point(244, 95);
            this.DTP_EndSale.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_EndSale.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.DTP_EndSale.MinDate = new System.DateTime(1960, 6, 8, 0, 0, 0, 0);
            this.DTP_EndSale.Name = "DTP_EndSale";
            this.DTP_EndSale.Size = new System.Drawing.Size(106, 18);
            this.DTP_EndSale.TabIndex = 10;
            this.DTP_EndSale.Value = new System.DateTime(1998, 8, 16, 0, 0, 0, 0);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 122);
            this.Controls.Add(this.DTP_EndSale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTP_StartSale);
            this.Controls.Add(this.TB_Sale);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.TB_Price);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUser";
            this.Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Sale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker DTP_EndSale;
        private System.Windows.Forms.DateTimePicker DTP_StartSale;
    }
}