using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWinFormProjects
{
    public partial class Form1 : Form
    {
        bool slabel = true;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("ДП");
            comboBox1.Items.Add("A-92");
            comboBox1.Items.Add("A-95");
            comboBox1.Text = comboBox1.Items[0].ToString();
            label7.Text = "0,00";
            label8.Text = "0,00";
            label10.Text = "0,00";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "50,00";
            textBox5.Text = "75,40";
            textBox6.Text = "35,20";
            textBox7.Text = "25,40";
            timer2.Enabled = true;
            timer2.Interval = 5000;
            toolStripDropDownButton1.Text = DateTime.Now.DayOfWeek.ToString();
            panel1.Visible = false;
            toolStripStatusLabel1.Text = DateTime.Now.ToString("D");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "55";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Text = "52";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Text = "57";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
            if (radioButton2.Checked == true)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = true;
                textBox2.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox8.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
            if (checkBox2.Checked == true)
            {
                textBox9.Enabled = true;
            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
            if (checkBox3.Checked == true)
            {
                textBox10.Enabled = true;
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
            if (checkBox4.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "0";
            }
            else
            {
                textBox11.Enabled = false;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Sum();
                timer1.Enabled = true;
                timer1.Interval = 10000;
            }
            else
            {
                MessageBox.Show("Натисніть ЛКМ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Sum();
                timer1.Enabled = true;
                timer1.Interval = 10000;
            }
            else
            {
                MessageBox.Show("Натиснута не вірна клавіша", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Sum()
        {
            double gas = double.Parse(textBox1.Text) * double.Parse(textBox2.Text) + double.Parse(textBox3.Text);
            label7.Text = String.Format("{0:f2}", gas);
            double kafe = double.Parse(textBox4.Text) * int.Parse(textBox8.Text) + double.Parse(textBox5.Text) * int.Parse(textBox9.Text) + double.Parse(textBox6.Text) * int.Parse(textBox10.Text) + double.Parse(textBox7.Text) * int.Parse(textBox11.Text);
            label8.Text = String.Format("{0:f2}", kafe);
            label10.Text = String.Format("{0:f2}", (gas + kafe));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Наступний клієнт?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (message == DialogResult.Yes)
            {
                timer1.Enabled = false;
                comboBox1.Items.Add("ДП");
                comboBox1.Items.Add("A-92");
                comboBox1.Items.Add("A-95");
                comboBox1.Text = comboBox1.Items[0].ToString();
                label7.Text = "0,00";
                label8.Text = "0,00";
                label10.Text = "0,00";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox8.Text = "0";
                textBox9.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox4.Text = "4,00";
                textBox5.Text = "55,40";
                textBox6.Text = "57,20";
                textBox7.Text = "54,40";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                //radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (slabel == true)
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToString("D");
                slabel = false;
            }
            else
            {
                toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm");
                slabel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
            button3.Visible = false;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb((trackBar1.Value) * 15, (trackBar2.Value) * 15, (trackBar3.Value) * 15);
        }

        private void ColorWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button3.Visible = true;
        }

        private void ukrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ua");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ua");

            System.ComponentModel.ComponentResourceManager resource = new ComponentResourceManager(this.GetType());
            resource.ApplyResources(this, "$this");
            foreach (Control c in Controls)
                resource.ApplyResources(c, c.Name);
        }

        private void engToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            System.ComponentModel.ComponentResourceManager resource = new ComponentResourceManager(this.GetType());
            resource.ApplyResources(this, "$this");
            foreach (Control c in Controls)
                resource.ApplyResources(c, c.Name);
        }
    }
}
