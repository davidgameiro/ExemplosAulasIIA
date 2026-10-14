using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ClienteModBus
{
    public partial class FrmClnt : Form
    {
        ModbusClient clnt=new ModbusClient("127.0.0.1",502);
        int num_reg=16;
        public FrmClnt()
        {
            InitializeComponent();
            AdicionarCabecalho();
            rb500.Checked = true;
        }
        //a cada intervalo de tempo verifica os novos dados
        private void timer1_Tick(object sender, EventArgs e)
        {
            StringBuilder txt = new StringBuilder();

            if (clnt.Connected)
            {
                btLigar.BackColor = SystemColors.Control;
                int[] res = null;
                try
                {
                    res = clnt.ReadHoldingRegisters(0, num_reg);
                }catch//houve erro a ler os dados
                {
                    DesligarModbus();
                    return;
                }
                
                txt.AppendLine();
                for (int i = 0; i < res.Length; i++)
                    txt.Append(res[i].ToString() + "\t");

                if (richTextBox1.Lines.Count()> 20)
                {
                    AdicionarCabecalho();
                }

                richTextBox1.AppendText(txt.ToString());
            }
            else
            {
                DesligarModbus();
            }
            

        }
        //Apenas adiciona o cabeçalho na richtextbox
        private void AdicionarCabecalho()
        {
            StringBuilder txt = new StringBuilder();
            for (int i = 0; i < num_reg; i++)
                txt.Append("reg"+i.ToString() + "\t");
            txt.AppendLine();
            richTextBox1.Text = txt.ToString();
        }
        //desliga o ModBus caso exista problema de conexão
        private void DesligarModbus()
        {
            clnt.Disconnect();
            timer1.Stop();
            btLigar.BackColor = Color.LightSalmon;
        }
        //Ligar ao cliente ModBus
        private void btLigar_Click(object sender, EventArgs e)
        {
            
            try
            {
                clnt.Connect();
            }
            catch //caso exista erro ao ligar ao servidor ModBus
            {
                DesligarModbus();
                return;
            }
            btLigar.BackColor = SystemColors.Control;
            timer1.Start();
        }
        //qual é o tempo de intervalo
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            string str_tempo = rb.Name.Substring(2, rb.Name.Length-2);

            int tempo = 500;

            if (int.TryParse(str_tempo, out tempo))
                timer1.Interval = tempo;
            
        }
    }
}
