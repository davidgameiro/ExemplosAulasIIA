using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using EasyModbus;
using System.IO.Ports;

namespace ExemploFormModBus
{
    internal class cModBus : IDisposable
    {
        private readonly System.Threading.Timer timerRefresh;
        private readonly ModbusClient modbusClient;
        private readonly int numRegistos;
        private readonly object syncLock = new object();

        private bool connected = false;

        public Color ColorStatus => connected ? Color.Green : Color.Red;
        public bool IsConnected => connected;

        public List<int> Valores { get; private set; } = new List<int>();

        public cModBus(string ipAddress, int port, int nRegistos)
        {
            this.numRegistos = nRegistos;
            this.modbusClient = new ModbusClient(ipAddress, port)
            {
                ConnectionTimeout = 1000 // 1 segundo de timeout
            };

            // Inicia o timer com intervalo de 200ms a 500ms
            timerRefresh = new System.Threading.Timer(RefreshData, null, 100, 300);
        }

        private void RefreshData(object state)
        {
            // Evita que múltiplos ciclos corram em simultâneo se a rede atrasar
            if (!System.Threading.Monitor.TryEnter(syncLock))
            {
                return;
            }

            try
            {
                if (!modbusClient.Connected)
                {
                    modbusClient.Connect();
                }

                int[] valores = modbusClient.ReadHoldingRegisters(0, numRegistos);
                connected = true;

                // Atualiza os dados (ou adiciona/atualiza conforme o seu modelo de colunas)
                lock (Valores)
                {
                    Valores.Clear();
                    Valores.AddRange(valores);
                }
            }
            catch (Exception)
            {
                connected = false;

                try
                {
                    if (modbusClient.Connected)
                    {
                        modbusClient.Disconnect();
                    }
                }
                catch
                {
                    // Ignora falhas ao desligar socket com falha
                }
            }
            finally
            {
                System.Threading.Monitor.Exit(syncLock);
            }
        }

        public void Dispose()
        {
            timerRefresh?.Dispose();
            try
            {
                if (modbusClient != null && modbusClient.Connected)
                {
                    modbusClient.Disconnect();
                }
            }
            catch { }
        }
    }
}
