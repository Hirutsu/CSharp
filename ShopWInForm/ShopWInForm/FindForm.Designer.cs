
namespace ShopWInForm
{
    partial class FindForm
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
            this.TextBoxFind = new System.Windows.Forms.TextBox();
            this.Поиск = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxFind
            // 
            this.TextBoxFind.Location = new System.Drawing.Point(13, 12);
            this.TextBoxFind.Name = "TextBoxFind";
            this.TextBoxFind.Size = new System.Drawing.Size(160, 20);
            this.TextBoxFind.TabIndex = 0;
            // 
            // Поиск
            // 
            this.Поиск.Location = new System.Drawing.Point(54, 38);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(75, 23);
            this.Поиск.TabIndex = 1;
            this.Поиск.Text = "Поиск";
            this.Поиск.UseVisualStyleBackColor = true;
            this.Поиск.Click += new System.EventHandler(this.Поиск_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 70);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.TextBoxFind);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxFind;
        private System.Windows.Forms.Button Поиск;
    }
}