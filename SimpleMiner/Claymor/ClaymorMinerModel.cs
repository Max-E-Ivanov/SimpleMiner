using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SimpleMiner.BaseProcessHelper;
using SimpleMiner.BaseMining;

namespace SimpleMiner.Claymor
{

    public class ClaymorParams :ICloneable
    {
        public string CalymoreAppPath { get; set; }

        public string EthWallet { get; set; }
        public string EthPool { get; set; }
        public string EthWorker { get; set; }

        public string EthPsw { get; set; }

        public string EthLog { get; set; }

        public string CustomParams { get; set; }


        public bool Validate()
        {

            //if (!File.Exists(CalymoreAppPath))
             //   return false;

            if (!string.IsNullOrEmpty(CustomParams))
                return true;


            return !string.IsNullOrEmpty(CalymoreAppPath) &&
                !string.IsNullOrEmpty(EthPool) && !string.IsNullOrEmpty(EthWallet);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public ClaymorParams DeepClone()
        {
            return (ClaymorParams)Clone();
        }

        public void CopyFrom(ClaymorParams _params)
        {
            this.EthLog = _params.EthLog;
            this.EthPool = _params.EthPool;
            this.EthPsw = _params.EthPsw;
            this.EthWallet = _params.EthWallet;
            this.EthWorker = _params.EthWorker;
            this.CustomParams = _params.CustomParams;
            this.CalymoreAppPath = _params.CalymoreAppPath;
           
        }

        public void RestoreDefaults()
        {
            ClaymorParams _prm = new ClaymorParams
            {
                CalymoreAppPath = Utils.GetAppPath() + @"\Claymore\EthDcrMiner64.exe",
                EthPsw = "x",
                EthPool = "eth-eu.dwarfpool.com:8008"
            };

            CopyFrom(_prm);

        }

        public string ClaymorParmsString
        {
           get
            {
                string sResult = string.Empty;

                if (!string.IsNullOrEmpty(CustomParams))
                    return CustomParams + " -logfile " + EthLog;

                // ------------------

                if (!string.IsNullOrEmpty(EthPool))
                    sResult = sResult + " -epool " + EthPool;

                if (!string.IsNullOrEmpty(EthWallet))
                    sResult = sResult + " -ewal " + EthWallet;

                if (!string.IsNullOrEmpty(EthWorker))
                    sResult = sResult + "/" + EthWorker;

                if (!string.IsNullOrEmpty(EthPsw))
                    sResult = sResult + " -epsw " + EthPsw;

                if (!string.IsNullOrEmpty(EthLog))
                    sResult = sResult + " -logfile " + EthLog;


                return sResult;
            }
        }
    }

    public class ClaymorMinerModel : BaseMinerModel
    {
        ClaymorProcessHelper _processHelper;
        FileSystemWatcher watcher;
        ClaymorParams clParams;

        public  void StartProcess(ClaymorParams _clParams)
        {
            try
            {
                this.clParams = _clParams;

                ProcessParams _params = new ProcessParams(_clParams.CalymoreAppPath, _clParams.ClaymorParmsString);
                _processHelper = new ClaymorProcessHelper(_params);
                _processHelper.Launch();
                
                //NotifyStartProcess();


                watcher = new FileSystemWatcher();
                watcher.Path = _params.DirectoryName;
              
                /* Watch for changes in LastAccess and LastWrite times, and
                   the renaming of files or directories. */
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                   | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                // Only watch text files.
                watcher.Filter = _clParams.EthLog;

                // Add event handlers.
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnChanged);
               


                // Begin watching.
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error during starting process " + _processHelper._params.AppName, ex);
            }
        }

        public  void KillProcess()
        {
            try
            {
                _processHelper.Kill();

                if (watcher != null)
                    watcher.EnableRaisingEvents = false;

                // NotifyKillProcess();
            }
            catch (Exception ex)
            {
                throw new Exception("Error during kill process " + _processHelper._params.AppName, ex);
            }
        }

        private  void OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.Name.ToUpper() == clParams.EthLog.ToUpper())
            {
                try
                {
                    string sLog = File.ReadAllText(e.FullPath);
                    NotifyOutputUpdate(new ProcessEventArgs("Working...", sLog, eProcessStatus.eWorking));
                }
                catch (Exception ex)
                { }
            }
        }



    }
}
