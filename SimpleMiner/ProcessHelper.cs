using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace SimpleMiner
{

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

        public string Message{ get; private set; }

        public ProcessEventArgs(string status, string message)
        {
            Status = status;
            Message = message;
        }
    }

    public class ProcessHelper
    {

        public delegate void ProcessUpdateHandler(object sender, ProcessEventArgs e);

        public event ProcessUpdateHandler OnUpdateProcess;

        public virtual void NotifyPropertyChanged(string status, string message)
        {
            if (OnUpdateProcess != null)
            {
                OnUpdateProcess(this, new ProcessEventArgs(status, message));
            }

           
        }

        Process process;

        ProcessParams _params;
        public ProcessHelper(ProcessParams _params)
        {
            process = null;
            this._params = _params;

           
        }

        public void Launch()
        {
            try
            {
                process = new Process();

                process.EnableRaisingEvents = true;
                process.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(process_OutputDataReceived);
                process.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(process_ErrorDataReceived);
                process.Exited += new System.EventHandler(process_Exited);

                process.StartInfo.FileName = _params.FilePath;
                process.StartInfo.Arguments = _params.Params;
                process.StartInfo.WorkingDirectory = _params.DirectoryName;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = false;

                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while starting program "+_params.AppName, ex );
            }
        }

        public bool IsAlive
        {
           get
            {
                return (process != null) && (!process.HasExited);
            }
        }

        public void Restart()
        {
            Launch();
        }

        public void Kill()
        {
            try
            {
                if (IsAlive)
                  process.Kill();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while stopping program "+ _params.AppName, ex);
            }
        }

        void process_Exited(object sender, EventArgs e)
        {
            NotifyPropertyChanged("Exited", string.Format("process exited with code {0}\n", process.ExitCode.ToString()));
        }

        void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            NotifyPropertyChanged("Error", e.Data);
            //Console.WriteLine(e.Data + "\n");
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            NotifyPropertyChanged("Working...", e.Data);
            //Console.WriteLine(e.Data + "\n");
        }

    }
}
