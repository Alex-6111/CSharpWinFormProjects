using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace CSharpWinFormProjects
{
    public partial class Form1 : Form
    {
        public static List<Components> components1 = new List<Components>();
        public Form1()
        {
            InitializeComponent();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Components>));
            using (FileStream fs = new FileStream("Components.xml", FileMode.OpenOrCreate))
            {
                components1 = (List<Components>)formatter.Deserialize(fs);
            }
            if (components1.Count > 0)
            {
                foreach (var _comp in components1)
                {
                    comboBox1.Items.Add(_comp.Name);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Components component = new Components();
            Form2 form2 = new Form2();
            form2.New_component(component);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                components1.Add(component);
                comboBox1.Items.Add(component.Name);

                XmlSerializer formatter = new XmlSerializer(typeof(List<Components>));
                using (FileStream fs = new FileStream("Components.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, components);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Components component = new Components();
            Form2 form2 = new Form2();
            if (comboBox1.SelectedIndex != -1)
            {

                int index = comboBox1.SelectedIndex;
                component = components1.ElementAt(index);
                form2.Chande_component(component);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    components1.RemoveAt(index);
                    components1.Insert(index, component);

                    XmlSerializer formatter = new XmlSerializer(typeof(List<Components>));
                    using (FileStream fs = new FileStream("Components.xml", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, components1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Товар вибрано не правильно", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                textBox2.Text = components1.ElementAt(comboBox1.SelectedIndex).Description;
                textBox1.Text = components1.ElementAt(comboBox1.SelectedIndex).Price.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Items[comboBox1.SelectedIndex]);
            label6.Text = (double.Parse(label6.Text) + double.Parse(textBox1.Text)).ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label6.Text = "0,00";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
