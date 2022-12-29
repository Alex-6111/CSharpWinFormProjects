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

        string name;
        string surname;
        string patronymic;
        string sex;
        DateTime birthday;
        string Family_status;
        string dop_info;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("чол.");
            comboBox1.Items.Add("жін.");
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Information();
            }
            else
            {
                MessageBox.Show("Натисніть ЛКМ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Information();
            }
        }

        private void Information()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
                textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                comboBox1.Text != "")
            {
                try
                {
                    int day = int.Parse(textBox4.Text);
                    int mon = int.Parse(textBox5.Text);
                    int year = int.Parse(textBox6.Text);
                    birthday = new DateTime(year, mon, day);
                    if (birthday > DateTime.Now)
                        MessageBox.Show("Дата народження вказане некоректно!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        using (StreamWriter sw = new StreamWriter("User_Information.txt", true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"ПІБ: {textBox1.Text} {textBox2.Text} {textBox3.Text}, Стать: {comboBox1.Text}, Дата народження: {birthday.ToString("D")}, " +
                                $"Сімейний статус: {textBox7.Text}, Дод. інфо: {textBox8.Text}");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Дата народження вказане некоректно!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не всі поля заповнено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
