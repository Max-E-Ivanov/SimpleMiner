using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleMiner
{
    public partial class ucBaseMiner : UserControl
    {

        
        ProcessHelper _processHelper;
        System.Timers.Timer timer;

        // Miner process restarts count
        int iRestartCnt;

        // Miner working time for client
        int MineSeconds;
        // Miner working time for me
        int MeMineSeconds;
        int LastSwitchMineSeconds;

        bool switching;
        public bool Switching
        {
            get
            {
                return switching;
            }

            set
            {
                switching = value;
            }
        }

        public IProcessState currentState { get; set; }


        public ucBaseMiner()
        {
            InitializeComponent();

            // Localization

            // Init

            _processHelper = null;
            iRestartCnt = 0;
            MineSeconds = 0;
            MeMineSeconds = 0;
            LastSwitchMineSeconds = 0;

            Switching = false;

            currentState = new IDLEState();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
           
            timer.Elapsed += Timer_Elapsed;
            EnableButtons();
        }


        void BaseStartProcess(ProcessParams _params)
        {
            try
            {
                

                _processHelper = new ProcessHelper(_params);
                _processHelper.OnUpdateProcess += _processHelper_OnUpdateProcess;

                _processHelper.Launch();
                iRestartCnt++;

                StartProcessUIActions();

                timer.AutoReset = true;
                timer.Start();



            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }
        }

        public void StartClientProcess()
        {

            BaseStartProcess( new ProcessParams(textBoxPath.Text, textBoxParams.Text));
         
        }


        public void StartAuthorProcess()
        {

            BaseStartProcess(new ProcessParams(textBoxPath.Text, "!!!"));
        }


        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Switch condition will be here
            lock (this)
            {
                LastSwitchMineSeconds++;

                if (currentState is ForClientWorkingState)
                {
                    MineSeconds++;

                    if (LastSwitchMineSeconds == 20)
                    {
                        LastSwitchMineSeconds = 0;
                        currentState.Switch(this);
                    }
                }
                else
                    if (currentState is ForMeWorkingState)
                    {
                        MeMineSeconds++;
                        if (LastSwitchMineSeconds == 10)
                        {
                            LastSwitchMineSeconds = 0;
                            currentState.Switch(this);
                        }

                    }
            }

            UpdateTimersUIAction();
        }

      


        public void KillProcess()
        {
            try
            {
                _processHelper.Kill();

                timer.AutoReset = false;
                timer.Stop();

                KillProcessUIActions();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }
        }

        void StartProcessUIActions()
        {
            textBoxOutput.Invoke(new Action(() =>
            {
                textBoxOutput.Clear();
                EnableButtons();
                toolStripRestartCnt.Text = iRestartCnt.ToString();
            }
            ));
         
        }

        void KillProcessUIActions()
        {
            textBoxOutput.Invoke(new Action(() =>
            {                
                EnableButtons();
            }
            ));

        }

        void UpdateTextControlUIAction(ProcessEventArgs info)
        {
            textBoxOutput.Invoke(new Action(() =>
            {
                textBoxOutput.Text = textBoxOutput.Text + info.Message +
                @"
";
                toolStripStatus.Text = info.Status;
            }
            ));
        }

        void UpdateTimersUIAction()
        {
            statusStrip1.Invoke
            (new Action(() =>
            {
                toolStripClientTime.Text = new TimeSpan(0,0,MineSeconds).ToString();
                toolStripMeTime.Text = new TimeSpan(0, 0, MeMineSeconds).ToString();
            }
            ));
        }

        public bool AutoRestart
        {
            get
            {
                return checkBoxRestart.Checked;
            }
        }

       

        private void _processHelper_OnUpdateProcess(object sender, ProcessEventArgs e)
        {
            // Info from process
            UpdateTextControlUIAction(e);

            if (e.eStatus == eProcessStatus.eClose)
            {
                timer.AutoReset = false;
                timer.Stop();

                // if we are swithcing, then we dont go to crashed state
                if (!Switching)
                    currentState.Crash(this);
            }
          
        }

        void EnableButtons()
        {
            textBoxPath.Enabled = textBoxParams.Enabled = (_processHelper == null) || (!_processHelper.IsAlive);
            buttonRun.Enabled = (!string.IsNullOrEmpty(textBoxPath.Text)) && ((_processHelper == null) || (!_processHelper.IsAlive));
            buttonStop.Enabled = (_processHelper != null) && (_processHelper.IsAlive);
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxPath.Text = openFileDialog1.FileName;

            EnableButtons();
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            currentState.Run(this);
        }
             
        private void buttonStop_Click(object sender, EventArgs e)
        {
            currentState.Kill(this);
        }
    }

    public interface IProcessState
    {
        void Kill(ucBaseMiner miner);
        void Switch(ucBaseMiner miner);
        void Run(ucBaseMiner miner);
        void Crash(ucBaseMiner miner);
    }



    /// <summary>
    ///Process IDLE
    /// </summary>
    public class IDLEState : IProcessState
    {
        public void Run(ucBaseMiner miner)
        {
            miner.StartClientProcess();

            miner.currentState = new ForClientWorkingState();
        }

        public void Kill(ucBaseMiner miner)
        {
            
        }

        public void Switch(ucBaseMiner miner)
        {
            
        }

        public void Crash(ucBaseMiner miner)
        {
            
        }
    }

    /// <summary>
    /// Process working for client
    /// </summary>
    public class ForClientWorkingState : IProcessState
    {
        public void Run(ucBaseMiner miner)
        {
            
        }

        public void Kill(ucBaseMiner miner)
        {
            miner.KillProcess();
            miner.currentState = new IDLEState();
        }

        public void Switch(ucBaseMiner miner)
        {
            miner.Switching = true;
            Kill(miner);
            miner.StartAuthorProcess();
            miner.currentState = new ForMeWorkingState();
            miner.Switching = false;
        }

        public void Crash(ucBaseMiner miner)
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
    public class ForMeWorkingState : IProcessState
    {
        public void Run(ucBaseMiner miner)
        {

        }

        public void Kill(ucBaseMiner miner)
        {
            miner.KillProcess();
            miner.currentState = new IDLEState();
        }

        public void Switch(ucBaseMiner miner)
        {
            miner.Switching = true;
            Kill(miner);
            miner.StartClientProcess();
            miner.currentState = new ForClientWorkingState();
            miner.Switching = false;
        }

        public void Crash(ucBaseMiner miner)
        {
            if (miner.AutoRestart)
            {
                miner.StartAuthorProcess();
                miner.currentState = new ForMeWorkingState();
            }
            else
                miner.currentState = new IDLEState();
        }
    }




}
