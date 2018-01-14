using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMiner
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

        ProcessHelper _processHelper;
        System.Timers.Timer timer;

        // Miner process restarts count
        public int RestartCnt { get; private set; }

        // Miner working time for client
        public int ForClientMineSeconds { get; private set; }
        // Miner working time for me
        public int ForAuthorMineSeconds { get; private set; }

        //Seconds count after last switch
        int LastSwitchMineSeconds;
        
        public ProcessParams Client_params { get; set; }       
       
        public ProcessParams Author_params { get; set; }       

       
        public bool AutoRestart { get; set; }
                   
        public IProcessState currentState { get; set; }

       

        public BaseMinerModel()
        {
            _processHelper = null;
            RestartCnt = 0;
            ForClientMineSeconds = 0;
            ForAuthorMineSeconds = 0;
            LastSwitchMineSeconds = 0;
           

            currentState = new IDLEState();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;

            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Switch condition will be here
            lock (this)
            {
                LastSwitchMineSeconds++;

                if (currentState is ForClientWorkingState)
                {
                    ForClientMineSeconds++;

                    if (LastSwitchMineSeconds == 10)
                    {
                        LastSwitchMineSeconds = 0;
                        currentState.Switch(this);
                    }
                }
                else
                    if (currentState is ForAuthorWorkingState)
                {
                    ForAuthorMineSeconds++;
                    if (LastSwitchMineSeconds == 10)
                    {
                        LastSwitchMineSeconds = 0;
                        currentState.Switch(this);
                    }

                }
            }

            NotifyTimeUpdate();
        }

        void BaseStartProcess(ProcessParams _params)
        {
            try
            {

                _processHelper = new ProcessHelper(_params);
                _processHelper.OnUpdateProcess += _processHelper_OnUpdateProcess;

                _processHelper.Launch();
                RestartCnt++;

                NotifyStartProcess();

                timer.AutoReset = true;
                timer.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("Error during starting process " + _params.AppName, ex);
            }
        }

        public void UnSubscribeOnProcessEvent()
        {
            _processHelper.OnUpdateProcess -= _processHelper_OnUpdateProcess;
        }

        public void StartClientProcess()
        {

            BaseStartProcess(Client_params);

        }


        public void StartAuthorProcess()
        {

            BaseStartProcess(Author_params);
        }

        public void KillProcess()
        {
           
                _processHelper.Kill();

                timer.AutoReset = false;
                timer.Stop();

                NotifyKillProcess();
        }

        private void _processHelper_OnUpdateProcess(object sender, ProcessEventArgs e)
        {
            // Info from process
            NotifyOutputUpdate(e);

            if (e.eStatus == eProcessStatus.eClose)
            {
                timer.AutoReset = false;
                timer.Stop();

                // if we are swithcing, then we dont go to crashed state             
                currentState.Crash(this);
            }

        }
    }


    public interface IProcessState
    {
        void Kill(BaseMinerModel minerModel);
        void Switch(BaseMinerModel minerModel);
        void Run(BaseMinerModel minerModel);
        void Crash(BaseMinerModel minerModel);
    }



    /// <summary>
    ///Process IDLE
    /// </summary>
    public class IDLEState : IProcessState
    {
        public void Run(BaseMinerModel miner)
        {
            miner.StartClientProcess();

            miner.currentState = new ForClientWorkingState();
        }

        public void Kill(BaseMinerModel miner)
        {

        }

        public void Switch(BaseMinerModel miner)
        {

        }

        public void Crash(BaseMinerModel miner)
        {

        }
    }

    /// <summary>
    /// Process working for client
    /// </summary>
    public class ForClientWorkingState : IProcessState
    {
        public void Run(BaseMinerModel miner)
        {

        }

        public void Kill(BaseMinerModel miner)
        {
            miner.KillProcess();
            miner.currentState = new IDLEState();
        }

        public void Switch(BaseMinerModel miner)
        {
            
            miner.UnSubscribeOnProcessEvent();
            Kill(miner);
            miner.StartAuthorProcess();
            miner.currentState = new ForAuthorWorkingState();
          
        }

        public void Crash(BaseMinerModel miner)
        {
            if (miner.AutoRestart)
            {
                miner.StartClientProcess();
                miner.currentState = new ForClientWorkingState();
            }
            else
                miner.currentState = new IDLEState();
        }
    }

    /// <summary>
    /// Process working for author
    /// </summary>
    public class ForAuthorWorkingState : IProcessState
    {
        public void Run(BaseMinerModel miner)
        {

        }

        public void Kill(BaseMinerModel miner)
        {
            miner.KillProcess();
            miner.currentState = new IDLEState();
        }

        public void Switch(BaseMinerModel miner)
        {
           
            miner.UnSubscribeOnProcessEvent();
            Kill(miner);
            miner.StartClientProcess();
            miner.currentState = new ForClientWorkingState();
          
        }

        public void Crash(BaseMinerModel miner)
        {
            if (miner.AutoRestart)
            {
                miner.StartAuthorProcess();
                miner.currentState = new ForAuthorWorkingState();
            }
            else
                miner.currentState = new IDLEState();
        }
    }
}
