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
using System.Threading;

namespace TempLogger
{
    public partial class Form1 : Form
    {
        bool isConnect = false;
        String[] ports;
        SerialPort port;

        string Temp = "12";

        Thread listen;

        public Form1()
        {
            InitializeComponent();

        }

        short getTemp()
        {
            Random r = new Random();
            short.TryParse(r.Next(5, 24).ToString(), out short temp);
            return temp;
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                Ports_compo.Items.Add(port);
                if (ports[0] == null)
                {
                    Ports_compo.SelectedItem = ports[0];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAvailableComPorts();
        }

        private void dataListen()
        {
            while (isConnect /*port.IsOpen*/)
            {
                //label1.Text = port.ReadLine();
            }
        }

        private void connectToArduino()
        {
            isConnect = true;

            string selectedPort = Ports_compo.GetItemText(Ports_compo.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();

            Cont_text.Text = "Disconnect";

            if (port.IsOpen)
            {
                listen = new Thread(dataListen);
                listen.Start();
            }
        }

        private void disconnectFromArduino()
        {
            isConnect = false;
            port.Close();
            Cont_text.Text = "Connect";
        }

        private void Cont_text_Click(object sender, EventArgs e)
        {
            if (!isConnect)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }

        short[] Data_chart; 

        public void chart()
        {
            Data_chart = new short[8];

            for (short i = 0; i < Data_chart.Length; i++)
            {
                Data_chart[i] = getTemp();
            }

            UpdateChart();
        }

        private void UpdateChart()
        {
            tempchart.Series["TempSeries"].Points.Clear();

            for(int i = 0; i < Data_chart.Length - 1; i++)
            {
                tempchart.Series["TempSeries"].Points.AddY(Data_chart[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart();
        }
    }
}
