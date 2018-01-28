using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMiner.BaseForm;

namespace SimpleMiner.Claymor
{
    public partial class ucClaymorMiner : SimpleMiner.BaseForm.ucBaseUserControl, IClaymorMinerView
    {
        bool bStart;
        public ucClaymorMiner()
        {
            InitializeComponent();

            // Localize
            toolTipManager.SetToolTip(this.textBoxEthWallet, SimpleMiner.Properties.Resources.ttEthWallet);
            toolTipManager.SetToolTip(this.comboBoxEthPools, SimpleMiner.Properties.Resources.ttEthPool);
            toolTipManager.SetToolTip(this.textBoxEthWorker, SimpleMiner.Properties.Resources.ttEthWorker);
            toolTipManager.SetToolTip(this.buttonConfig, SimpleMiner.Properties.Resources.ttConfigButton);
            toolTipManager.SetToolTip(this.buttonStartStop, SimpleMiner.Properties.Resources.ttStartButton);
            toolTipManager.SetToolTip(this.textBoxCustomCommand, SimpleMiner.Properties.Resources.ttClmCustomCommand);

            labelEthWallet.Text = SimpleMiner.Properties.Resources.EthWallet;
            linkLabelCreateEthWallet.Text = SimpleMiner.Properties.Resources.EthCreateWalletLink;
            labelEthWorker.Text = SimpleMiner.Properties.Resources.EthWorker;
            labelEthPool.Text = SimpleMiner.Properties.Resources.EthPool;


            bStart = false;
            bSettingParams = false;

            buttonConfig.Image = SimpleMiner.Properties.Resources.s_settings;
            buttonStartStop.Image = SimpleMiner.Properties.Resources.s_start;

            // Hide tabs headers
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = "";
            }
        }

        bool bSettingParams;
        ClaymorParams _params;
        public ClaymorParams clParams
        {
            get
            {
                return _params;
            }
            set
            {
                bSettingParams = true;
                _params = value;

                textBoxEthWallet.Text = clParams.EthWallet;
                comboBoxEthPools.Text = clParams.EthPool;
                textBoxEthWorker.Text = clParams.EthWorker;

                textBoxCustomCommand.Text = clParams.CustomParams;

                tabControl1.SelectedIndex = (string.IsNullOrEmpty(clParams.CustomParams) ? 0 : 1);


                bSettingParams = false;
            }
        }

        public void PopulateEthPools(List<string> lsPools)
        {
            comboBoxEthPools.Items.Clear();

            foreach (string sPool in lsPools)
                comboBoxEthPools.Items.Add(sPool);
        }

        public string OutputTextBox
        {
            get
            {
                return (string)textBoxOutput.Invoke(new Func<string>(() =>
                {
                    return textBoxOutput.Text;
                }
              ));
            }
            set
            {
                textBoxOutput.Invoke(new Action(() =>
                {
                    textBoxOutput.Text = value;
                    //textBoxOutput.AppendText(value);

                }));
            }
        }

        public bool buttonStartEnabled
        {
            get
            {
                return buttonStartStop.Enabled;
            }
            set
            {
                buttonStartStop.Enabled = value;
            }
        }

        public bool buttonConfigEnabled
        {
            get
            {
                return buttonConfig.Enabled;
            }
            set
            {
                buttonConfig.Enabled = value;
            }
        }



        private void textBoxEthWallet_TextChanged(object sender, EventArgs e)
        {

            if (!bSettingParams)
            {
                clParams.EthWallet = textBoxEthWallet.Text;
                clParams.EthPool = comboBoxEthPools.Text;
                clParams.EthWorker = textBoxEthWorker.Text;

                NotifyPropertyChanged("params");
            }
        }

        public event Action Run;
        public event Action Stop;
        public event Action Config;
        public event Action CreateWallet;

       

        private void linkLabelCreateEthWallet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CreateWallet != null)
                CreateWallet();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            bStart = !bStart;
            buttonStartStop.Image = bStart ? SimpleMiner.Properties.Resources.s_stop :  SimpleMiner.Properties.Resources.s_start;

            if (bStart)
            {
                if (Run != null)
                    Run();
            }
            else
            {
                if (Stop != null)
                    Stop();
            }

        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public object ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            if (Config != null)
                Config();
        }

        public void SetCreateWalletVisited()
        {
            linkLabelCreateEthWallet.LinkVisited = true;
        }
    }
}
