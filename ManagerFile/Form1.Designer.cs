namespace ManagerFile
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
            this.textBoxPathScan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPathSave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RTextJournal = new System.Windows.Forms.RichTextBox();
            this.buttonGetFiles = new System.Windows.Forms.Button();
            this.buttonCopyFiles = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonPathSave = new System.Windows.Forms.Button();
            this.buttonPathScan = new System.Windows.Forms.Button();
            this.buttonDeleteFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPathScan
            // 
            this.textBoxPathScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathScan.Location = new System.Drawing.Point(14, 49);
            this.textBoxPathScan.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPathScan.Name = "textBoxPathScan";
            this.textBoxPathScan.Size = new System.Drawing.Size(1015, 29);
            this.textBoxPathScan.TabIndex = 1;
            this.textBoxPathScan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь для сканирования";
            // 
            // textBoxPathSave
            // 
            this.textBoxPathSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPathSave.Location = new System.Drawing.Point(14, 109);
            this.textBoxPathSave.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPathSave.Name = "textBoxPathSave";
            this.textBoxPathSave.Size = new System.Drawing.Size(1015, 29);
            this.textBoxPathSave.TabIndex = 3;
            this.textBoxPathSave.TextChanged += new System.EventHandler(this.textBoxPathSave_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Путь для сохранения";
            // 
            // RTextJournal
            // 
            this.RTextJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTextJournal.Location = new System.Drawing.Point(16, 189);
            this.RTextJournal.Name = "RTextJournal";
            this.RTextJournal.Size = new System.Drawing.Size(1070, 285);
            this.RTextJournal.TabIndex = 6;
            this.RTextJournal.Text = "";
            // 
            // buttonGetFiles
            // 
            this.buttonGetFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetFiles.Location = new System.Drawing.Point(16, 148);
            this.buttonGetFiles.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGetFiles.Name = "buttonGetFiles";
            this.buttonGetFiles.Size = new System.Drawing.Size(243, 29);
            this.buttonGetFiles.TabIndex = 7;
            this.buttonGetFiles.Text = "Получить список файлов";
            this.buttonGetFiles.UseVisualStyleBackColor = true;
            this.buttonGetFiles.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCopyFiles
            // 
            this.buttonCopyFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCopyFiles.Location = new System.Drawing.Point(269, 148);
            this.buttonCopyFiles.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCopyFiles.Name = "buttonCopyFiles";
            this.buttonCopyFiles.Size = new System.Drawing.Size(243, 29);
            this.buttonCopyFiles.TabIndex = 8;
            this.buttonCopyFiles.Text = "Копировать";
            this.buttonCopyFiles.UseVisualStyleBackColor = true;
            this.buttonCopyFiles.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(930, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 25);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Автозапуск ПО";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonPathSave
            // 
            this.buttonPathSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathSave.BackgroundImage = global::ManagerFile.Properties.Resources.save_go;
            this.buttonPathSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPathSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPathSave.Location = new System.Drawing.Point(1028, 109);
            this.buttonPathSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPathSave.Name = "buttonPathSave";
            this.buttonPathSave.Size = new System.Drawing.Size(56, 29);
            this.buttonPathSave.TabIndex = 5;
            this.buttonPathSave.Text = " ";
            this.buttonPathSave.UseVisualStyleBackColor = true;
            this.buttonPathSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPathScan
            // 
            this.buttonPathScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathScan.BackgroundImage = global::ManagerFile.Properties.Resources.vision;
            this.buttonPathScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPathScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPathScan.Location = new System.Drawing.Point(1028, 49);
            this.buttonPathScan.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPathScan.Name = "buttonPathScan";
            this.buttonPathScan.Size = new System.Drawing.Size(56, 29);
            this.buttonPathScan.TabIndex = 0;
            this.buttonPathScan.UseVisualStyleBackColor = true;
            this.buttonPathScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteFiles
            // 
            this.buttonDeleteFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteFiles.Location = new System.Drawing.Point(522, 149);
            this.buttonDeleteFiles.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteFiles.Name = "buttonDeleteFiles";
            this.buttonDeleteFiles.Size = new System.Drawing.Size(243, 29);
            this.buttonDeleteFiles.TabIndex = 10;
            this.buttonDeleteFiles.Text = "Удалить";
            this.buttonDeleteFiles.UseVisualStyleBackColor = true;
            this.buttonDeleteFiles.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 486);
            this.Controls.Add(this.buttonDeleteFiles);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonCopyFiles);
            this.Controls.Add(this.buttonGetFiles);
            this.Controls.Add(this.RTextJournal);
            this.Controls.Add(this.buttonPathSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPathSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPathScan);
            this.Controls.Add(this.buttonPathScan);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "CopyFiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPathScan;
        private System.Windows.Forms.TextBox textBoxPathScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPathSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPathSave;
        private System.Windows.Forms.RichTextBox RTextJournal;
        private System.Windows.Forms.Button buttonGetFiles;
        private System.Windows.Forms.Button buttonCopyFiles;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonDeleteFiles;
    }
}

