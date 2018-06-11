using System;
using System.IO.Ports;
using System.Windows.Forms;
using rtChart;
using System.Media;

namespace TempLogger
{
    public partial class main : Form
    {
        String[] ports;
        SerialPort port;
        public bool isConnect = false;

        kayChart serialDataChart;

        public main()
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

            try {
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceivedEventHandler);
            
                if(!port.IsOpen)
                {
                    port.Open();
                    isConnect = true;
                    Cont_text.Text = "Disconnect";
                }
            } catch
            {
                MessageBox.Show("You need to have select a port");
            }
        }

        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sData = sender as SerialPort;
            string recvData = sData.ReadLine();

            serialData2.Invoke((MethodInvoker)delegate
            {
                //serialData.AppendText(recvData);
                serialData2.Text = recvData + "°";
            });

            double data;
            bool result = Double.TryParse(recvData, out data);
            if(result)
            {
                serialDataChart.TriggeredUpdate(data);
            }

            if(double.TryParse(Properties.Settings.Default.AlertMax.ToString(), out double max) && Properties.Settings.Default.AlertBool)
                if(double.TryParse(Properties.Settings.Default.AlertMin.ToString(), out double min))
                {
                    if (data > max)
                    {
                        sound();
                        port.WriteLine("CQFHOTNL");
                    } else if(data < min)
                    {
                        sound();
                        port.WriteLine("CQFLOWNL");
                    }
                } else
                {
                    port.WriteLine("CQFNORNL");
                }
        }

        public void sound()
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Settings.Default.AlertPath);
                sound.Play();
            } catch
            {
                MessageBox.Show("Something is wrong");
            }
        }


        public void DisconectToArduino()
        {
            port.Close();
            isConnect = false;
            Cont_text.Text = "Connect";
        }

        private void butOption_Click(object sender, EventArgs e)
        {
            if(!isConnect)
            {
                option optionForm = new option();
                optionForm.ShowDialog();
            } else
            {
                MessageBox.Show("You need to press the disconnect button");
            }
        }
    }
}
