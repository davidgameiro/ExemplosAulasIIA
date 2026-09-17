using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMatematica
{
    public partial class Form1 : Form
    {
        private int SomaVal1;
        private int SomaVal2;
        private int somaRes;
        private int SubtracaoVal1;
        private int SubtracaoVal2;
        private int SubtracaoRes;
        private int MultVal1;
        private int MultVal2;
        private int MultRes;
        private int DivRes;
        private int DivVal2;
        private int DivVal1;

        TimeSpan TempoDeJogo = new TimeSpan(0, 0, 20);
        DateTime GameStarted = new DateTime();

        public Form1()
        {
            InitializeComponent();
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            GerarValores();
            ColocarValores();
            GameStarted = DateTime.Now;
            ComutarLabelsResultados();
            lblMensagem.Text = "";
            Temporizador.Start();
        }
        /// <summary>
        /// Colocar os valores nas labels e numeric up down os numeros calculados
        /// </summary>
        private void ColocarValores()
        {
            lblSomaVal1.Text = SomaVal1.ToString();
            lblSomaVal2.Text = SomaVal2.ToString();
            lblResSoma.Text = somaRes.ToString();
            txtSoma.Text = "0";

            lblSubVal1.Text = SubtracaoVal1.ToString();
            lblSubVal2.Text = SubtracaoVal2.ToString();
            lblResSub.Text = SubtracaoRes.ToString();
            txtSub.Text = "0";

            lblMultVal1.Text = MultVal1.ToString();
            lblMultVal2.Text = MultVal2.ToString();
            lblResMult.Text = MultRes.ToString();
            txtMult.Text = "0";

            lblDivVal1.Text = DivVal1.ToString();
            lblDivVal2.Text = DivVal2.ToString();
            lblResDiv.Text = DivRes.ToString();
            txtDiv.Text = "0";
        }
        /// <summary>
        /// Gerar os numeros aleatorios para o jogo
        /// </summary>
        private void GerarValores()
        {
            Random rnd = new Random();
            //gerar numeros da soma
            SomaVal1 = rnd.Next(0, 9);
            SomaVal2 = rnd.Next(0, 9);
            somaRes = SomaVal1 + SomaVal2;
            //gerar numeros da subtração
            SubtracaoVal1 = rnd.Next(0, 9);
            SubtracaoVal2 = rnd.Next(0, 9);
            SubtracaoRes = SubtracaoVal1 - SubtracaoVal2;
            //gerar numeros da multiplicação
            MultVal1 = rnd.Next(0, 9);
            MultVal2 = rnd.Next(1, 9);
            MultRes = MultVal1 * MultVal2;
            //gerar numeros da divisão
            DivRes = rnd.Next(0, 9);
            DivVal2 = rnd.Next(1, 9);
            DivVal1 = DivRes * DivVal2;
        }
        /// <summary>
        /// Verificar se já passou o tempo maximo do jogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            TimeSpan TempoDecorrido = DateTime.Now.Subtract(GameStarted);
            int tmpSoma, tmpSub, tmpMult, tmpDiv;
            int.TryParse(txtSoma.Text, out tmpSoma);
            int.TryParse(txtSub.Text, out tmpSub);
            int.TryParse(txtMult.Text, out tmpMult);
            int.TryParse(txtDiv.Text, out tmpDiv);
            bool ganhou = ((somaRes+SubtracaoRes+MultRes+DivRes)==(tmpSoma+ tmpSub+ tmpMult+ tmpDiv));
            lblTempoDecorrido.Text = TempoDecorrido.ToString();
            //tempo já passou indicar resultado
            if (TempoDecorrido>TempoDeJogo || ganhou)
            {
                if (ganhou)
                {
                    //ganhou
                    lblMensagem.Text = "Parabens, acertaste nisto tudo";
                }
                else
                {
                    //errou
                    lblMensagem.Text = "Parabens, podes tentar novamente :-)";
                }
                ComutarLabelsResultados();
                Temporizador.Stop();
            }
        }
        /// <summary>
        /// Esconder ou mostrar as caixas
        /// </summary>
        private void ComutarLabelsResultados()
        {
            lblResSoma.Visible = !lblResSoma.Visible;
            lblResSub.Visible = !lblResSub.Visible;
            lblResMult.Visible = !lblResMult.Visible;
            lblResDiv.Visible = !lblResDiv.Visible;
        }
    }
}
