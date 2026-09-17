using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCaixaRetangular
{
    public partial class MainForm : Form
    {
        double Altura, Largura, Comprimento;
        bool ValidValues=false;

        private void txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool a = false;
                {

                }
                Altura = Convert.ToDouble(txtAltura.Text);
                Largura = Convert.ToDouble(txtLargura.Text);
                Comprimento = Convert.ToDouble(txtComprimento.Text);
            }
            catch
            {
                ValidValues = false;
            }
            ValidValues = true;

        }

        public MainForm()
        {
            InitializeComponent();
            txtAltura.Text = Altura.ToString();
            txtLargura.Text = Largura.ToString();
            txtComprimento.Text = Comprimento.ToString();
        }

        private void btCalcula_Click(object sender, EventArgs e)
        {

        }
    }
}
