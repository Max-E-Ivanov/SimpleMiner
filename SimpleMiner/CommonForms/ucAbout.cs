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
    public partial class ucAbout : SimpleMiner.BaseForm.ucBaseUserControl, IView
    {
        public ucAbout()
        {
            InitializeComponent();
        }

        public object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
