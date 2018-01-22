using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;
using SimpleMiner.BaseProcessHelper;

namespace SimpleMiner
{
    public class BaseMinerPresenter : IPresenter
    {
        protected IBaseMinerView _view;
        protected BaseMinerModelEx _model;



        public BaseMinerPresenter(IBaseMinerView _view, BaseMinerModelEx _model)
        {
            this._view = _view;
            this._model = _model;

            this._model.OnStartProcess += _model_OnStartProcess;
            this._model.OnKillProcess += _model_OnKillProcess;
            this._model.OnOutputUpdate += _model_OnOutputUpdate;
            this._model.OnTimeUpdate += _model_OnTimeUpdate;

            this._view.Run += _view_Run;
            this._view.Stop += _view_Stop;
            this._view.PropertyChanged += _view_PropertyChanged;
        }

        private void _view_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            // Someone field in view has been changed

            if ((new List<string>() { "program_name", "params" }).Contains(e.PropertyName))
            {
                _model.Client_params = new ProcessParams(_view.Program, _view.Params);
                _model.Author_params = new ProcessParams(_view.Program, "author params");
            }
    

            switch (e.PropertyName)
            {

                case "autoRestart":
                    {
                        _model.AutoRestart = _view.AutoRestart;
                        break;
                    }
            }
        }

        private void _view_Stop()
        {
            //Button Stop  pressed
            _model.currentState.Kill(_model);
        }

        protected virtual void _view_Run()
        {
            //Button Run pressed
            _model.currentState.Run(_model);
        }

        private void _model_OnStartProcess(object sender)
        {
            _view.OutputTextBox = string.Empty;
            _view.RestartLabel = _model.RestartCnt.ToString();
        }

        private void _model_OnTimeUpdate(object sender)
        {
            _view.AuthorTimeLabel = _model.ForAuthorMineSeconds.ToString();
            _view.ClentTimeLabel = _model.ForClientMineSeconds.ToString();
        }

        protected virtual  void _model_OnOutputUpdate(object sender, ProcessEventArgs e)
        {
            _view.OutputTextBox = _view.OutputTextBox + @"
"+               e.Message;

            _view.StatusLabel = e.Status;
        }

        private void _model_OnKillProcess(object sender)
        {
           
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
