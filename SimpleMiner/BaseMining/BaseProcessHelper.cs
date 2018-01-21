using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace SimpleMiner.BaseProcessHelper
{
    public enum eProcessStatus { eWorking, eClose, eError }

    public class ProcessParams
    {

        public ProcessParams(string FilePath, string Params)
        {
            this.FilePath = FilePath;
            this.Params = Params;
        }

        public string FilePath
        {
            get; set;
        }

        public string AppName
        {
            get
            {
                if (string.IsNullOrEmpty(FilePath))
                    return string.Empty;

                return Path.GetFileName(FilePath);
            }
        }

        public string DirectoryName
        {
            get
            {
                if (string.IsNullOrEmpty(FilePath))
                    return string.Empty;

                return Path.GetDirectoryName(FilePath);
            }
        }

        public string Params
        {
            get; set;
        }
       

    }

    public class ProcessEventArgs : EventArgs
    {
        public string Status { get; private set; }

        public string Message { get; private set; }

        public eProcessStatus eStatus { get; private set; }

        public ProcessEventArgs(string status, string message, eProcessStatus eStatus)
        {
            Status = status;
            Message = message;
            this.eStatus = eStatus;
        }
    }

    public class BaseProcessHelper
    {
        public delegate void ProcessUpdateHandler(object sender, ProcessEventArgs e);

        public event ProcessUpdateHandler OnUpdateProcess;

        public virtual void NotifyPropertyChanged(string status, string message, eProcessStatus eStatus)
        {
            if (OnUpdateProcess != null)
            {

                // we should convert message                
                OnUpdateProcess(this, new ProcessEventArgs(status, message, eStatus));
            }


        }

        protected Process process;

        public ProcessParams _params;
        public BaseProcessHelper(ProcessParams _params)
        {
            process = null;
            this._params = _params;


        }
    }
}
