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
    public partial class ucBaseMiner : UserControl, INotifyPropertyChanged, IBaseMinerView
    {        
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void NotifyPropertyChanged(string sPropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(sPropertyName));
            }
        }



        public ucBaseMiner()
        {
            InitializeComponent();

            // Localization
                    
        }


        public bool AutoRestart
        {
            get
            {
                return checkBoxRestart.Checked;
            }
            set
            {
                checkBoxRestart.Checked = value;
            }
        }

        public string Program
        {
            get
            {
                return textBoxPath.Text;
            }
            set
            {
                textBoxPath.Text = value;
            }
        }

        public string Params
        {
            get
            {
                return textBoxParams.Text;
            }
            set
            {
                textBoxParams.Text = value;
            }
        }

        public string OutputTextBox
        {
            get
            {

                return (string)textBoxOutput.Invoke(new Func<string>(() =>
               {
                   return textBoxOutput.Text;
               }
                ));
               
            }
            set
            {
                textBoxOutput.Invoke(new Action(() =>
                {
                    textBoxOutput.Text = value;
                }));
            }

        }

        public string RestartLabel
        {
            get
            {
                return toolStripRestartCnt.Text;
            }
            set
            {
                statusStrip1.Invoke(new Action(() =>
                {
                    toolStripRestartCnt.Text = value;
                }));
            }

        }

        public string StatusLabel
        {
            get
            {
                return toolStripStatus.Text;
            }
            set
            {
                statusStrip1.Invoke(new Action(() =>
                {
                    toolStripStatus.Text = value;
                }));
            }

        }

        public string ClentTimeLabel
        {
            get
            {
                return toolStripClientTime.Text;
            }
            set
            {
                statusStrip1.Invoke(new Action(() =>
                {
                    toolStripClientTime.Text = value;
                }));
            }

        }

        public string AuthorTimeLabel
        {
            get
            {
                return toolStripMeTime.Text;
            }
            set
            {
                statusStrip1.Invoke(new Action(() =>
                {
                    toolStripMeTime.Text = value;
                }));
            }

        }

        private void checkBoxRestart_CheckedChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("autoRestart");
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("program_name");
        }

        private void textBoxParams_TextChanged(object sender, EventArgs e)
        {
            NotifyPropertyChanged("params");
        }


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = openFileDialog1.FileName;
                NotifyPropertyChanged("program_name");
            }
           
        }

        public event Action Run;
        public event Action Stop;

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (Run != null)
                Run();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (Stop != null)
                Stop();
        }

       

    }

  




}
