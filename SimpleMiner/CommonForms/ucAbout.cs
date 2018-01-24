using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMiner.MVP;

namespace SimpleMiner
{
    public partial class ucAbout : SimpleMiner.BaseForm.ucBaseUserControl, IAboutView
    {
        public ucAbout()
        {
            InitializeComponent();

            //Loaclization
            linkLabelMail.Text = SimpleMiner.Properties.Resources.MailTo;
            linkLabelWeb.Text = SimpleMiner.Properties.Resources.Web;
        }

        public event Action Web;
        public event Action Mail;

        public void SetVersion(string sVersion)
        {
            labelVersion.Text = sVersion;
        }
        public void SetWebVisited()
        {
            linkLabelWeb.LinkVisited = true;
        }

        public void SetMailVisited()
        {
            linkLabelMail.LinkVisited = true;
        }

        public object ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void linkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Web != null)
                Web();
        }

        private void linkLabelMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Mail != null)
                Mail();
        }
    }
}
