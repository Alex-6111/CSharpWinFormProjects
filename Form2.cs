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

namespace CSharpWinFormProjects
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FolderBrowserDialog dir = new FolderBrowserDialog();
                dir.ShowNewFolderButton = false;
                if (dir.ShowDialog() == DialogResult.OK)
                {
                    label1.Text = dir.SelectedPath;
                }
                else
                {
                    dir = null;
                    label1.Text = "";
                }
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                if (textBox2.Text.Length > 2 && textBox2.Text != "")
                {
                    listBox1.Items.Clear();
                    DirectoryInfo df = new DirectoryInfo(label1.Text);
                    foreach (var file in df.GetFiles())
                    {
                        string fs = file.Name;
                        if (fs.IndexOf(textBox2.Text) != -1)
                        {
                            listBox1.Items.Add(file.Directory + "\\" + file.Name);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не правильне ім'я", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Виберіть папку", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
