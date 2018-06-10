using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempLogger
{
    public partial class option : Form
    {

        public option()
        {
            InitializeComponent();
        }

        private void butCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlertBool = CheckAlert.Checked;
            Properties.Settings.Default.AlertMax = numMax.Value;
            Properties.Settings.Default.AlertMin = numMin.Value;
            Properties.Settings.Default.AlertPath = textPath.Text;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void option_Load(object sender, EventArgs e)
        {
            numMax.Value = Properties.Settings.Default.AlertMax;
            numMin.Value = Properties.Settings.Default.AlertMin;
            CheckAlert.Checked = Properties.Settings.Default.AlertBool;
            textPath.Text = Properties.Settings.Default.AlertPath;
            toggleAlert();
        }

        private void CheckAlert_CheckedChanged(object sender, EventArgs e)
        {
            toggleAlert();
        }

        private void toggleAlert()
        {
            if (CheckAlert.Checked)
                CheckAlert.Text = "Alert On";
            else
                CheckAlert.Text = "Alert Off";
        }

        private void butbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Result = new OpenFileDialog();
            if (Result.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = Result.FileName;
            }
        }
    }
}
