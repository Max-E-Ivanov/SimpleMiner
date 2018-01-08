using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMiner
{
    public partial class ucBaseMiner : UserControl
    {
        ProcessHelper _processHelper;
        public ucBaseMiner()
        {
            InitializeComponent();

            // Localization

            // Init

            _processHelper = null;
            EnableButtons();
        }


        void StartProcess()
        {
            try
            {
                ProcessParams _params = new ProcessParams(textBoxPath.Text, textBoxParams.Text);

                _processHelper = new ProcessHelper(_params);
                _processHelper.OnUpdateProcess += _processHelper_OnUpdateProcess;

                _processHelper.Launch();

                textBoxOutput.Clear();

                EnableButtons();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }
        }

        void KillProcess()
        {
            try
            {
                _processHelper.Kill();

                EnableButtons();
            }              
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }
}

        private void _processHelper_OnUpdateProcess(object sender, ProcessEventArgs e)
        {
            // Info from process
            UpdateTextControl(e);
        }

        void EnableButtons()
        {
            textBoxPath.Enabled = textBoxParams.Enabled = (_processHelper == null) || (!_processHelper.IsAlive);
            buttonRun.Enabled = (!string.IsNullOrEmpty(textBoxPath.Text)) && ((_processHelper == null) || (!_processHelper.IsAlive));
            buttonStop.Enabled = (_processHelper != null) && (_processHelper.IsAlive);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxPath.Text = openFileDialog1.FileName;

            EnableButtons();
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            StartProcess();
        }


        void UpdateTextControl(ProcessEventArgs info)
        {
            textBoxOutput.Invoke(new Action(() => textBoxOutput.Text = textBoxOutput.Text + info.Message +
            @"
"));
            toolStripStatusLabel1.Text = info.Status;
        }

        
        private void buttonStop_Click(object sender, EventArgs e)
        {
            KillProcess();
        }
    }
}
