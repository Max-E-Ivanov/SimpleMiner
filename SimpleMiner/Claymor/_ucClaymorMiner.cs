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

namespace SimpleMiner
{
    public partial class ucClaymorMiner1 : ucBaseMiner
    {
        bool bStartState;
        

        public ucClaymorMiner()
        {
            InitializeComponent();


           

            bStartState = false;
        }

        public string EthWallet
        {
            get
            {
                return textBoxEthWallet.Text;
            }
            set
            {
                textBoxEthWallet.Text = value;
               
            }
        }

        public string EthWorker
        {
            get
            {
                return textBoxEthWorker.Text;
            }
            set
            {
                textBoxEthWorker.Text = value;
               
            }
        }

        public string EthPool
        {
            get
            {
                return comboBoxEthPools.SelectedText;
            }
            set
            {
                comboBoxEthPools.SelectedText = value;
                
            }
        }

        public void LoadEthPools(List<string> lsPools)
        {
            comboBoxEthPools.Items.Clear();

            foreach (string sPool in lsPools)
                comboBoxEthPools.Items.Add(sPool);
        }


        public event Action Run;
        public event Action Stop;

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            bStartState = !bStartState;
            buttonStartStop.Image = bStartState ? SimpleMiner.Properties.Resources.s_stop : SimpleMiner.Properties.Resources.s_start;

            if (bStartState)
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

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEthWallet_TextChanged(object sender, EventArgs e)
        {
           // if (sender is Control)
           //     NotifyPropertyChanged(((Control)sender).Name);
        }
    }
}
