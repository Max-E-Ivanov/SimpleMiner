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
    public partial class ucOptions : SimpleMiner.BaseForm.ucBaseUserControl, IView
    {
        public ucOptions()
        {
            InitializeComponent();

            // Localization
            labelLanguage.Text = SimpleMiner.Properties.Resources.Language;
            checkBoxLog.Text = SimpleMiner.Properties.Resources.WriteLog;

            toolTipManager.SetToolTip(this.comboBoxLanguage, SimpleMiner.Properties.Resources.ttLanguage);
        }

        public object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
