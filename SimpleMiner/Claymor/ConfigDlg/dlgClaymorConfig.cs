using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMiner.BaseForm;
using SimpleMiner.MVP;

namespace SimpleMiner.Claymor
{
    public partial class dlgClaymorConfig : SimpleMiner.BaseForm.BaseForm, IClaymorConfigView
    {


        public dlgClaymorConfig()
        {
            InitializeComponent();

            // Localization
            this.Text = SimpleMiner.Properties.Resources.MinerCfgCaption;
            buttonOk.Text = SimpleMiner.Properties.Resources.ApplayButton;
            buttonCancel.Text = SimpleMiner.Properties.Resources.CancelButton;
            buttonDefaults.Text = SimpleMiner.Properties.Resources.DefaultsButton;

            toolTipManager.SetToolTip(this.buttonOk, SimpleMiner.Properties.Resources.ttApplayButton);
            toolTipManager.SetToolTip(this.buttonCancel, SimpleMiner.Properties.Resources.ttCancelButton);
            toolTipManager.SetToolTip(this.buttonDefaults, SimpleMiner.Properties.Resources.ttDefaultsButton);

            // Tab Names
            tabPageCustomCommand.Text = SimpleMiner.Properties.Resources.ClmCfgTabCustomCommand;
            tabPageCoins.Text = SimpleMiner.Properties.Resources.ClmCfgTabCoins;

            //Coins tab
            checkBoxMode.Text = SimpleMiner.Properties.Resources.ClmCfgSecondCoin;
            toolTipManager.SetToolTip(this.comboBoxEpool, SimpleMiner.Properties.Resources.ttEthPool);
            toolTipManager.SetToolTip(this.checkBoxSolo, SimpleMiner.Properties.Resources.ttClmCfgSolo);
            toolTipManager.SetToolTip(this.textBoxEtht, SimpleMiner.Properties.Resources.ttClmCfgEtht);
            toolTipManager.SetToolTip(this.checkBoxAllPools, SimpleMiner.Properties.Resources.ttClmCfgAllPools);
            toolTipManager.SetToolTip(this.checkBoxAllCoins, SimpleMiner.Properties.Resources.ttClmCfgAllcoins);
            toolTipManager.SetToolTip(this.checkBoxEpsw, SimpleMiner.Properties.Resources.ttClmCfgPsw);
            toolTipManager.SetToolTip(this.checkBoxEthWorker, SimpleMiner.Properties.Resources.ttClmCfgWorker);
            toolTipManager.SetToolTip(this.checkBoxEsm, SimpleMiner.Properties.Resources.ttClmCfgEsm);
            toolTipManager.SetToolTip(this.checkBoxEthI, SimpleMiner.Properties.Resources.ttClmCfgEthi);
            toolTipManager.SetToolTip(this.checkBoxEtha, SimpleMiner.Properties.Resources.ttClmCfgEtha);
            toolTipManager.SetToolTip(this.checkBoxEstale, SimpleMiner.Properties.Resources.ttClmCfgEstale);
            toolTipManager.SetToolTip(this.checkBoxErate, SimpleMiner.Properties.Resources.ttClmCfgErate);

            toolTipManager.SetToolTip(this.comboBoxDPool, SimpleMiner.Properties.Resources.ttClmCfgDpool);
            toolTipManager.SetToolTip(this.textBoxDwal, SimpleMiner.Properties.Resources.ttClmCfgDwal);
            toolTipManager.SetToolTip(this.checkBoxDpsw, SimpleMiner.Properties.Resources.ttClmCfgDpsw);
            toolTipManager.SetToolTip(this.checkBoxDcri, SimpleMiner.Properties.Resources.ttClmCfgDcri);
            toolTipManager.SetToolTip(this.checkBoxDcrt, SimpleMiner.Properties.Resources.ttClmCfgDcrt);
            toolTipManager.SetToolTip(this.checkBoxDcoin, SimpleMiner.Properties.Resources.ttClmCfgDcoin);
            










            // Custom Command tab
            checkBoxCustomCommand.Text = SimpleMiner.Properties.Resources.ClmCFgCustomCommandCb;
            buttonCustomCommand.Text = SimpleMiner.Properties.Resources.ClmCfgCustomCommandBtn;
            toolTipManager.SetToolTip(this.checkBoxCustomCommand, SimpleMiner.Properties.Resources.ttClmCFgCustomCommandCb);
            toolTipManager.SetToolTip(this.buttonCustomCommand, SimpleMiner.Properties.Resources.ttClmCfgCustomCommandBtn);
        }
        
