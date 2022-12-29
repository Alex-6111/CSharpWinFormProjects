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
            this.Paint += Form1_Paint1;
        }

        private void Form1_Paint1(object sender, PaintEventArgs e)
        {
            bool isBlack = false;
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle();
            Graphics gfx = e.Graphics;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (isBlack)
                    {
                        rect = new Rectangle(i * 45, j * 45, 45, 45);
                        gfx.DrawRectangle(pen, rect);
                        gfx.FillRectangle(brush, rect);
                        isBlack = false;
                    }
                    else
                        isBlack = true;
                }
                isBlack = !isBlack;
            }
        }
    }
}
