namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1, valor2, resultado;
        string acao = "";
        public Form1()
        {
            InitializeComponent();
            txtValor_TextChanged(null, null);
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            acao = button.Tag.ToString();
            resultado = valor1 + valor2;
            txtResultado.Text = resultado.ToString();
            AtualizarHistorico();
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            acao = button.Tag.ToString();
            resultado = valor1 - valor2;
            txtResultado.Text = resultado.ToString();
            AtualizarHistorico();
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            acao = button.Tag.ToString();
            resultado = valor1 * valor2;
            txtResultado.Text = resultado.ToString();
            AtualizarHistorico();
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            acao = button.Tag.ToString();
            resultado = valor1 / valor2;
            txtResultado.Text = resultado.ToString();
            AtualizarHistorico();
        }

        private void AtualizarHistorico()
        {
            rtbHistorico.Text = rtbHistorico.Text+($" {DateTime.Now.ToString()} : {valor1} {acao} {valor2}={resultado}\n");
            rtbHistorico.SaveFile("C:\\PartilhaVM\\historico.txt", RichTextBoxStreamType.PlainText);
        }

        private void ToogleButtons(bool enable)
        {
            btSoma.Enabled = enable;
            btSubtracao.Enabled = enable;
            btMultiplicacao.Enabled = enable;
            btDivisao.Enabled = enable;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(txtValor1.Text);
                txtValor1.BackColor = Color.White;
                ToogleButtons(true);
            }
            catch
            {
                txtValor1.BackColor = Color.Red;
                valor1=0;
                ToogleButtons(false);
            }

            try
            {
                valor2 = double.Parse(txtValor2.Text);
                txtValor2.BackColor = Color.White;
                ToogleButtons(true);
            }
            catch
            {
                txtValor2.BackColor = Color.Red;
                valor2=0;
                ToogleButtons(false);
            }
            
        }
    }
}
