using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var file in GetFiles())
            {
                richTextBoxText.AppendText(file + "\n");
            }
        }

        private List<string> GetFiles()
        {
            List<string> result = new List<string>();
            foreach (var files in Directory.GetFiles(textBoxPathFiles.Text))
            {
                result.Add(files);
                
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Путь";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathFiles.Text = Path.GetDirectoryName(saveFileDialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var file in GetFiles())
            {
                string copePath = Path.Combine(textBoxPathSave.Text, Path.GetFileName(file));
                File.Copy(file, copePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Новая папка";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathSave.Text = saveFileDialog.FileName;
                Directory.CreateDirectory(textBoxPathSave.Text);
            }
        }
    }
}
