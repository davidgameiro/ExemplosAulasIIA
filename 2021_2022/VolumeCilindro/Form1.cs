using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt;
            txt = sender as TextBox;

            lblTextName.Text = txt.Name;
            //txt = (TextBox)sender;
            //verificar se a caixa de texto que originou o evento está vazia?
            if(string.IsNullOrEmpty(txt.Text))
            {
                txt.BackColor = Color.White;
            }else
            {
                double a;
                txt.BackColor = Color.Green;
                if (double.TryParse(txt.Text, out a) == false)
                {
                    txt.BackColor = Color.Red;
                }
                //try
                //{
                //    a = Convert.ToDouble(txt.Text);
                //    txt.BackColor = Color.Green;
                //}
                //catch
                //{
                //    txt.BackColor = Color.Red;
                //}
            }
        }
    }
}
