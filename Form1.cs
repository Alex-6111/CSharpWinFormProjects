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

        string text = "";
        int line = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("TestData.txt", System.Text.Encoding.Default))
            {
                text += sr.ReadToEnd();
            }
            foreach (string tmp in text.Split('\n'))
            {
                listBox1.Items.Add(tmp);
            }
            line = (listBox1.Items.Count) / 100;


        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && progressBar1.Value != 100)
            {
                progressBar1.PerformStep();
            }
            else
            {
                progressBar1.Value = 100;
                MessageBox.Show("Текст зчитано", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new System.Drawing.SolidBrush(e.ForeColor), e.Bounds);
            }
        }
    }
}
