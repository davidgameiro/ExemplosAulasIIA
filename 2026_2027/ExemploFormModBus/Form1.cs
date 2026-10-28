using System.Data;
using System.IO.Ports;

namespace ExemploFormModBus
{
    public partial class MainFrm : Form
    {
        const int numRegistos = 12;
        cModBus modbus;
        cModBus2 modbus2;
        public MainFrm()
        {
            InitializeComponent();
            modbus = new cModBus("127.0.0.1", 502, numRegistos);
            modbus2 = new cModBus2("127.0.0.1", 502);
            timer1.Interval = 200; // 200ms
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            SLbModBus.BackColor = modbus.ColorStatus;//ir buscar cor a classModbus
            tLbModBus2.BackColor = modbus2.ColorStatus;

            richTextBox1.Text = string.Join(Environment.NewLine, modbus.Valores.Select((v, i) => $"Registo {i}: {v}"));
            var valores = modbus2.Atualiza(0, numRegistos);
            if (valores.Count != numRegistos)
                return;

            richTextBox2.Text = string.Join(Environment.NewLine, valores.Select((v, i) => $"Registo {i}: {v}"));

            ucTest1.Atualiza(valores[0], valores[1], "Teste 1");
            ucTest2.Atualiza(valores[2], valores[3], "Teste 2");
            ucTest3.Atualiza(valores[4], valores[5], "Teste 3");
            ucTest4.Atualiza(valores[6], valores[7], "Teste 4");

            uC_Exemplo1.Atualiza(valores[8], valores[9], "Exemplo 1");
            uC_Exemplo2.Atualiza(valores[10], valores[11], "Exemplo 2");
            //gosto muito de dar exemplos os Tomás
        }
    }
}
