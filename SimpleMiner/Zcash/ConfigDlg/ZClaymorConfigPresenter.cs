using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;


namespace SimpleMiner.Claymor
{
    public class ZClaymorConfigPresenter : IPresenter
    {
        IZClaymorConfigView _view;
        ClaymorParams _params;
        ClaymorParams _params_clone;

        bool bLoad;

        public ZClaymorConfigPresenter(IZClaymorConfigView _view, ClaymorParams _params) : base()
        {
            this._view = _view;
            this._params = _params;

            _params_clone = _params.DeepClone();

            this._view.PropertyChanged += _view_PropertyChanged;
            this._view.Ok += _view_Ok;
            this._view.Default += _view_Default;
            this._view.GenerateCommand += _view_GenerateCommand;



            
            bLoad = true;

            _view.PopulateEsmList(ClaymorParams.ListEsm());
            _view.PopulateEPools(ClaymorParams.ListEPools());
            _view.PopulateDPools(ClaymorParams.ListDPools());
            _view.PopulateDCoins(ClaymorParams.ListDcoins());

            DisplayParams();
            bLoad = false;
        }

        private void _view_GenerateCommand()
        {
            string sCommand = _params_clone.ClaymorParmsString(true);

            _view.textCustomCommand = sCommand;
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
                _params_clone.Esm = _view.esm;
                _params_clone.Estale = _view.estale;
                _params_clone.Etha = _view.etha;
                _params_clone.Ethi = _view.ethi;
                _params_clone.EthPool = _view.epool;
                _params_clone.EthPsw = _view.epsw;
                _params_clone.Etht = _view.etht;
                _params_clone.EthWorker = _view.eworker;
                _params_clone.Solo = _view.solo;

                // -----------------
                _params_clone.Mode = _view.mode;
                _params_clone.Dpool = _view.dpool;
                _params_clone.Dwal = _view.dwal;
                _params_clone.Dpsw = _view.dpsw;
                _params_clone.Dcri = _view.dcri;
                _params_clone.Dcrt = _view.dcrt;
                _params_clone.Dcoin = _view.dcoin;

                // -----------------
                _params_clone.CustomParams = _view.textCustomCommand;

                // -------------
                _params_clone.GPU_FORCE_64BIT_PTR0 = _view.GPU_FORCE_64BIT_PTR0;
                _params_clone.GPU_MAX_ALLOC_PERCENT = _view.GPU_MAX_ALLOC_PERCENT;
                _params_clone.GPU_MAX_HEAP_SIZE100 = _view.GPU_MAX_HEAP_SIZE100;
                _params_clone.GPU_SINGLE_ALLOC_PERCENT = _view.GPU_SINGLE_ALLOC_PERCENT;
                _params_clone.GPU_USE_SYNC_OBJECTS = _view.GPU_USE_SYNC_OBJECTS;

                // ---------------
                _params_clone.ShowWindow = _view.showwindow;
                _params_clone.Restart = _view.restart;

                DisplayParams();
            }
        }

        void DisplayParams()
        {

            _view.allcoins = _params_clone.Allcoins;
            _view.allpools = _params_clone.Allpools;
            _view.erate = _params_clone.Erate;

            _view.esm = _params_clone.Esm;            

            _view.estale = _params_clone.Estale;
            _view.etha = _params_clone.Etha;
            _view.ethi = _params_clone.Ethi;
            _view.epool = _params_clone.EthPool;
            _view.epsw = _params_clone.EthPsw;
            _view.etht = _params_clone.Etht;
            _view.eworker = _params_clone.EthWorker;
            _view.solo = _params_clone.Solo;

            // -------------------------
            _view.mode = _params_clone.Mode;
            _view.dpool = _params_clone.Dpool;
            _view.dwal = _params_clone.Dwal;
            _view.dpsw = _params_clone.Dpsw;
            _view.dcri = _params_clone.Dcri;
            _view.dcrt = _params_clone.Dcrt;
            _view.dcoin = _params_clone.Dcoin;

            // ---------------------------------
            _view.textCustomCommand = _params_clone.CustomParams;

            // -------------
            _view.GPU_FORCE_64BIT_PTR0 = _params_clone.GPU_FORCE_64BIT_PTR0;
            _view.GPU_MAX_ALLOC_PERCENT = _params_clone.GPU_MAX_ALLOC_PERCENT;
            _view.GPU_MAX_HEAP_SIZE100 = _params_clone.GPU_MAX_HEAP_SIZE100;
            _view.GPU_SINGLE_ALLOC_PERCENT = _params_clone.GPU_SINGLE_ALLOC_PERCENT;
            _view.GPU_USE_SYNC_OBJECTS = _params_clone.GPU_USE_SYNC_OBJECTS;

            // ---------------
            _view.showwindow = _params_clone.ShowWindow;
            _view.restart = _params_clone.Restart;


            _view.buttonOkEnabled = _params_clone.Validate();            
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
