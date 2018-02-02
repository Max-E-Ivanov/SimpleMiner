using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMiner.Claymor;

namespace SimpleMiner
{
    public partial class SimpleMinerForm : SimpleMiner.BaseForm.BaseForm
    {
        public SimpleMinerForm()
        {
            InitializeComponent();

            // Loaclization Part
            this.Text = SimpleMiner.Properties.Resources.Caption;


            //Init
            CreateMiners();
        }

        void CreateMiners()
        {
            try
            {

                tabControlMiners.ImageList = imageListForTabs;
               
                // About
                ucAbout ucAbout = new ucAbout();
                AboutPresenter _about_presenter = new AboutPresenter(ucAbout);

                TabPage tabAbout = new TabPage(SimpleMiner.Properties.Resources.tabAbout);
                tabAbout.ImageIndex = 0;
                tabAbout.Controls.Add(ucAbout);
                ucAbout.Dock = DockStyle.Fill;
                tabControlMiners.Controls.Add(tabAbout);

                // Test
               /* ucMiner1 ucMiner1 = new ucMiner1();
                ucBaseMiner ucBaseMiner1 = new ucBaseMiner();
                BaseMinerPresenter _presenter = new BaseMinerPresenter(ucBaseMiner1, new BaseMinerModelEx());


                TabPage tabMiner1 = new TabPage("Test (redirect output)");
                tabMiner1.Controls.Add(ucBaseMiner1);
                ucBaseMiner1.Dock = DockStyle.Fill;

                tabControlMiners.Controls.Add(tabMiner1);*/

                // Claymore
                SimpleMiner.Claymor.ucClaymorMiner ucClaymore = new SimpleMiner.Claymor.ucClaymorMiner();
                ClaymorMinerPresenter _claymore_presenter = new ClaymorMinerPresenter(ucClaymore, new ClaymorMinerModel());

                TabPage tabClaymoreMiner = new TabPage(SimpleMiner.Properties.Resources.tabEthereum);
                tabClaymoreMiner.ImageIndex = 1;                
                tabClaymoreMiner.Controls.Add(ucClaymore);
                ucClaymore.Dock = DockStyle.Fill;
                tabControlMiners.Controls.Add(tabClaymoreMiner);

                // ZClaymore
                SimpleMiner.Claymor.ucClaymorZMiner ucZClaymore = new SimpleMiner.Claymor.ucClaymorZMiner();
                ClaymorZMinerPresenter _claymore_z_presenter = new ClaymorZMinerPresenter(ucZClaymore, new ClaymorMinerModel());

                TabPage tabClaymoreZMiner = new TabPage("ZCash (Radeon)");
                tabClaymoreZMiner.ImageIndex = 3;
                tabClaymoreZMiner.Controls.Add(ucZClaymore);
                ucZClaymore.Dock = DockStyle.Fill;
                tabControlMiners.Controls.Add(tabClaymoreZMiner);

                // Options
                ucOptions ucOptions = new ucOptions();
                OptionsPresenter _options_presenter = new OptionsPresenter(ucOptions, SettingsManager.instance.currentSettings);

                TabPage tabOptions = new TabPage(SimpleMiner.Properties.Resources.tabOptions);
                tabOptions.ImageIndex = 2;
                tabOptions.Controls.Add(ucOptions);
                ucOptions.Dock = DockStyle.Fill;
                tabControlMiners.Controls.Add(tabOptions);

            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }
        }
    }
}
