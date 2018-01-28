using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;
using SimpleMiner.BaseProcessHelper;
using System.IO;
using System.Xml.Serialization;

namespace SimpleMiner.Claymor
{
    public class ClaymorMinerPresenter :IPresenter
    {

        protected readonly string sSettingsFileName = "claymore.xml";
        protected IClaymorMinerView _view;
        protected ClaymorMinerModel _model;

        public ClaymorMinerPresenter(IClaymorMinerView _view, ClaymorMinerModel _model) 
        {           
            this._view = _view;
            this._model = _model;


            _params = new ClaymorParams();

            // Here wi should load saved settings
            _params.RestoreDefaults();
            LoadSavedParams();


            _view.clParams = _params;

            PopulatePools();

           // this._model.OnStartProcess += _model_OnStartProcess;
           // this._model.OnKillProcess += _model_OnKillProcess;
            this._model.OnOutputUpdate += _model_OnOutputUpdate;
            //this._model.OnTimeUpdate += _model_OnTimeUpdate;

            this._view.Run += _view_Run;
            this._view.Stop += _view_Stop;
            this._view.Config += _view_Config;
            this._view.CreateWallet += _view_CreateWallet;
            this._view.PropertyChanged += _view_PropertyChanged;

            _view_PropertyChanged(null, new System.ComponentModel.PropertyChangedEventArgs("params"));
        }

        private void _view_CreateWallet()
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.myetherwallet.com/");

                _view.SetCreateWalletVisited();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex.Message);
            }
        }

        void PopulatePools()
        {
            _view.PopulateEthPools(ClaymorParams.ListEPools());
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
                SaveParams();

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

                //ReloadParams
                _view.clParams = _params;
                _view.buttonStartEnabled = _params.Validate();
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



        void LoadSavedParams()
        {
            try
            {

                if (!File.Exists(sSettingsFileName))
                    return;

                using (var stream = System.IO.File.OpenRead(sSettingsFileName))
                {
                    var serializer = new XmlSerializer(typeof(ClaymorParams));
                    _params = serializer.Deserialize(stream) as ClaymorParams;
                }
               
            }
            catch (Exception ex)
            {
                UIHelper.ShowError( new Exception("Error while loading miner settings from file", ex));
            }
        }

        void SaveParams()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ClaymorParams));

                using (var writer = new System.IO.StreamWriter(sSettingsFileName))
                {
                    serializer.Serialize(writer, _params);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError( new Exception( "Error while saving miner settings to file", ex));
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
