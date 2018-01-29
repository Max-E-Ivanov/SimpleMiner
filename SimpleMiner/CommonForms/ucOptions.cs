using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public partial class ucOptions : SimpleMiner.BaseForm.ucBaseUserControl, IOptionsView
    {
        public ucOptions()
        {
            InitializeComponent();

            // Localization
            labelLanguage.Text = SimpleMiner.Properties.Resources.Language;
            checkBoxLog.Text = SimpleMiner.Properties.Resources.WriteLog;

            toolTipManager.SetToolTip(this.comboBoxLanguage, SimpleMiner.Properties.Resources.ttLanguage);
        }

        public string currentLanguage
        {
            get
            {
                

                return (string)comboBoxLanguage.SelectedValue;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    comboBoxLanguage.SelectedIndex = 0;
                    
                }
                else
                    comboBoxLanguage.SelectedValue = value;
            }
        }

        public bool writeLog
        {
            get
            {
                return checkBoxLog.Checked;
            }

            set
            {
                checkBoxLog.Checked = value;
            }
        }

        public void PopulateLanguages(List<KeyValuePair<string, string>> list)
        {
            comboBoxLanguage.DataSource = list;
        }

        public object ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void comboBoxLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("language");
        }

        private void checkBoxLog_CheckedChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("writelog");
        }
    }
}