        object IView.ShowDialog()
        {
            return this.ShowDialog();
        }

        public void PopulateEsmList(List<KeyValuePair<string, string>> ListEsm)
        {
            comboBoxEthProtocol.DataSource = ListEsm;
        }

        public void PopulateDCoins(List<string> lsDCoins)
        {
            comboBoxDcoin.DataSource = lsDCoins;
        }

        public void PopulateEPools(List<string> lsPools)
        {
            comboBoxEpool.Items.Clear();

            foreach (var sPool in lsPools)
                comboBoxEpool.Items.Add(sPool);
        }

        public void PopulateDPools(List<string> lsPools)
        {
            comboBoxDPool.Items.Clear();

            foreach (var sPool in lsPools)
                comboBoxDPool.Items.Add(sPool);
        }


        // -------------- First Coin
        public string epool
        {
            get
            {
                return comboBoxEpool.Text;
            }
            set
            {
                comboBoxEpool.Text = value;
            }
        }

        public bool  solo
        {
            get
            {
                return checkBoxSolo.Checked;
            }
            set
            {
                checkBoxSolo.Checked = value;

                checkBoxSolo_CheckedChanged(this, new EventArgs());
            }
        }

        public string etht
        {
            get
            {
                return textBoxEtht.Text;
            }
            set
            {
                textBoxEtht.Text = value;

                checkBoxSolo.Checked = !string.IsNullOrEmpty(etht);

                checkBoxSolo_CheckedChanged(this, new EventArgs());
            }
        }
        
        public bool allpools
        {
            get
            {
                return checkBoxAllPools.Checked;
            }
            set
            {
                checkBoxAllPools.Checked = value;
            }
        }

        public string allcoins
        {
            get
            {
                return textBoxAllCoins.Text;
            }
            set
            {
                textBoxAllCoins.Text = value;

                checkBoxAllCoins.Checked = !string.IsNullOrEmpty(allcoins);

                checkBoxAllCoins_CheckedChanged(this, new EventArgs());
            }
        }

        public string epsw
        {
            get
            {
                return textBoxEpsw.Text;
            }
            set
            {
                textBoxEpsw.Text = value;

                checkBoxEpsw.Checked = !string.IsNullOrEmpty(epsw);

                checkBoxEpsw_CheckedChanged(this, new EventArgs());
            }
        }

        public string eworker
        {
            get
            {
                return textBoxEthWorker.Text;
            }
            set
            {
                textBoxEthWorker.Text = value;

                checkBoxEthWorker.Checked = !string.IsNullOrEmpty(eworker);

                checkBoxEthWorker_CheckedChanged(this, new EventArgs());
            }
        }

        public string ethi
        {
            get
            {
                return textBoxEthi.Text;
            }
            set
            {
                textBoxEthi.Text = value;

                checkBoxEthI.Checked = !string.IsNullOrEmpty(ethi);

                checkBoxEthI_CheckedChanged(this, new EventArgs());
            }
        }

        public string etha
        {
            get
            {
                return textBoxETHA.Text;
            }
            set
            {
                textBoxETHA.Text = value;

                checkBoxEtha.Checked = !string.IsNullOrEmpty(etha);

                checkBoxEtha_CheckedChanged(this, new EventArgs());
            }
        }

        public bool estale
        {
            get
            {
                return checkBoxEstale.Checked;
            }
            set
            {
                checkBoxEstale.Checked = value;
            }
        }

        public bool erate
        {
            get
            {
                return checkBoxErate.Checked;
            }
            set
            {
                checkBoxErate.Checked = value;
            }
        }

