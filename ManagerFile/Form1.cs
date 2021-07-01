using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerFile
{
    public partial class Form1 : Form
    {
        private Settings settings = null;
        private Thread thread = null;
        private bool hideForm = false;
        private bool copyAndDelete = false;
        public Form1(bool hideForm = false)
        {
            InitializeComponent();
            this.hideForm = hideForm;
        }

        private void SettingsLoad()
        {
            settings = Settings.Load();
            textBoxPathScan.Text = settings.PathScan;
            textBoxPathSave.Text = settings.PathSave;
            numericUpDown1.Value = settings.Interval / 1000 / 60;
            checkBoxSaveJurnal.Checked = settings.SaveJournal;
            LoadJournal();
            Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
            checkBoxAutoRun.Checked = Key.GetValue(Application.ProductName) != null;
            Key.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (hideForm)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
            else
            {
                this.Opacity = 100;
            }
            SettingsLoad();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            settings.PathScan = textBoxPathScan.Text;
            settings.Save();
        }

        /// <summary>
        /// Добавить текст
        /// </summary>
        /// <param name="text"></param>
        private void AddText(string text)
        {
            Invoke((MethodInvoker)delegate
            {
                RTextJournal.AppendText($"{DateTime.Now.ToString("dd.MM.yy")}{DateTime.Now.ToLongTimeString()}:{text}{"\n"}");
            });
        }

        /// <summary>
        /// Добавить заголовок
        /// </summary>
        /// <param name="textHeading"></param>
        private void AddHeader(string textHeading)
        {
            Invoke((MethodInvoker)delegate
            {
                RTextJournal.AppendText($"{"\n"}{DateTime.Now.ToString("dd.MM.yy")}{DateTime.Now.ToLongTimeString()}:{textHeading}**********************{"\n"}");
            });
        }

        /// <summary>
        /// Добавить Footer
        /// </summary>
        /// <param name="textFooter"></param>
        private void AddFooter(string textFooter)
        {
            Invoke((MethodInvoker)delegate
            {
                RTextJournal.AppendText($"{DateTime.Now.ToString("dd.MM.yy")}{DateTime.Now.ToLongTimeString()}:{textFooter}----------------------{"\n"}");
            });
        }

        /// <summary>
        /// Добавить описание ошибки
        /// </summary>
        /// <param name="textError"></param>
        private void AddError(string textError)
        {
            Invoke((MethodInvoker)delegate
            {
                AddText($"ОШИБКА - {textError}");
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LockButtons("Получение списка файлов");
            foreach (var file in GetFiles())
            {
                AddText(file);
            }
            UnLockButtons("Получение списка файлов закончено");
            SaveJournal();
        }

        private List<string> GetFiles()
        {
            string path = string.Empty;
            Invoke((MethodInvoker)delegate
            {
                path = textBoxPathScan.Text;
            });

            List<string> result = new List<string>();
            try
            {
                foreach (var files in Directory.GetFiles(path))
                {
                    result.Add(files);
                }
            }
            catch (Exception ex)
            {
                AddError(ex.Message);
            }
         
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Путь";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathScan.Text = Path.GetDirectoryName(saveFileDialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thread = new Thread(CopyFiles);
            thread.Start();
        }

        private void LockButtons(string text)
        {
            Invoke((MethodInvoker)delegate
            {
                buttonCopyFiles.Enabled = false;
                buttonGetFiles.Enabled = false;
                buttonDeleteFiles.Enabled = false;
                AddHeader(text);
            });
        }

        private void UnLockButtons(string text)
        {
            Invoke((MethodInvoker)delegate
            {
                buttonCopyFiles.Enabled = true;
                buttonGetFiles.Enabled = true;
                buttonDeleteFiles.Enabled = true;
                AddFooter(text);
            });
        }

        private void CopyFiles()
        {
            string path = string.Empty;
            bool checkError = false;
            LockButtons("Копирование файлов");

            Invoke((MethodInvoker)delegate
            {
                path = textBoxPathSave.Text;
            });

            foreach (var file in GetFiles())
            {
                try
                {
                    string copePath = Path.Combine(path, Path.GetFileName(file));
                    bool fileExists = System.IO.File.Exists(copePath);
                    int num = 2;
                    while (fileExists)
                    {
                        string newFile = $"{Path.GetFileNameWithoutExtension(copePath)}({num}){Path.GetExtension(copePath)}";
                        string newPath = Path.Combine(path, newFile);
                        if (System.IO.File.Exists(newPath))
                            num++;
                        else
                        {
                            copePath = newPath;
                            fileExists = false;
                        }
                    }

                    AddText($"Копирование файла - {Path.GetFileName(file)} -> {Path.GetFileName(copePath)}");
                    System.IO.File.Copy(file, copePath);
                }
                catch (Exception ex)
                {
                    checkError = true;
                    Invoke((MethodInvoker)delegate
                    {
                        AddError(ex.Message);
                    });
                }
            }
            UnLockButtons("Копирование файлов закончено");
            SaveJournal();
            if (copyAndDelete)
            {
                if (!checkError)
                {
                    thread = new Thread(DeleteFiles);
                    thread.Start();
                }
                else
                {
                    AddError("Возникли ошибки при копировании с целью сохранения данных удаление файлов не было запущено");
                }
            }
            copyAndDelete = false;
        }

        private void DeleteFiles()
        {
            LockButtons("Запущено удаление файлов");
            foreach (var file in GetFiles())
            {
                try
                {
                    AddText($"Удаление файла - {Path.GetFileName(file)}");
                    System.IO.File.Delete(file);
                }
                catch (Exception ex)
                {
                    AddError(ex.Message);
                }
            }
            UnLockButtons("Удаление файлов закончено");
            SaveJournal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Новая папка";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathSave.Text = saveFileDialog.FileName;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Удалить все файлы по пути : {textBoxPathScan.Text}", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                thread = new Thread(DeleteFiles);
                thread.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread != null)
                thread.Abort();
        }

        private void textBoxPathSave_TextChanged(object sender, EventArgs e)
        {
            settings.PathSave = textBoxPathSave.Text;
            settings.Save();
        }

        private void SaveJournal()
        {
            try
            {
                if (settings.SaveJournal)
                {
                    AddText("Запись в журнал");
                    Invoke((MethodInvoker)delegate
                    {
                        RTextJournal.SaveFile(Path.Combine(settings.PathSave, $"JournalManagerFile от {DateTime.Now.ToString("dd.MM.yy")}.rtf"));
                    });
                }
            }
            catch (Exception ex)
            {
                AddError(ex.Message);
            }
        }

        private void LoadJournal()
        {
            try
            {
                if (settings.SaveJournal)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        RTextJournal.LoadFile(Path.Combine(settings.PathSave, $"JournalManagerFile от {DateTime.Now.ToString("dd.MM.yy")}.rtf"));
                    });
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void timerGetFiles_Tick(object sender, EventArgs e)
        {
            SettingsLoad();
            copyAndDelete = true;
            thread = new Thread(CopyFiles);
            thread.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            settings.Interval = (int)(numericUpDown1.Value * 60 * 1000);
            timerGetFiles.Interval = settings.Interval;
            settings.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            settings.SaveJournal = checkBoxSaveJurnal.Checked;
            settings.Save();
        }

        private void checkBoxAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoRun.Checked)
            {
                string shortCutPath = Path.Combine(Environment.CurrentDirectory, $"{Application.ProductName}.lnk"); 
                                                                                                     
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortCutPath);
                shortcut.Arguments = "hideForm";
                shortcut.Hotkey = "Ctrl+Shift+M";
                shortcut.TargetPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                shortcut.WorkingDirectory = Environment.CurrentDirectory;
                // Создаем ярлык
                shortcut.Save();
                // Добавляем запись в реестр
                Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
                Key.SetValue(Application.ProductName, shortCutPath);
                Key.Close();
            }
            else
            {
                //Удаляем запись из реестра
                Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
                Key.DeleteValue(Application.ProductName, false);
                Key.Close();
            }
           
        }
    }
}
