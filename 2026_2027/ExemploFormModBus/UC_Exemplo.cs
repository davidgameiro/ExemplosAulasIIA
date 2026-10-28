using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExemploFormModBus
{
    public partial class UC_Exemplo : UserControl
    {
        public UC_Exemplo()
        {
            InitializeComponent();
        }

        public void Atualiza(int Entrada, int Saida, string Nome)
        {
            label1.Text = Nome;
            checkBox1.BackColor = Entrada == 1 ? Color.Green : Color.Red;
            button1.BackColor = Saida == 1 ? Color.Green : Color.Red;
        }
    }
}
