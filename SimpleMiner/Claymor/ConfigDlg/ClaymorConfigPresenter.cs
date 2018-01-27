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

        bool bLoad;

        public ClaymorConfigPresenter(IClaymorConfigView _view, ClaymorParams _params) : base()
        {
            this._view = _view;
            this._params = _params;

            _params_clone = _params.DeepClone();

            this._view.PropertyChanged += _view_PropertyChanged;
            this._view.Ok += _view_Ok;
            this._view.Default += _view_Default;



            //_view.SetEsmList(ClaymorParams.ListEsm());
            bLoad = true;
            DisplayParams();
            bLoad = false;
        }

       

        private void _view_Default()
        {
            _params_clone.RestoreDefaults();
            bLoad = true;
            DisplayParams();
            bLoad = false;
        }

        private void _view_Ok()
        {
            _params.CopyFrom( _params_clone);
        }

        private void _view_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (!bLoad && (e.PropertyName == "params"))
            {

                _params_clone.Allcoins = _view.allcoins;
                _params_clone.Allpools = _view.allpools;
                _params_clone.Erate = _view.erate;
                //_params_clone.Esm = _view.esm;
                _params_clone.Estale = _view.estale;
                _params_clone.Etha = _view.etha;
                _params_clone.Ethi = _view.ethi;
                _params_clone.EthPool = _view.epool;
                _params_clone.EthPsw = _view.epsw;
                _params_clone.Etht = _view.etht;
                _params_clone.EthWorker = _view.eworker;
                _params_clone.Solo = _view.solo;
                

                _params_clone.CustomParams = _view.textCustomCommand;




                DisplayParams();
            }
        }

        void DisplayParams()
        {

            _view.allcoins = _params_clone.Allcoins;
            _view.allpools = _params_clone.Allpools;
            _view.erate = _params_clone.Erate;
            //_view.esm = _params_clone.Esm;
            _view.estale = _params_clone.Estale;
            _view.etha = _params_clone.Etha;
            _view.ethi = _params_clone.Ethi;
            _view.epool = _params_clone.EthPool;
            _view.epsw = _params_clone.EthPsw;
            _view.etht = _params_clone.Etht;
            _view.eworker = _params_clone.EthWorker;
            _view.solo = _params_clone.Solo;

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
