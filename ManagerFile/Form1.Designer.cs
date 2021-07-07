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
            this.components = new System.ComponentModel.Container();
            this.textBoxPathScan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTextJournal = new System.Windows.Forms.RichTextBox();
            this.buttonGetFiles = new System.Windows.Forms.Button();
            this.checkBoxAutoRun = new System.Windows.Forms.CheckBox();
            this.buttonPathScan = new System.Windows.Forms.Button();
            this.buttonDeleteFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timerGetFiles = new System.Windows.Forms.Timer(this.components);
            this.checkBoxSaveJurnal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // RTextJournal
            // 
            this.RTextJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTextJournal.Location = new System.Drawing.Point(14, 185);
            this.RTextJournal.Name = "RTextJournal";
            this.RTextJournal.Size = new System.Drawing.Size(1070, 289);
            this.RTextJournal.TabIndex = 6;
            this.RTextJournal.Text = "";
            // 
            // buttonGetFiles
            // 
            this.buttonGetFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetFiles.Location = new System.Drawing.Point(14, 148);
            this.buttonGetFiles.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGetFiles.Name = "buttonGetFiles";
            this.buttonGetFiles.Size = new System.Drawing.Size(243, 29);
            this.buttonGetFiles.TabIndex = 7;
            this.buttonGetFiles.Text = "Получить список файлов";
            this.buttonGetFiles.UseVisualStyleBackColor = true;
            this.buttonGetFiles.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxAutoRun
            // 
            this.checkBoxAutoRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoRun.AutoSize = true;
            this.checkBoxAutoRun.Location = new System.Drawing.Point(932, 94);
            this.checkBoxAutoRun.Name = "checkBoxAutoRun";
            this.checkBoxAutoRun.Size = new System.Drawing.Size(154, 25);
            this.checkBoxAutoRun.TabIndex = 9;
            this.checkBoxAutoRun.Text = "Автозапуск ПО";
            this.checkBoxAutoRun.UseVisualStyleBackColor = true;
            this.checkBoxAutoRun.CheckedChanged += new System.EventHandler(this.checkBoxAutoRun_CheckedChanged);
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
            this.buttonDeleteFiles.Location = new System.Drawing.Point(267, 148);
            this.buttonDeleteFiles.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteFiles.Name = "buttonDeleteFiles";
            this.buttonDeleteFiles.Size = new System.Drawing.Size(243, 29);
            this.buttonDeleteFiles.TabIndex = 10;
            this.buttonDeleteFiles.Text = "Удалить";
            this.buttonDeleteFiles.UseVisualStyleBackColor = true;
            this.buttonDeleteFiles.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Интервал сканирования (секунды)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 109);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(277, 29);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timerGetFiles
            // 
            this.timerGetFiles.Enabled = true;
            this.timerGetFiles.Interval = 60000;
            this.timerGetFiles.Tick += new System.EventHandler(this.timerGetFiles_Tick);
            // 
            // checkBoxSaveJurnal
            // 
            this.checkBoxSaveJurnal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSaveJurnal.AutoSize = true;
            this.checkBoxSaveJurnal.Location = new System.Drawing.Point(747, 94);
            this.checkBoxSaveJurnal.Name = "checkBoxSaveJurnal";
            this.checkBoxSaveJurnal.Size = new System.Drawing.Size(179, 25);
            this.checkBoxSaveJurnal.TabIndex = 13;
            this.checkBoxSaveJurnal.Text = "Сохранять журнал";
            this.checkBoxSaveJurnal.UseVisualStyleBackColor = true;
            this.checkBoxSaveJurnal.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 486);
            this.Controls.Add(this.checkBoxSaveJurnal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeleteFiles);
            this.Controls.Add(this.checkBoxAutoRun);
            this.Controls.Add(this.buttonGetFiles);
            this.Controls.Add(this.RTextJournal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPathScan);
            this.Controls.Add(this.buttonPathScan);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.Text = "DeleteFiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPathScan;
        private System.Windows.Forms.TextBox textBoxPathScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTextJournal;
        private System.Windows.Forms.Button buttonGetFiles;
        private System.Windows.Forms.CheckBox checkBoxAutoRun;
        private System.Windows.Forms.Button buttonDeleteFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timerGetFiles;
        private System.Windows.Forms.CheckBox checkBoxSaveJurnal;
    }
}

