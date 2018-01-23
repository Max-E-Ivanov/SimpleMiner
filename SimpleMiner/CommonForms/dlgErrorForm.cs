using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public partial class dlgErrorForm : SimpleMiner.BaseForm.BaseForm, IErrorView
    {

        bool bHide;

        public dlgErrorForm()
        {
            InitializeComponent();

            bHide = true;
            //Localization

            this.Text = SimpleMiner.Properties.Resources.ErrorCaption;
            buttonClose.Text = SimpleMiner.Properties.Resources.CloseButton;
            buttonDetails.Text = SimpleMiner.Properties.Resources.ShowDetailsButton;

            toolTipManager.SetToolTip(this.buttonClose, SimpleMiner.Properties.Resources.ttErrorClose);
            toolTipManager.SetToolTip(this.buttonDetails, SimpleMiner.Properties.Resources.ttErrorDetails);

        }

        public void SetErrorMessage(string sMsg)
        {
            //textBoxMessage.Invoke(new Action(() =>            
            textBoxMessage.Text = sMsg;                
            //));
        }

        public void SetErrorDetails(string sMsg)
        {
            // textBoxDetails.Invoke(new Action(() =>
            textBoxDetails.Text = sMsg;
             //   ));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            bHide = !bHide;

            if (!bHide)
                this.Height = this.Height * 2;
            else
                this.Height = this.Height / 2;

            buttonDetails.Text = bHide? SimpleMiner.Properties.Resources.ShowDetailsButton : SimpleMiner.Properties.Resources.HideDetailsButton;


            //buttonDetails.Enabled = false;
        }

        object IView.ShowDialog()
        {
           return this.ShowDialog();
        }
    }
}
