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




            tabPageCustomCommand.Text = SimpleMiner.Properties.Resources.ClmCfgTabCustomCommand;



            checkBoxCustomCommand.Text = SimpleMiner.Properties.Resources.ClmCFgCustomCommandCb;
            buttonCustomCommand.Text = SimpleMiner.Properties.Resources.ClmCfgCustomCommandBtn;


            toolTipManager.SetToolTip(this.checkBoxCustomCommand, SimpleMiner.Properties.Resources.ttClmCFgCustomCommandCb);
            toolTipManager.SetToolTip(this.buttonCustomCommand, SimpleMiner.Properties.Resources.ttClmCfgCustomCommandBtn);
        }
        
        object IView.ShowDialog()
        {
            return this.ShowDialog();
        }

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

        private void textBoxCustomCommand_TextChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("params");
        }

        public event Action Ok;
        public event Action Default;

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
    }
}
