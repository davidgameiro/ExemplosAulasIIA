using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace ClientTCPIP
{
    public partial class FormClnt : Form
    {
        TcpListener tcp_server = null;
        TcpClient tcp_client=null;
        NetworkStream clientStream;
        Byte[] serverData = new Byte[256];

        public FormClnt()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            IPAddress ip_address;
            try
            {
                ip_address = IPAddress.Parse(maskedTextBoxIP.Text);
            }catch
            {
                MessageBox.Show("IP is not correct","Information");
                return;
            }

            try
            {
                tcp_client = new TcpClient();
                tcp_client.Connect(ip_address.ToString(), (int)numericUpDownPort.Value);
                timerServer.Start();
            }catch(Exception msg)
            {
                MessageBox.Show(msg.Message, "information");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBoxIP.Mask = @"###\.###\.###\.###";
            maskedTextBoxIP.ValidatingType = typeof(IPAddress);
            maskedTextBoxIP.Text = "127.000.000.001";

            numericUpDownPort.Value = 320;
           

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {

            if(tcp_client!=null)
            {
                tcp_client.Close();
            }
            timerServer.Stop();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {

            if(tcp_client!=null)
            {
                int MsgSize;
                string msg = "";

                if(tcp_client.Connected)
                {
                    MsgSize = tcp_client.Available;
                    clientStream = tcp_client.GetStream();
                    if(MsgSize>0)
                    {
                        clientStream.Read(serverData,0,MsgSize);
                        int i = 0;
                        while(serverData[i]!=0)
                        {
                            msg = msg + (char)serverData[i];
                            i++;
                        }
                        richTextBoxChat.AppendText("Other: " + msg);
                    }
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string ss;

            ss = richTextBoxSend.Text;
            richTextBoxSend.SelectAll();
            richTextBoxSend.Text = "";

            if(ss.Length>0)
            {
                Byte[] tosend = new Byte[256];
                richTextBoxChat.AppendText("You: "+ss);
                for(int i=0;i<(ss.Length-1);i++)
                {
                    tosend[i] = Convert.ToByte(ss[i]);
                }
                if(tcp_client.Connected)
                {
                    clientStream.Write(tosend,0,ss.Length-1);
                }
            }
            richTextBoxSend.Focus();
        }
    }
}
