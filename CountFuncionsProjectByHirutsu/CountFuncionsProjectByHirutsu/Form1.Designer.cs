
namespace CountFuncionsProjectByHirutsu
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
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LabelNameFile = new System.Windows.Forms.Label();
            this.ButtonCountFunctions = new System.Windows.Forms.Button();
            this.ButtonSafeCountFunctions = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(15, 37);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(498, 32);
            this.ButtonOpen.TabIndex = 0;
            this.ButtonOpen.Text = "Открыть";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LabelNameFile
            // 
            this.LabelNameFile.Location = new System.Drawing.Point(12, 9);
            this.LabelNameFile.Name = "LabelNameFile";
            this.LabelNameFile.Size = new System.Drawing.Size(402, 25);
            this.LabelNameFile.TabIndex = 1;
            this.LabelNameFile.Text = "Файл не открыт";
            // 
            // ButtonCountFunctions
            // 
            this.ButtonCountFunctions.Location = new System.Drawing.Point(12, 75);
            this.ButtonCountFunctions.Name = "ButtonCountFunctions";
            this.ButtonCountFunctions.Size = new System.Drawing.Size(498, 32);
            this.ButtonCountFunctions.TabIndex = 2;
            this.ButtonCountFunctions.Text = "Прочитать данные";
            this.ButtonCountFunctions.UseVisualStyleBackColor = true;
            this.ButtonCountFunctions.Click += new System.EventHandler(this.ButtonCountFunctions_Click);
            // 
            // ButtonSafeCountFunctions
            // 
            this.ButtonSafeCountFunctions.Location = new System.Drawing.Point(12, 113);
            this.ButtonSafeCountFunctions.Name = "ButtonSafeCountFunctions";
            this.ButtonSafeCountFunctions.Size = new System.Drawing.Size(498, 32);
            this.ButtonSafeCountFunctions.TabIndex = 3;
            this.ButtonSafeCountFunctions.Text = "Сохранить данные";
            this.ButtonSafeCountFunctions.UseVisualStyleBackColor = true;
            this.ButtonSafeCountFunctions.Click += new System.EventHandler(this.ButtonSafeCountFunctions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 158);
            this.Controls.Add(this.ButtonSafeCountFunctions);
            this.Controls.Add(this.ButtonCountFunctions);
            this.Controls.Add(this.LabelNameFile);
            this.Controls.Add(this.ButtonOpen);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "CountFunctionsProjectByHirutsu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelNameFile;
        private System.Windows.Forms.Button ButtonCountFunctions;
        private System.Windows.Forms.Button ButtonSafeCountFunctions;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

