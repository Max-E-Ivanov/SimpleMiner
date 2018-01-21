using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMiner.BaseForm
{
    public partial class ucBaseUserControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void NotifyPropertyChanged(string sPropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(sPropertyName));
            }
        }

        public ucBaseUserControl()
        {
            InitializeComponent();
        }
    }
}
