using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWinFormProjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += MousePosition;
            this.MouseClick += PointData;

        }

        private void PointData(object sender, MouseEventArgs e)
        {
            string text = "";
            if(e.Button == MouseButtons.Left)
            {
                if(ModifierKeys == Keys.Control)
                {
                    Close();
                }
                if((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    text = "The mouse is outside the rectangle";
                }
                else if((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    text = "The mouse is on the border of the rectangle";
                }
                else
                {
                    text = "The mouse is the rectangle";
                }
            }
            if(e.Button == MouseButtons.Right)
            {
                Text = $"Window size Width -> {ClientSize.Width}, Height -> {ClientSize.Height}";
                Thread.Sleep(2000);
            }
        }
        private void MousePosition(object sender, MouseEventArgs e)
        {
            Text = $"X ->  {e.X} - Y {e.Y}";
        }
    }
}
