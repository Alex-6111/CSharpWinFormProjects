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
        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Quantity_day();
            }
            else
            {
                MessageBox.Show("Натисність ЛКМ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Quantity_day();
            }
        }

        private void Quantity_day()
        {
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;
            TimeSpan day = date1 - date2;
            label4.Text = Math.Abs(day.Days).ToString();
        }
    }
}
