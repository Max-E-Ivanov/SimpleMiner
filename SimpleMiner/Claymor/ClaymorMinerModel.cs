using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SimpleMiner.BaseProcessHelper;
using SimpleMiner.BaseMining;

namespace SimpleMiner
{

    public class ClaymorParams
    {
        public string CalymoreAppPath { get; set; }

        public string EthWallet { get; set; }
        public string EthPool { get; set; }
        public string EthWorker { get; set; }

        public string EthPsw { get; set; }

        public string EthLog { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(CalymoreAppPath) &&
                !string.IsNullOrEmpty(EthPool) && !string.IsNullOrEmpty(EthWallet) && !string.IsNullOrEmpty(EthWorker);
        }


        public string ClaymorParmsString
        {
           get
            {
                string sResult = string.Empty;

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

            _processHelper.Kill();

            if (watcher != null)
                watcher.EnableRaisingEvents = false;

           // NotifyKillProcess();
        }

        private  void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            // Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);

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
