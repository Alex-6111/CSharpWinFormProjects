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
            MouseDown += FormMouseDown;
            MouseUp += FormMouseUp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int X { get; set; }
        int Y { get; set; }
        int NumStatic { get; set; } = 1;

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Label label = new Label();
                label.BorderStyle = BorderStyle.Fixed3D;
                if(e.X > X && e.Y > Y)
                {
                    label.Location = new Point(X, Y);
                }
                else if(e.X > X && e.Y < Y)
                {
                    label.Location = new Point(X, e.Y);
                }
                else if(e.X < X && e.Y < Y)
                {
                    label.Location = new Point(e.X, e.Y);
                }
                else
                {
                    label.Location = new Point(e.X,Y);
                }
                if (Math.Abs(e.X - X) <= 10 || Math.Abs(e.Y - Y) <= 10)
                {
                    MessageBox.Show("Unable to create static smaller than 10x10", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    label.Text = $"{NumStatic}";
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Red;
                    Controls.Add(label);
                    Text = $"Static # {label.Text} created!";
                    label.MouseClick += LabelMouseClick;
                    label.MouseDoubleClick += LabelMouseDoubleClick;
                    NumStatic++;
                }
            }
            else
            {
                MessageBox.Show("Press left mouse button to create static", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        Text = $"Static # {item.Text}, Area {item.Width * item.Height}, Сoordinates Х = {item.Location.X} Y = {item.Location.Y}";
                    }
                }
            }
        }

        private void LabelMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int numLabel = NumStatic;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        if (numLabel > Convert.ToInt32(item.Text))
                        {
                            numLabel = Convert.ToInt32(item.Text);
                        }
                    }
                }
                foreach (Label item in Controls)
                {
                    if (numLabel == Convert.ToInt32(item.Text))
                    {
                        Text = $"Static # {item.Text} deleted!";
                        Controls.Remove(item);
                        item.MouseClick -= LabelMouseClick;
                        item.MouseDoubleClick -= LabelMouseDoubleClick;
                    }
                }
            }
        }
    } 
}
