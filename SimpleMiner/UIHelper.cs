using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMiner.Claymor;

namespace SimpleMiner
{
    public class UIHelper
    {

        public static void ShowError(string sMessage)
        {
            MessageBox.Show(sMessage, SimpleMiner.Properties.Resources.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowInfo(string sMessage)
        {
            MessageBox.Show(sMessage, SimpleMiner.Properties.Resources.InfoCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(Exception ex)
        {
            ErrorPresenter errorPresenter = new ErrorPresenter(new dlgErrorForm(), ex);
            errorPresenter.ShowDialog();
        }

        public static void ShowClaymorConfigDlg(ClaymorParams _parms)
        {
            ClaymorConfigPresenter _presenter = new ClaymorConfigPresenter(new dlgClaymorConfig(), _parms);
            _presenter.ShowDialog();
        }

    }
}
