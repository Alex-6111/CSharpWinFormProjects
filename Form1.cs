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
            this.Shown += GuessNumber;
        }

        private void GuessNumber(object sender, EventArgs e)
        {
            DialogResult result;
            int numDialog = 1;

            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "Your number", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show($"Number of requests {numDialog}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numDialog = 0;
                    result = MessageBox.Show($"Continue?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) this.Close();
                }
                numDialog++;
            }
        }
    }
}
