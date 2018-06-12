using System;
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

            Properties.Settings.Default.LogBool = checkLog.Checked;
            Properties.Settings.Default.LogPath = textLogPath.Text;

            Properties.Settings.Default.LogInt = 

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void option_Load(object sender, EventArgs e)
        {
            numMax.Value = Properties.Settings.Default.AlertMax;
            numMin.Value = Properties.Settings.Default.AlertMin;

            CheckAlert.Checked = Properties.Settings.Default.AlertBool;
            checkLog.Checked = Properties.Settings.Default.LogBool;

            textPath.Text = Properties.Settings.Default.AlertPath;
            textLogPath.Text = Properties.Settings.Default.LogPath;

            toggleAlert();
            logToggle();
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

            Result.CheckFileExists = true;
            Result.Filter = "WAV files (*.wav)|*.wav";
            Result.DefaultExt = ".wav";

            if (Result.ShowDialog() == DialogResult.OK)
            {
                textPath.Text = Result.FileName;
            }
        }

        private void checkLog_CheckedChanged(object sender, EventArgs e)
        {
            logToggle();
        }

        private void logToggle()
        {
            if (checkLog.Checked)
                checkLog.Text = "Save On";
            else
                checkLog.Text = "Save Off";
        }

        private void textLogPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pic = getPath();
            if (pic != null)
            {
                textLogPath.Text = pic.SelectedPath.ToString();
            }
        }

        private FolderBrowserDialog getPath()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd;
                }
            }
            return null;
        }
    }
}
