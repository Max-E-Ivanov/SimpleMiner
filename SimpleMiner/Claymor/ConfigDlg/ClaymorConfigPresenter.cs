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
        ClaymorParams _params_clone;

        public ClaymorConfigPresenter(IClaymorConfigView _view, ClaymorParams _params) : base()
        {
            this._view = _view;
            this._params = _params;

            _params_clone = _params.DeepClone();

            this._view.PropertyChanged += _view_PropertyChanged;
            this._view.Ok += _view_Ok;
            this._view.Default += _view_Default;


            DisplayParams();
        }

        private void _view_Default()
        {
            _params_clone.RestoreDefaults();

            DisplayParams();
        }

        private void _view_Ok()
        {
            _params.CopyFrom( _params_clone);
        }

        private void _view_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "params")
            {
                _params_clone.CustomParams = _view.textCustomCommand;




                DisplayParams();
            }
        }

        void DisplayParams()
        {
            _view.textCustomCommand = _params_clone.CustomParams;


            //_view.SetCheckCustomCommandState();
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
