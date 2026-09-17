using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.BackColor==Color.Green)
            {
                this.BackColor = Color.White;
            }else
            {
                this.BackColor = Color.Green;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }
            int val;
            if (int.TryParse(textBox1.Text, out val) && val > 0)
            {
                timer1.Interval = val;
            }
        }
    }
}
