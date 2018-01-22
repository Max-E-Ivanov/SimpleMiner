using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public class ErrorPresenter : IPresenter
    {
        IErrorView _view;

        public ErrorPresenter(IErrorView _view, Exception ex)
        {
            this._view = _view;

            _view.SetErrorMessage( ex.Message);
            _view.SetErrorDetails(GetErrorDetails(ex));
        }

        string GetErrorDetails(Exception ex)
        {
            string sError = string.Empty;

            Exception _innerException = ex;

            while (_innerException != null)
            {

                sError = sError + "[" + _innerException.GetType().Name + "]: " + _innerException.Message + @"
----------------------------------";
                _innerException = _innerException.InnerException;
            }

            return sError;
        }

        public void Show()
        {
            _view.Show();
        }

        public object ShowDialog()
        {
           return  _view.ShowDialog();
        }
    }
}