        public string esm
        {
            get
            {

                if (comboBoxEthProtocol.SelectedIndex == -1)
                    return string.Empty;

                return (string)comboBoxEthProtocol.SelectedValue;
            }
            set
            {

                if (esm == value)
                    return;

                if (string.IsNullOrEmpty(value))
                    comboBoxEthProtocol.SelectedIndex = -1;
                else
                    comboBoxEthProtocol.SelectedValue = value;

                checkBoxEsm.Checked = !string.IsNullOrEmpty(esm);

                checkBoxEsm_CheckedChanged(this, new EventArgs());
            }
        }

        // ----------- Second Coin

        public bool mode
        {
            get
            {
                return checkBoxMode.Checked;
            }
            set
            {

                if (mode != value)
                    checkBoxMode.Checked = value;



                SetSecondCoinEnabled();
            }
        }

        public string dpool
        {
            get
            {
                return comboBoxDPool.Text;
            }
            set
            {
                comboBoxDPool.Text = value;
            }
        }

        public string dwal
        {
            get
            {
                return textBoxDwal.Text;
            }
            set
            {
                textBoxDwal.Text = value;
            }
        }

        public string dpsw
        {
            get
            {
                return textBoxDPsw.Text;
            }
            set
            {
                textBoxDPsw.Text = value;

                checkBoxDpsw.Checked = !string.IsNullOrEmpty(dpsw);

                checkBoxDpsw_CheckedChanged(this, new EventArgs());
            }
        }

        public string dcri
        {
            get
            {
                return textBoxDcri.Text;
            }
            set
            {
                textBoxDcri.Text = value;

                checkBoxDcri.Checked = !string.IsNullOrEmpty(dcri);

                checkBoxDcri_CheckedChanged(this, new EventArgs());
            }
        }

        public string dcrt
        {
            get
            {
                return textBoxDcrt.Text;
            }
            set
            {
                textBoxDcrt.Text = value;

                checkBoxDcrt.Checked = !string.IsNullOrEmpty(dcrt);

                checkBoxDcrt_CheckedChanged(this, new EventArgs());
            }
        }

        public string dcoin
        {
            get
            {

                if (comboBoxDcoin.SelectedIndex == -1)
                    return string.Empty;

                return comboBoxDcoin.Text;
            }
            set
            {

                //if (dcoin == value)
               //     return;

                if (string.IsNullOrEmpty(value))
                    comboBoxDcoin.SelectedIndex = -1;
                else
                    comboBoxDcoin.Text = value;

                checkBoxDcoin.Checked = !string.IsNullOrEmpty(dcoin);

                checkBoxDcoin_CheckedChanged(this, new EventArgs());
            }
        }

        // ---------------- Custom Command

        public string textCustomCommand
        {
            get
            {
                return textBoxCustomCommand.Text;
            }
            set
            {
                textBoxCustomCommand.Text = value;

                checkBoxCustomCommand.Checked = !string.IsNullOrEmpty(textCustomCommand);

                checkBoxCustomCommand_CheckedChanged(this, new EventArgs());
            }
        }



        public void SetCheckCustomCommandState()
        {
            textBoxCustomCommand.Enabled = buttonCustomCommand.Enabled = checkBoxCustomCommand.Checked;
        }

        private void checkBoxCustomCommand_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckCustomCommandState();

            if (!checkBoxCustomCommand.Checked)
                textBoxCustomCommand.Text = string.Empty;
        }

        public void SetCheckSoloState()
        {
            textBoxEtht.Enabled = checkBoxSolo.Checked;
        }

