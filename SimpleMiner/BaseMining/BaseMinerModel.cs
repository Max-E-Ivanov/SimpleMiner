using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMiner.BaseProcessHelper;

namespace SimpleMiner.BaseMining
{
    public class BaseMinerModel
    {
        #region Events
        public delegate void TimeUpdateHandler(object sender);
        public event TimeUpdateHandler OnTimeUpdate;
        public virtual void NotifyTimeUpdate()
        {
            if (OnTimeUpdate != null)
            {
                OnTimeUpdate(this);
            }
        }

        public delegate void OutputUpdateHandler(object sender, ProcessEventArgs e);
        public event OutputUpdateHandler OnOutputUpdate;
        public virtual void NotifyOutputUpdate(ProcessEventArgs e)
        {
            if (OnOutputUpdate != null)
            {
                OnOutputUpdate(this, e);
            }
        }

        public delegate void ActionProcessHandler(object sender);
        public event ActionProcessHandler OnStartProcess;
        public virtual void NotifyStartProcess()
        {
            if (OnStartProcess != null)
            {
                OnStartProcess(this);
            }
        }

        public event ActionProcessHandler OnKillProcess;
        public virtual void NotifyKillProcess()
        {
            if (OnKillProcess != null)
            {
                OnKillProcess(this);
            }
        }
        #endregion


    }
}
