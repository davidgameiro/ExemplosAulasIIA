using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExemploFormModBus
{
    public partial class UCTest : UserControl
    {
        //public string Nome { get; set; } = "UCTest";
        public UCTest()
        {
            InitializeComponent();
           //gbName.Text = Name;  
        }

        public void Atualiza(int Entrada, int Saida, string Nome)
        {
            gbName.Text = Nome;
            lbEntrada.BackColor = Entrada == 1 ? Color.Green : Color.Red;
            lbSaida.BackColor = Saida == 1 ? Color.Green : Color.Red;
        }

    }
}
