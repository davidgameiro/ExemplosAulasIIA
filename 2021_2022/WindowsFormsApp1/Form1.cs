using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            Batatas batataDoDia = new Batatas();
            double.TryParse(txtValor1.Text, out valor1);
            double.TryParse(txtValor2.Text, out valor2);
            batataDoDia.CorMiolo = valor1;
            batataDoDia.corPele = valor2;
            batataDoDia.Massa = valor2+valor1;
            //tenta converter se numero valido, caso contrario serão zeros

            txtResultado.Text = (valor1 + valor2).ToString();
            txtBatata.Text = batataDoDia.ToString();
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            double.TryParse(txtValor1.Text, out valor1);
            double.TryParse(txtValor2.Text, out valor2);
            //tenta converter se numero valido, caso contrario serão zeros

            txtResultado.Text = (valor1 - valor2).ToString();
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            double.TryParse(txtValor1.Text, out valor1);
            double.TryParse(txtValor2.Text, out valor2);
            //tenta converter se numero valido, caso contrario serão zeros

            txtResultado.Text = (valor1 * valor2).ToString();
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            double valor1, valor2;
            double.TryParse(txtValor1.Text, out valor1);
            double.TryParse(txtValor2.Text, out valor2);
            //tenta converter se numero valido, caso contrario serão zeros

            txtResultado.Text = (valor1 / valor2).ToString();
        }
    }
}
