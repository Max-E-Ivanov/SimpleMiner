using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public class AboutPresenter : IPresenter
    {
        IAboutView _view;

        public AboutPresenter(IAboutView _view)
        {
            this._view = _view;

            _view.SetVersion("v. "+Utils.GetAppVersion());

            _view.Web += _view_Web;
            _view.Mail += _view_Mail;

        }

        private void _view_Mail()
        {
            try
            {
                string mailto = string.Format("mailto:{0}?Subject={1}&Body={2}", SimpleMiner.Properties.Resources.MailTo, "SimpleMiner", "");
                mailto = Uri.EscapeUriString(mailto);

                System.Diagnostics.Process.Start(mailto);

                _view.SetMailVisited();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex.Message);
            }
        }

        private void _view_Web()
        {
            try
            {
                System.Diagnostics.Process.Start(SimpleMiner.Properties.Resources.Web);

                _view.SetWebVisited();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex.Message);
            }
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public object ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