        private void checkBoxSolo_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckSoloState();
            if (!checkBoxSolo.Checked)
                textBoxEtht.Text = string.Empty;
        }

        public void SetCheckAllCoinsState()
        {
            textBoxAllCoins.Enabled = checkBoxAllCoins.Checked;
        }

        private void checkBoxAllCoins_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckAllCoinsState();
            if (!checkBoxAllCoins.Checked)
                textBoxAllCoins.Text = string.Empty;
        }

        public void SetCheckEPswState()
        {
            textBoxEpsw.Enabled = checkBoxEpsw.Checked;
        }

        private void checkBoxEpsw_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckEPswState();
            if (!checkBoxEpsw.Checked)
                textBoxEpsw.Text = string.Empty;
        }

        public void SetCheckEworker()
        {
            textBoxEthWorker.Enabled = checkBoxEthWorker.Checked;
        }

        private void checkBoxEthWorker_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckEworker();
            if (!checkBoxEthWorker.Checked)
                textBoxEthWorker.Text = string.Empty;
        }

        public void SetCheckEthi()
        {
            textBoxEthi.Enabled = checkBoxEthI.Checked;
        }

        private void checkBoxEthI_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckEthi();
            if (!checkBoxEthI.Checked)
                textBoxEthi.Text = string.Empty;
        }

        public void SetCheckEtha()
        {
            textBoxETHA.Enabled = checkBoxEtha.Checked;
        }

       

        private void checkBoxEtha_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckEtha();
            if (!checkBoxEtha.Checked)
                textBoxETHA.Text = string.Empty;
        }

        public void SetCheckEsm()
        {
            comboBoxEthProtocol.Enabled = checkBoxEsm.Checked;
        }

        private void checkBoxEsm_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckEsm();
            if (!checkBoxEsm.Checked)
                comboBoxEthProtocol.SelectedIndex = -1;
        }

        private void textBoxCustomCommand_TextChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("params");
        }

        public event Action Ok;
        public event Action Default;
        public event Action GenerateCommand;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (Ok != null)
                Ok();

            Close();
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            if (Default != null)
                Default();
        }


        void SetSecondCoinEnabled()
        {
            //Clear second coin params and disable it
            comboBoxDPool.Enabled = textBoxDwal.Enabled = checkBoxDpsw.Enabled = textBoxDPsw.Enabled =
                checkBoxDcri.Enabled = textBoxDcri.Enabled = checkBoxDcrt.Enabled = textBoxDcrt.Enabled =
                checkBoxDcoin.Enabled = comboBoxDcoin.Enabled = checkBoxMode.Checked;

        }

        private void checkBoxMode_CheckedChanged(object sender, EventArgs e)
        {
            SetSecondCoinEnabled();

            if (!checkBoxMode.Checked)
            {
                //Clear values
                comboBoxDPool.Text = string.Empty;
                textBoxDwal.Text = string.Empty;
                textBoxDPsw.Text = string.Empty;
                textBoxDcri.Text = string.Empty;
                textBoxDcrt.Text = string.Empty;
                comboBoxDcoin.Text = string.Empty;
            }

            NotifyPropertyChanged("params");
        }

        public void SetCheckDPswState()
        {
            textBoxDPsw.Enabled = checkBoxDpsw.Checked;
        }

        private void checkBoxDpsw_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckDPswState();
            if (!checkBoxDpsw.Checked)
                textBoxDPsw.Text = string.Empty;
        }

        public void SetCheckDcriState()
        {
            textBoxDcri.Enabled = checkBoxDcri.Checked;
        }

        private void checkBoxDcri_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckDcriState();
            if (!checkBoxDcri.Checked)
                textBoxDcri.Text = string.Empty;
        }

        public void SetCheckDcrtState()
        {
            textBoxDcrt.Enabled = checkBoxDcrt.Checked;
        }

        private void checkBoxDcrt_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckDcrtState();
            if (!checkBoxDcrt.Checked)
                textBoxDcrt.Text = string.Empty;
        }


        public void SetCheckDcoin()
        {
            comboBoxDcoin.Enabled = checkBoxDcoin.Checked;
        }

        private void checkBoxDcoin_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckDcoin();
            if (!checkBoxDcoin.Checked)
                comboBoxDcoin.SelectedIndex = -1;
        }

        private void buttonCustomCommand_Click(object sender, EventArgs e)
        {
            if (GenerateCommand != null)
                GenerateCommand();
        }
    }
}
