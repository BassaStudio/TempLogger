using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rtChart;
using System.Threading;

namespace TempLogger
{
    public partial class Form1 : Form
    {
        String[] ports;
        SerialPort port;
        public bool isConnect = false;

        kayChart serialDataChart;

        public Form1()
        {
            InitializeComponent();
        }

        private void Cont_text_Click(object sender, EventArgs e)
        {
            if(!isConnect)
            {
                ConnectToArduino();
            } else
            {
                DisconectToArduino();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialDataChart = new kayChart(tempchart, 60);
            serialDataChart.serieName = "TempSeries";

            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                Ports_compo.Items.Add(port);
                if(port[0] == null)
                {
                    Ports_compo.SelectedItem = ports[0];
                }
            }

        }

        private void ConnectToArduino()
        {
            String selectedPort = Ports_compo.GetItemText(Ports_compo.SelectedItem);

            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventHandler);
            
            if(!port.IsOpen)
            {
                port.Open();
                isConnect = true;
                Cont_text.Text = "Disconnect";
            }
        }

        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sData = sender as SerialPort;
            string recvData = sData.ReadLine();

            serialData.Invoke((MethodInvoker)delegate
            {
                //serialData.AppendText(recvData);
                serialData.Text = recvData;
            });

            double data;
            bool result = Double.TryParse(recvData, out data);
            if(result)
            {
                serialDataChart.TriggeredUpdate(data);
            }
        }


        public void DisconectToArduino()
        {
            port.Close();
            isConnect = false;
            Cont_text.Text = "Connect";
        }

        private void serialData_TextChanged(object sender, EventArgs e)
        {
            serialData.SelectionStart = serialData.Text.Length;
            serialData.ScrollToCaret();
        }
    }
}
