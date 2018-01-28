using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using SimpleMiner.BaseProcessHelper;

namespace SimpleMiner.Claymor
{
    public class ClaymorProcessHelper : BaseProcessHelper.BaseProcessHelper
    {
        

        public ClaymorProcessHelper(ProcessParams _params) :base( _params)
        {
         
        }
        
        public void Launch()
        {
            try
            {
               
                process = new Process();

                process.StartInfo.FileName = _params.FilePath;
                process.StartInfo.Arguments = _params.Params;
                process.StartInfo.WorkingDirectory = _params.DirectoryName;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = !_params.ShowWindow;

                foreach (var Rec in _params.listEnv)
                    process.StartInfo.EnvironmentVariables[Rec.Key] = Rec.Value;

                process.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while starting program " + _params.AppName, ex);
            }
        }

       

        public  bool IsAlive
        {
            get
            {
                try
                {
                    Process[] _prcList = Process.GetProcessesByName(Path.GetFileNameWithoutExtension( _params.AppName));
                    return (_prcList != null && _prcList.Length > 0);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error while determining is process alive", ex);
                }
            }
        }

        public void Kill()
        {
            try
            {
                Process[] _prcList = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(_params.AppName));
                if (_prcList != null && _prcList.Length > 0)
                    foreach (Process _prc in _prcList)
                        _prc.Kill();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while killing process", ex);
            }
        }
    }
}
