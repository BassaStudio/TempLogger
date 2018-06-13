using System;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
using rtChart;
using System.Media;
using System.Diagnostics;

namespace TempLogger
{
    public partial class main : Form
    {
        String[] ports;
        SerialPort port;
        public bool isConnect = false;

        kayChart serialDataChart;

        bool LogFile = false;

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
                    port.WriteLine("SEC" + Properties.Settings.Default.LogInt + "?");
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

            try
            {
                Debug.Text = "Data";
            } catch
            {

            }

            recvData = recvData.Replace('.' , ',');

            serialData2.Invoke((MethodInvoker)delegate
            {
                //serialData.AppendText(recvData);
                serialData2.Text = recvData + "°";
                double.TryParse(recvData, out double datain);
                Log(datain);
            });

            float data;
            bool result = float.TryParse(recvData, out data);
            if(result)
            {
                serialDataChart.TriggeredUpdate(data);
            }

            if(float.TryParse(Properties.Settings.Default.AlertMax.ToString(), out float max) && Properties.Settings.Default.AlertBool)
                if(float.TryParse(Properties.Settings.Default.AlertMin.ToString(), out float min))
                {
                    //textBox1.Text = "min: " + min + ", max: " + max;

                    if (data > max)
                    {
                        sound();
                        port.Write("HOT?");
                    } else if(data < min)
                    {
                        sound();
                        port.Write("LOW?");
                    }
                    else
                    {
                        port.Write("NOR?");
                    }
                } 
        }

        public void Log(double data)
        {
            int dd = DateTime.Now.Day;
            int mo = DateTime.Now.Month;
            int yy = DateTime.Now.Year;


            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            String Date = "";

            Date += compineDate(yy);
            Date += "-";
            Date += compineDate(mo);
            Date += "-";
            Date += compineDate(dd);

            string Time = "";
            Time += compineDate(hh);
            Time += "-";
            Time += compineDate(mm);
            Time += "-";
            Time += compineDate(ss);

            string LogPath = Properties.Settings.Default.LogPath + "/" + Date + ".txt";

            try
            {
                if (File.Exists(LogPath) && Properties.Settings.Default.LogBool && !LogFile)
                {
                    using (StreamWriter sw = new StreamWriter(LogPath, true))
                    {
                        sw.WriteLine(Time + ": " + data);
                        Debug.Text = "create";

                    }
                }
                else if(!LogFile)
                {
                    File.AppendAllText(LogPath, Time + ": " + data + "\r\n");
                   
                }
            } catch
            {
                MessageBox.Show("Can't create file");
                LogFile = true;
            }



           

        }

        private string compineDate(int var)
        {
            string Result = "";

            if (var < 10)
            {
                Result += 0;
                Result += var;
            }
            else
            {
                Result += var;
            }

            return Result;
        }

        public void sound()
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Settings.Default.AlertPath);
                sound.Play();
            } catch
            {
                if(Properties.Settings.Default.AlertPath != "")
                {
                    MessageBox.Show("The sound don't play.");
                }
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

        private void Logsbut_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Properties.Settings.Default.LogPath);

            }
            catch (Exception)
            {
                MessageBox.Show("Can't open logs folder");
            }
        }
    }
}
