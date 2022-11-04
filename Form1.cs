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
using System.IO;

namespace CSharpWinFormProjects
{
    public partial class Form1 : Form
    {
        string namefile = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                namefile = file.FileName;
                StreamReader sr = new StreamReader(namefile, System.Text.Encoding.Default);
                Program.text = sr.ReadToEnd();
                textBox1.Text = Program.text;
                button2.Enabled = true;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
                textBox1.Text = Program.text;
        }

    }
}
