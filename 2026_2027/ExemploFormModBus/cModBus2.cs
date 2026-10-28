using EasyModbus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploFormModBus
{
    internal class cModBus2
    {
        private readonly ModbusClient modbusClient;

        public bool Connected { get; private set; } = false;
        
        public Color ColorStatus => Connected ? Color.Green : Color.Red;    

        public cModBus2(string ipAddress, int port)
        {
            this.modbusClient = new ModbusClient(ipAddress, port)
            {
                ConnectionTimeout = 1000 // 1 segundo de timeout
            };
            // Implementação do construtor
        }

        public List<int> Atualiza(int startAddress, int numRegistos)
        {
            List<int> valores = new List<int>();
            try
            {
                if (!Connected)
                {
                    modbusClient.Connect();
                    Connected = true;
                }
                int[] valoresArray = modbusClient.ReadHoldingRegisters(startAddress, numRegistos);
                valores.AddRange(valoresArray);
            }
            catch (Exception ex)
            {
                Connected = false;
                // Tratar exceções de conexão ou leitura
                Console.WriteLine($"Erro ao atualizar dados ModBus: {ex.Message}");
            }
            return valores;
        }

    }
}
