using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace TempLogger
{
    class posts
    {
        public void getAvailableComPorts(string[] ports, ComboBox combo)
        {
            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                combo.Items.Add(port);
                if (ports[0] == null)
                {
                    combo.SelectedItem = ports[0];
                }
            }
        }
    }
}
