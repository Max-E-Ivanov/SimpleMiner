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
    [Serializable]
    public class ClaymorParams
    {

        public ClaymorParams()
        {
        }

        public string CalymoreAppPath { get; set; }

        public bool ShowWindow { get; set; }
        public bool Restart { get; set; }

        public string EthWallet { get; set; }
        public string EthPool { get; set; }
        public string EthWorker { get; set; }

        public string EthPsw { get; set; }

        public string EthLog { get; set; }

        public string CustomParams { get; set; }

        public bool Solo { get; set; }
        public string Etht { get; set; }
        public bool Allpools { get; set; }
        public string Allcoins { get; set; }
        public bool Estale { get; set; }
        public bool Erate { get; set; }

        public string Etha { get; set; }
        public string Ethi { get; set; }

        public string Esm { get; set; }


        //Second coin
        public bool Mode { get; set; }

        public string Dpool { get; set; }
        public string Dwal { get; set; }
        public string Dpsw { get; set; }
        public string Dcri { get; set; }
        public string Dcrt { get; set; }
        public string Dcoin { get; set; }


        //GPUSettings
        public bool GPU_FORCE_64BIT_PTR0 { get; set; }
        public bool GPU_MAX_HEAP_SIZE100 { get; set; }
        public bool GPU_USE_SYNC_OBJECTS { get; set; }
        public bool GPU_MAX_ALLOC_PERCENT { get; set; }
        public bool GPU_SINGLE_ALLOC_PERCENT { get; set; }

        public List<KeyValuePair<string, string>> ListEnv()
        {
            List<KeyValuePair<string, string>> _list = new List<KeyValuePair<string, string>>();

            if (GPU_FORCE_64BIT_PTR0)
                _list.Add(new KeyValuePair<string, string>("GPU_FORCE_64BIT_PTR", "0"));

            if (GPU_MAX_HEAP_SIZE100)
                _list.Add(new KeyValuePair<string, string>("GPU_MAX_HEAP_SIZE", "100"));

            if (GPU_USE_SYNC_OBJECTS)
                _list.Add(new KeyValuePair<string, string>("GPU_USE_SYNC_OBJECTS", "1"));

            if (GPU_MAX_ALLOC_PERCENT)
                _list.Add(new KeyValuePair<string, string>("GPU_MAX_ALLOC_PERCENT", "100"));

            if (GPU_SINGLE_ALLOC_PERCENT)
                _list.Add(new KeyValuePair<string, string>("GPU_SINGLE_ALLOC_PERCENT", "100"));

            return _list;
        }

        public bool Validate()
        {

            //if (!File.Exists(CalymoreAppPath))
            //   return false;

            if (string.IsNullOrEmpty(CalymoreAppPath))
                return false;

            // Custom command always valid
            if (!string.IsNullOrEmpty(CustomParams))
                return true;


            // -- First coin
            if (string.IsNullOrEmpty(EthPool))
                return false;

            if (string.IsNullOrEmpty(EthWallet))
                return false;

            // -- Second coin

            if (Mode)
            {
                if (string.IsNullOrEmpty(Dpool))
                    return false;

                if (string.IsNullOrEmpty(Dwal))
                    return false;


            }

            return true;
        }

       

        public ClaymorParams DeepClone()
        {
            /*ClaymorParams _params = new ClaymorParams();
            _params.EthLog = this.EthLog;
            _params.EthPool = this.EthPool;
            _params.EthPsw = this.EthPsw;
            _params.EthWallet = this.EthWallet;
            _params.EthWorker = this.EthWorker;
            _params.CustomParams = this.CustomParams;
            _params.CalymoreAppPath = this.CalymoreAppPath;

            _params.Allcoins = this.Allcoins;
            _params.Allpools = this.Allpools;
            _params.Erate = this.Erate;
            _params.Esm = this.Esm;
            _params.Estale = this.Estale;
            _params.Etha = this.Etha;
            _params.Ethi = this.Ethi;
            _params.Etht = this.Etht;
            _params.Solo = this.Solo;

            return _params;*/

            return (ClaymorParams)this.MemberwiseClone();
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
            this.ShowWindow = _params.ShowWindow;
            this.Restart = _params.Restart;

            this.Allcoins = _params.Allcoins;
            this.Allpools = _params.Allpools;
            this.Erate = _params.Erate;
            this.Esm = _params.Esm;
            this.Estale = _params.Estale;
            this.Etha = _params.Etha;
            this.Ethi = _params.Ethi;
            this.Etht = _params.Etht;
            this.Solo = _params.Solo;

            this.Mode = _params.Mode;
            this.Dcoin = _params.Dcoin;
            this.Dcri = _params.Dcri;
            this.Dcrt = _params.Dcrt;
            this.Dpool = _params.Dpool;
            this.Dpsw = _params.Dpsw;
            this.Dwal = _params.Dwal;

            this.GPU_FORCE_64BIT_PTR0 = _params.GPU_FORCE_64BIT_PTR0;
            this.GPU_MAX_ALLOC_PERCENT = _params.GPU_MAX_ALLOC_PERCENT;
            this.GPU_MAX_HEAP_SIZE100 = _params.GPU_MAX_HEAP_SIZE100;
            this.GPU_SINGLE_ALLOC_PERCENT = _params.GPU_SINGLE_ALLOC_PERCENT;
            this.GPU_USE_SYNC_OBJECTS = _params.GPU_USE_SYNC_OBJECTS;

        }

      

        public void RestoreDefaults()
        {
            ClaymorParams _prm = new ClaymorParams
            {
                CalymoreAppPath = Utils.GetAppPath() + @"\Claymore\EthDcrMiner64.exe",
                EthPsw = "x",
                EthPool = "eu1.ethermine.org:4444",
                EthWallet = "0x1770Ed0d79eDf091a7521C5Ee82212EFf308C933",
                Allcoins = "1"
            };

            CopyFrom(_prm);

        }

        public string ClaymorParmsString (bool bGenerate)
        {
           
            {
                string sResult = string.Empty;

                if (!bGenerate && (!string.IsNullOrEmpty(CustomParams)))
                    return CustomParams + " -logfile " + EthLog;

                // ------------------

                if (!string.IsNullOrEmpty(EthPool))
                    sResult = sResult + " -epool " + (Solo? @"": "http://") + EthPool;

                if (!string.IsNullOrEmpty(EthWallet))
                    sResult = sResult + " -ewal " + EthWallet;

                if (!string.IsNullOrEmpty(EthWorker))
                    sResult = sResult + " -eworker " + EthWorker;

                if (!string.IsNullOrEmpty(EthPsw))
                    sResult = sResult + " -epsw " + EthPsw;

                if (!string.IsNullOrEmpty(Etha))
                    sResult = sResult + " -etha " + Etha;

                if (!string.IsNullOrEmpty(Ethi))
                    sResult = sResult + " -ethi " + Ethi;

                if (!string.IsNullOrEmpty(Etht))
                    sResult = sResult + " -etht " + Etht;

                if (Allpools)
                    sResult = sResult + " -allpools " + "1";

                if (!string.IsNullOrEmpty(Allcoins))
                    sResult = sResult + " -allcoins " + Allcoins;

                if (Estale)
                    sResult = sResult + " -estale " + "1";

                if (Erate)
                    sResult = sResult + " -erate " + "1";

                if (!string.IsNullOrEmpty(Esm))
                    sResult = sResult + " -esm " + Esm;

                // --- Second coin ---
                
                 sResult = sResult + " -mode " + (Mode? "0" :"1");

                if (!string.IsNullOrEmpty(Dpool))
                    sResult = sResult + " -dpool " + Dpool;

                if (!string.IsNullOrEmpty(Dwal))
                    sResult = sResult + " -dwal " + Dwal;

                if (!string.IsNullOrEmpty(Dpsw))
                    sResult = sResult + " -dpsw " + Dpsw;

                if (!string.IsNullOrEmpty(Dcri))
                    sResult = sResult + " -dcri " + Dcri;

                if (!string.IsNullOrEmpty(Dcrt))
                    sResult = sResult + " -dcrt " + Dcrt;

                if (!string.IsNullOrEmpty(Dcoin))
                    sResult = sResult + " -dcoin " + Dcoin;




                // ----------------
                if (!string.IsNullOrEmpty(EthLog))
                    sResult = sResult + " -logfile " + EthLog;


                return sResult;
            }
        }

        public static  List<KeyValuePair<string, string>> ListEsm()
        {
            return new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("0", "eth-proxy"),
                new KeyValuePair<string, string>("1", "qtminer "),
                new KeyValuePair<string, string>("2", "miner-proxy"),
                new KeyValuePair<string, string>("3", "nicehash")
            };
        }

        public static List<string> ListEPools()
        {
            return new List<string> {
                "eu1.ethermine.org:4444",
                "us1.ethpool.org:3333",
                "us1.ethermine.org:4444",
                "eth-eu.dwarfpool.com:8008",
                "eu1.nanopool.org:9999",               
                "us-east1.ethereum.miningpoolhub.com:20536" };

        }

        public static List<string> ListDPools()
        {
            return new List<string> {
                @"stratum+tcp://yiimp.ccminer.org:4252",
                @"stratum+tcp://dcr.suprnova.cc:3252",
                @"stratum+tcp://lbry.suprnova.cc:6256",
                @"stratum+tcp://sia-eu1.nanopool.org:7777",
                @"stratum+tcp://decred.eu.nicehash.com:3354",
                @"stratum+tcp://hub.miningpoolhub.com:20550",
                @"sia.suprnova.cc:7777",
                @"http://dcr.suprnova.cc:9111",
                @"stratum+tcp://dcr.coinmine.pl:2222",
                @"stratum+tcp://pasc.suprnova.cc:5279",
            @"http://sia-eu1.nanopool.org:9980/miner/header?address",
            @"http://siamining.com:9980/miner/header?address="};

        }

        public static List<string> ListDcoins()
        {
            return new List<string> {
                @"dcr",
                @"sc",
                @"lbc",
                @"pasc"};

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

                ProcessParams _params = new ProcessParams(_clParams.CalymoreAppPath, _clParams.ClaymorParmsString(false));
                _params.ShowWindow = _clParams.ShowWindow;
                _params.listEnv.AddRange(_clParams.ListEnv());
                
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
