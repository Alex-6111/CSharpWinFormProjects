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
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpWinFormProjects
{
    public partial class Form1 : Form
    {
        List<Bus> buses = new List<Bus> ();
        public Form1()
        {
            InitializeComponent();
            DeserializeBus();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fr = new Form();
            fr.MdiParent = this;

            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            fr.Controls.Add(rtb);
            fr.Show();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Form form = new Form();
                form.MdiParent = this;

                RichTextBox richTextBox = new RichTextBox();
                richTextBox.Dock = DockStyle.Fill;
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.Default))
                {
                    richTextBox.Text = sr.ReadToEnd();
                }
                form.Controls.Add(richTextBox);
                form.Show();
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.* ";
                saveFileDialog1.FileName = "";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.ValidateNames = true;
                saveFileDialog1.FilterIndex = 1;
            }
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = this.ActiveMdiChild.Controls[0] as RichTextBox;
            rtb.Copy();
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = this.ActiveMdiChild.Controls[0] as RichTextBox;
            rtb.Cut();
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = this.ActiveMdiChild.Controls[0] as RichTextBox;
            rtb.Paste();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form fr = new Form();
            fr.MdiParent = this;

            RichTextBox rtb = new RichTextBox();
            Button button = new Button();

            fr.Text = "Прибытия в...";
            fr.ClientSize = new Size(300, 110);
            fr.MaximumSize = fr.MinimumSize = fr.ClientSize;
            button.Text = "Поиск";
            button.MouseClick += Search_Arival_To_Button_MouseClick;
            button.Size = new Size(50, 20);
            button.Top = fr.ClientSize.Height - (fr.ClientSize.Height / 3);
            button.Left = fr.ClientSize.Width - (fr.ClientSize.Width / 2) - 25;
            rtb.Size = new Size(fr.ClientSize.Width, fr.ClientSize.Height / 2);

            fr.Controls.Add(button);
            fr.Controls.Add(rtb);
            fr.Show();
        }

        private void Search_Arival_To_Button_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBox rtb = this.ActiveMdiChild.Controls[1] as RichTextBox;
            List<Bus> sa = new List<Bus>();
            foreach (var bus in buses)
            {
                if (bus.Destination.IndexOf(rtb.Text) != -1)
                {
                    sa.Add(bus);
                }
            }

            Form fr = new Form();
            fr.MdiParent = this;
            RichTextBox rtb_result = new RichTextBox();
            rtb_result.Dock = DockStyle.Fill;
            if (sa.Count > 0)
            {
                foreach (var res in sa)
                {
                    rtb_result.Text += $"Автобус #{res.Number}, Тип {res.Type}, Пункт призначення {res.Destination}, Дата і час відправки {res.Departure}, Дата і час прибуття {res.Arrivale}\n\n";
                }
            }
            else
                rtb_result.Text = "Автобус відсутній!";

            fr.Controls.Add(rtb_result);
            fr.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form fr = new Form();
            fr.MdiParent = this;

            RichTextBox number = new RichTextBox();
            RichTextBox type = new RichTextBox();
            RichTextBox destination = new RichTextBox();
            RichTextBox departure_date = new RichTextBox();
            RichTextBox departure_time = new RichTextBox();
            RichTextBox arrivale_date = new RichTextBox();
            RichTextBox arrivale_time = new RichTextBox();
            Button button = new Button();
            Button button1 = new Button();

            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();
            Label label5 = new Label();
            Label label6 = new Label();
            Label label7 = new Label();

            label1.Text = "Номер автобуса";
            label2.Text = "Тип автобуса";
            label3.Text = "Пункт призначення";
            label4.Text = "Дата відправлення\n (ДД/ММ/РРРР)";
            label5.Text = "Час відправки\n (ГОД:ХВ)";
            label6.Text = "Дата прибуття\n (ДД/ММ/РРРР)";
            label7.Text = "Час прибуття\n (ГОД:ХВ)";

            label1.Size = label2.Size = label3.Size = label4.Size = label5.Size = label6.Size = label7.Size = new Size(fr.ClientSize.Width / 2, 30);
            fr.Text = "Створення рейсу";
            fr.ClientSize = new Size(300, 400);
            fr.MaximumSize = fr.MinimumSize = fr.ClientSize;
            button.Text = "Зберегти";
            button1.Text = "Відмінити";
            button.MouseClick += Save_Bus;
            button1.MouseClick += Cansel_Bus;
            button.Size = new Size(70, 20);
            button1.Size = new Size(70, 20);
            button.Top = fr.ClientSize.Height - (fr.ClientSize.Height / 10);
            button.Left = fr.ClientSize.Width - (fr.ClientSize.Width / 2) - 100;
            button1.Top = fr.ClientSize.Height - (fr.ClientSize.Height / 10);
            button1.Left = fr.ClientSize.Width - (fr.ClientSize.Width / 2) + 25;
            destination.Size = type.Size = number.Size = departure_date.Size = departure_time.Size = arrivale_date.Size = arrivale_time.Size = new Size(fr.ClientSize.Width / 2, 20);
            label1.Top = number.Top = 10;
            label2.Top = type.Top = number.Top + 40;
            label3.Top = destination.Top = type.Top + 40;
            label4.Top = departure_date.Top = destination.Top + 40;
            label5.Top = departure_time.Top = departure_date.Top + 40;
            label6.Top = arrivale_date.Top = departure_time.Top + 40;
            label7.Top = arrivale_time.Top = arrivale_date.Top + 40;
            number.Left = type.Left = destination.Left = departure_date.Left = departure_time.Left = arrivale_date.Left = arrivale_time.Left = fr.ClientSize.Width / 2;
            label1.Left = label2.Left = label3.Left = label4.Left = label5.Left = label6.Left = label7.Left = 5;



            fr.Controls.Add(button);
            fr.Controls.Add(button1);
            fr.Controls.Add(number);
            fr.Controls.Add(type);
            fr.Controls.Add(destination);
            fr.Controls.Add(departure_date);
            fr.Controls.Add(departure_time);
            fr.Controls.Add(arrivale_date);
            fr.Controls.Add(arrivale_time);
            fr.Controls.Add(label1);
            fr.Controls.Add(label2);
            fr.Controls.Add(label3);
            fr.Controls.Add(label4);
            fr.Controls.Add(label5);
            fr.Controls.Add(label6);
            fr.Controls.Add(label7);
            fr.Show();
        }

        private void Save_Bus(object sender, MouseEventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                Form fr = ActiveMdiChild;
                RichTextBox[] bus_info = new RichTextBox[7];
                int i = 0;
                foreach (RichTextBox rtb in fr.Controls.OfType<RichTextBox>())
                {
                    bus_info[i] = rtb;
                    i++;
                }
                if (bus_info[0].Text != "" && bus_info[1].Text != "" && bus_info[2].Text != "" && bus_info[3].Text != "" &&
                    bus_info[4].Text != "" && bus_info[5].Text != "" && bus_info[6].Text != "")
                {
                    try
                    {
                        Bus bus = new Bus();
                        bus.Number = bus_info[0].Text;
                        bus.Type = bus_info[1].Text;
                        bus.Destination = bus_info[2].Text;
                        string[] departure_date = bus_info[3].Text.Split('\\', '/', '.');
                        string[] departure_time = bus_info[4].Text.Split(':', '.');
                        bus.Departure = new DateTime(int.Parse(departure_date[2]), int.Parse(departure_date[1]), int.Parse(departure_date[0]), int.Parse(departure_time[0]), int.Parse(departure_time[1]), 0);
                        string[] arrivale_date = bus_info[5].Text.Split('\\', '/', '.');
                        string[] arrivale_time = bus_info[6].Text.Split(':', '.');
                        bus.Arrivale = new DateTime(int.Parse(arrivale_date[2]), int.Parse(arrivale_date[1]), int.Parse(arrivale_date[0]), int.Parse(arrivale_time[0]), int.Parse(arrivale_time[1]), 0);

                        buses.Add(bus);

                        var formatter = new XmlSerializer(typeof(List<Bus>));

                        using (FileStream fs = new FileStream("Bus.xml", FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, buses);
                        }

                        MessageBox.Show("Рейс збережено", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Не вірно вказана дата чи час", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не всі поля заповнені!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cansel_Bus(object sender, MouseEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void DeserializeBus()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Bus>));

            using (FileStream fs = new FileStream("Bus.xml", FileMode.OpenOrCreate))
            {
                buses = (List<Bus>)formatter.Deserialize(fs);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Show_Bus();
        }

        private void Show_Bus()
        {
            Form fr = new Form();
            fr.MdiParent = this;

            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;

            foreach (var res in buses)
                rtb.Text += $"Автобус #{res.Number}, Тип {res.Type}, Пункт призначення {res.Destination}, Дата і час відправлення {res.Departure}, Дата і час прибуття {res.Arrivale}\n\n";


            fr.Controls.Add(rtb);
            fr.Show();
        }









    }
}
