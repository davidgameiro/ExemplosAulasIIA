using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtExpressao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }
            string expressao = txtExpressao.Text;
            string[] ElementosExpressao = expressao.Split(' ');
            if( ElementosExpressao.Length!=3 )
            {
                return;
            }
            double numero1, numero2;
            bool ConversaoOKNumero1 = double.TryParse(ElementosExpressao[0], out numero1);
            bool ConversaoOKNumero2 = double.TryParse(ElementosExpressao[2], out numero2);
            //se as conversões derem erro então ñ faço nada
            if (!ConversaoOKNumero1 && !ConversaoOKNumero2)
            {
                return;
            }

            double resultado;
            switch(ElementosExpressao[1])
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "x":
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                default:
                    return;
            }
            //processar a string e verificar se podemos realizar a operação
            txtResultado.Text = txtResultado.Text +"\n"+txtExpressao.Text+"="+resultado.ToString();
            txtExpressao.Clear();//apenas se operação for válida
        }
    }
}
