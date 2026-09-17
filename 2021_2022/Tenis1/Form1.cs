using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis1
{
    public partial class Form1 : Form
    {
        //array com os dados com os resultados do Tenis
        const int NrElementos = 10;
        int[] Pontuacoes = new int[NrElementos];
        int PosOcupada=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btArray_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtArray.Text))
            {
                return;
            }
            int ValorInserir = Convert.ToInt32(txtArray.Text);
            Pontuacoes[PosOcupada] = ValorInserir;
            PosOcupada = PosOcupada + 1;
            //PosOcupada++;
            //++PosOcupada;
            //PosOcupada += 1;
            if(PosOcupada>=10)
            {
                btArray.Enabled = false;
            }
            //lbArray.Items.Clear();
            for(int i= lbArray.Items.Count; i < PosOcupada; i++)
            {
                lbArray.Items.Add(Pontuacoes[i]);
            }
        }

        List<int> PontucoesLista = new List<int>();
        private void btLista_Click(object sender, EventArgs e)
        {

        }
    }
}
