using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurpriseButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show((2 / 3).ToString());
            Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            if (e.Y < button.Height / 3)
                button.Top += 20;
            else if (e.Y > 2 * button.Height / 3)
                button.Top -= 20;

            if (e.X < button.Width / 3 && button.Left + button.Width < ClientSize.Width)
                button.Left += 20;
            else if (e.X > 2 * button.Width / 3 && button.Left > 0)
                button.Left -= 20;
        }
    }
}
