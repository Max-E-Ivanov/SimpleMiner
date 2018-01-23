using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;
using SimpleMiner.BaseProcessHelper;
using System.IO;

namespace SimpleMiner.Claymor
{
    public class ClaymorMinerPresenter :IPresenter
    {
        protected IClaymorMinerView _view;
        protected ClaymorMinerModel _model;

        public ClaymorMinerPresenter(IClaymorMinerView _view, ClaymorMinerModel _model) 
        {           
            this._view = _view;
            this._model = _model;


            _params = new ClaymorParams();

            _params.CalymoreAppPath = Utils.GetAppPath() + @"\Claymore\EthDcrMiner64.exe";

          

            _params.EthPsw = "x";

            _params.EthPool = "eth-eu.dwarfpool.com:8008";
            _params.EthWallet = "0xD69af2A796A737A103F12d2f0BCC563a13900E6F";




            _view.clParams = _params;

            PopulateETHPools();

           // this._model.OnStartProcess += _model_OnStartProcess;
           // this._model.OnKillProcess += _model_OnKillProcess;
            this._model.OnOutputUpdate += _model_OnOutputUpdate;
            //this._model.OnTimeUpdate += _model_OnTimeUpdate;

            this._view.Run += _view_Run;
            this._view.Stop += _view_Stop;
            this._view.Config += _view_Config;
            this._view.PropertyChanged += _view_PropertyChanged;

            _view_PropertyChanged(null, new System.ComponentModel.PropertyChangedEventArgs("params"));
        }

        void PopulateETHPools()
        {
            List<string> lsPopls = new List<string> { "us1.ethpool.org:3333", "us1.ethermine.org:4444", "eth-eu.dwarfpool.com:8008", "eu1.nanopool.org:9999",
            "stratum+tcp://daggerhashimoto.eu.nicehash.com:3353", "us-east1.ethereum.miningpoolhub.com:20536", "us-east1.ethereum.miningpoolhub.com:20536"};

            _view.PopulateEthPools(lsPopls);
        }


        ClaymorParams _params;

        private void _view_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // Someone field in view has been changed

            if (e.PropertyName == "params")
            {
                _view.buttonStartEnabled = _params.Validate();
            }
        }


        protected  void _view_Run()
        {
            try
            {
                if (!File.Exists(_params.CalymoreAppPath))
                    UIHelper.ShowError("Miner file absent");

                _params.EthLog = DateTime.Now.ToString("yyyy_dd_MM_hh_mm_ss") + ".log";

                _model.StartProcess(_params);
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }
        }

        protected void _view_Stop()
        {
            try
            { 
                _model.KillProcess();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }

        }

        protected void _view_Config()
        {
            try
            {
                UIHelper.ShowClaymorConfigDlg(_params);
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }

        }

        protected  void _model_OnOutputUpdate(object sender, ProcessEventArgs e)
        {
            try
            { 
                _view.OutputTextBox =  e.Message;
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
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
