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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Birthday()
        {
            DateTime birthday;

            try
            {
                birthday = new DateTime(int.Parse(textBox3.Text), int.Parse(textBox2.Text), int.Parse(textBox1.Text));
                monthCalendar1.SelectionStart = birthday;
                monthCalendar1.SelectionEnd = birthday;
            }
            catch (Exception)
            {
                MessageBox.Show("Дата введена не правильно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Birthday();
            }
        }
    }
}
