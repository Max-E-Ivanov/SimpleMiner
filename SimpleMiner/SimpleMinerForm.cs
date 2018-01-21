using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimpleMiner
{
    public partial class SimpleMinerForm : Form
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
                ucMiner1 ucMiner1 = new ucMiner1();

                ucBaseMiner ucBaseMiner1 = new ucBaseMiner();
                BaseMinerPresenter _presenter = new BaseMinerPresenter(ucBaseMiner1, new BaseMinerModelEx());


                TabPage tabMiner1 = new TabPage("Miner1");
                tabMiner1.Controls.Add(ucBaseMiner1);
                ucBaseMiner1.Dock = DockStyle.Fill;

                tabControlMiners.Controls.Add(tabMiner1);

                // Claymore

                SimpleMiner.Claymor.ucClaymorMiner ucClaymore = new SimpleMiner.Claymor.ucClaymorMiner();
                ClaymorMinerPresenter _claymore_presenter = new ClaymorMinerPresenter(ucClaymore, new ClaymorMinerModel());


                TabPage tabClaymoreMiner = new TabPage("Claymore");                
                tabClaymoreMiner.Controls.Add(ucClaymore);
                ucClaymore.Dock = DockStyle.Fill;

                tabControlMiners.Controls.Add(tabClaymoreMiner);

            }
            catch (Exception ex)
            {
                UIHelper.ShowError(ex);
            }
        }
    }
}
