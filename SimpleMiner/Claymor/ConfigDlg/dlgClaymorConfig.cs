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
        }

        public event PropertyChangedEventHandler PropertyChanged;

        object IView.ShowDialog()
        {
            return this.ShowDialog();
        }
    }
}
