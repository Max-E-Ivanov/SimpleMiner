using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;


namespace SimpleMiner.Claymor
{
    public class ClaymorConfigPresenter : IPresenter
    {
        IClaymorConfigView _view;
        ClaymorParams _params;

        public ClaymorConfigPresenter(IClaymorConfigView _view, ClaymorParams _params) : base()
        {
            this._view = _view;
            this._params = _params;
        }


        public void Show()
        {
            throw new NotImplementedException();
        }

        public object ShowDialog()
        {
            try
            {
                _view.ShowDialog();

            }
            catch (Exception ex)
            {
                UIHelper.ShowError(new Exception("Error while working with config window", ex));
            }

            return null;
        }
    }
}
