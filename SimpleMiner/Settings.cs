﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SimpleMiner
{
    [Serializable]
    public class Settings
    {

        public Settings()
        {
            Language = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
        }

        public string Language { get; set; }

        public bool WriteLog { get; set; }


        public static List<KeyValuePair<string, string>> ListLang()
        {
            List<KeyValuePair<string, string>> _list = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("English","en-US"),
                new KeyValuePair<string, string>("Український","uk-UA"),
                new KeyValuePair<string, string>("Русский","ru-RU")
            };

            return _list;
        }
    }

    public class SettingsManager
    {
        readonly string sSettingsFileName = "settings.xml";

        Settings _curSett;
        public Settings currentSettings
        {
            get
            {
                if (_curSett == null)
                {
                    // load
                    _curSett = LoadSavedParams();
                    if (_curSett == null)
                        _curSett = new Settings();
                }

                return _curSett;
            }
        }

        private SettingsManager()
        {
        }

        static SettingsManager _settingsMan;

        public static SettingsManager instance
        {
            get
            {
                if (_settingsMan == null)
                {
                    _settingsMan = new SettingsManager();                    
                }

                return _settingsMan;
            }
        }

        #region Save/load params
        Settings LoadSavedParams()
        {
            try
            {

                if (!File.Exists(sSettingsFileName))
                    return null;

                using (var stream = System.IO.File.OpenRead(sSettingsFileName))
                {
                    var serializer = new XmlSerializer(typeof(Settings));
                    return serializer.Deserialize(stream) as Settings;
                }

            }
            catch (Exception ex)
            {
                UIHelper.ShowError(new Exception("Error while loading miner settings from file", ex));
            }

            return null;
        }

        public void SaveParams()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                using (var writer = new System.IO.StreamWriter(sSettingsFileName))
                {
                    serializer.Serialize(writer, currentSettings);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(new Exception("Error while saving miner settings to file", ex));
            }
        }
        #endregion
    }
}
