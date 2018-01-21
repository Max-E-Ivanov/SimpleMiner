using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using SimpleMiner.BaseProcessHelper;

namespace SimpleMiner
{

    public class ProcessHelper :BaseProcessHelper.BaseProcessHelper
    {

        public ProcessHelper(ProcessParams _params) : base(_params)
        { }




        public virtual void Launch()
        {
            try
            {
                process = new Process();

               // process.EnableRaisingEvents = true;
                process.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(process_OutputDataReceived);
               // process.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(process_ErrorDataReceived);
               // process.Exited += new System.EventHandler(process_Exited);

                process.StartInfo.FileName = _params.FilePath;
                process.StartInfo.Arguments = _params.Params;
                process.StartInfo.WorkingDirectory = _params.DirectoryName;
                process.StartInfo.UseShellExecute = false;
               // process.StartInfo.RedirectStandardError = true;
                //process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
              //  process.BeginErrorReadLine();
                process.BeginOutputReadLine();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while starting program "+_params.AppName, ex );
            }
        }

        public virtual bool IsAlive
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

        public virtual void Kill()
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
            NotifyPropertyChanged("Exited", string.Format("process exited with code {0}\n", process.ExitCode.ToString()), eProcessStatus.eClose);
        }

        void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            NotifyPropertyChanged("Error", e.Data, eProcessStatus.eError);
            //Console.WriteLine(e.Data + "\n");
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            NotifyPropertyChanged("Working...", e.Data, eProcessStatus.eWorking);
            //Console.WriteLine(e.Data + "\n");
        }

    }
}
