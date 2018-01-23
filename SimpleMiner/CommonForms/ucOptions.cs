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
        }

        public object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
