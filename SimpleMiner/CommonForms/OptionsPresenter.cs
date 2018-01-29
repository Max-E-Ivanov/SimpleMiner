using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public class OptionsPresenter : IPresenter
    {

        IOptionsView _view;

        Settings _settings;

        bool bLoad;
        public OptionsPresenter(IOptionsView _view, Settings _settings)
        {
            this._view = _view;
            this._settings = _settings;

            
            _view.PopulateLanguages(Settings.ListLang());

            _view.currentLanguage = _settings.Language;
            _view.writeLog = _settings.WriteLog;

            _view.PropertyChanged += _view_PropertyChanged;
        }

        private void _view_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _settings.Language = _view.currentLanguage;
            _settings.WriteLog = _view.writeLog;


            if (e.PropertyName == "language")
                UIHelper.ShowInfo(SimpleMiner.Properties.Resources.OptChangeLanguageMessage);

            try
            {
                SettingsManager.instance.SaveParams();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(new Exception("Error while saving params", ex));
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
