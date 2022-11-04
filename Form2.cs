using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWinFormProjects
{
    public partial class Form2 : Form
    {
        Components compx;
        public Form2()
        {
            InitializeComponent();
        }

        public void New_component(Components pc)
        {
            compx = pc;
        }

        public void Chande_component(Components pc)
        {
            compx = pc;
            textBox1.Text = compx.Name;
            textBox2.Text = compx.Model;
            textBox3.Text = compx.Description;
            textBox4.Text = compx.Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Залишились пусті поля", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    compx.Name = textBox1.Text;
                    compx.Model = textBox2.Text;
                    compx.Description = textBox3.Text;
                    compx.Price = double.Parse(textBox4.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введіть ціну цифрою!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
