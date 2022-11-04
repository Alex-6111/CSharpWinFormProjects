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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Шлях";
        }
        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            sf.FilterIndex = 1;
            sf.Title = "New File";
            sf.FileName = "new_file";
            sf.DefaultExt = "txt";
            sf.ValidateNames = true;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                textBox1.Clear();
                Text = sf.FileName;
                using (StreamWriter sw = new StreamWriter(sf.FileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(textBox1.Text);
                    MessageBox.Show("Створено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Text = open.FileName;
                using (StreamReader sr = new StreamReader(open.FileName, System.Text.Encoding.Default))
                {
                    textBox1.Text = sr.ReadToEnd();
                }
            }
        }
        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Text, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(textBox1.Text);
                MessageBox.Show("Збережено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            sf.FilterIndex = 1;
            sf.Title = "Save as";
            sf.DefaultExt = "txt";
            sf.ValidateNames = true;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sf.FileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(textBox1.Text);
                    MessageBox.Show("Збережено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox1.ClearUndo();
        }
      
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void ToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fd.Font;
            }
        }

        private void ToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = cd.Color;
            }
        }

        private void ToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = cd.Color;
            }
        }
    }
}
