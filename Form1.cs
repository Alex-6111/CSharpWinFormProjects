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
            Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Clear();
                if (listBox1.SelectedIndex != -1)
                {
                    var dirs = Directory.GetDirectories(listBox1.SelectedItem.ToString());
                    toolStripStatusLabel2.Text = listBox1.SelectedItem.ToString();
                    foreach (var dr in dirs)
                    {
                        listBox2.Items.Add(dr);
                    }

                    var files = Directory.GetFiles(listBox1.SelectedItem.ToString());

                    foreach (var file in files)
                    {
                        string[] tmp = file.Split(('\\'));
                        listBox2.Items.Add(tmp[tmp.Length - 1]);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void Start()
        {
            DriveInfo[] drive = DriveInfo.GetDrives();

            foreach (DriveInfo dr in drive)
            {
                listBox1.Items.Add(dr.Name);

                var dirs = Directory.GetDirectories(dr.Name);

                foreach (var dir in dirs)
                {
                    listBox1.Items.Add(dir);

                }
            }
        }
       
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedIndex != -1)
                {
                    var dirs = Directory.GetDirectories(listBox2.SelectedItem.ToString());
                    toolStripStatusLabel2.Text = listBox2.SelectedItem.ToString();
                    listBox2.Items.Clear();
                    foreach (var dr in dirs)
                    {
                        string[] tmp = dr.Split(('\\'));
                        listBox2.Items.Add(tmp[tmp.Length - 1]);
                    }

                    var files = Directory.GetFiles(listBox1.SelectedItem.ToString());

                    foreach (var file in files)
                    {
                        string[] tmp = file.Split(('\\'));
                        listBox2.Items.Add(tmp[tmp.Length - 1]);
                    }
                }
            }
            catch (Exception)
            {
            }
        }


    }
}
