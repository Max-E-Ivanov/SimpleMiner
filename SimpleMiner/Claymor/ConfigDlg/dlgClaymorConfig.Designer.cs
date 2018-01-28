namespace SimpleMiner.Claymor
{
    partial class dlgClaymorConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDefaults = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabPageCustomCommand = new System.Windows.Forms.TabPage();
            this.textBoxCustomCommand = new System.Windows.Forms.TextBox();
            this.checkBoxCustomCommand = new System.Windows.Forms.CheckBox();
            this.buttonCustomCommand = new System.Windows.Forms.Button();
            this.tabPageCoins = new System.Windows.Forms.TabPage();
            this.checkBoxEpsw = new System.Windows.Forms.CheckBox();
            this.checkBoxAllCoins = new System.Windows.Forms.CheckBox();
            this.textBoxAllCoins = new System.Windows.Forms.TextBox();
            this.textBoxDcrt = new System.Windows.Forms.TextBox();
            this.textBoxDcri = new System.Windows.Forms.TextBox();
            this.textBoxDPsw = new System.Windows.Forms.TextBox();
            this.textBoxDwal = new System.Windows.Forms.TextBox();
            this.textBoxEtht = new System.Windows.Forms.TextBox();
            this.textBoxETHA = new System.Windows.Forms.TextBox();
            this.textBoxEthi = new System.Windows.Forms.TextBox();
            this.textBoxEthWorker = new System.Windows.Forms.TextBox();
            this.textBoxEpsw = new System.Windows.Forms.TextBox();
            this.checkBoxAllPools = new System.Windows.Forms.CheckBox();
            this.comboBoxDcoin = new System.Windows.Forms.ComboBox();
            this.checkBoxDcoin = new System.Windows.Forms.CheckBox();
            this.checkBoxDcrt = new System.Windows.Forms.CheckBox();
            this.checkBoxDcri = new System.Windows.Forms.CheckBox();
            this.checkBoxDpsw = new System.Windows.Forms.CheckBox();
            this.labelDWal = new System.Windows.Forms.Label();
            this.comboBoxDPool = new System.Windows.Forms.ComboBox();
            this.labelDpool = new System.Windows.Forms.Label();
            this.checkBoxMode = new System.Windows.Forms.CheckBox();
            this.checkBoxErate = new System.Windows.Forms.CheckBox();
            this.checkBoxEstale = new System.Windows.Forms.CheckBox();
            this.checkBoxEtha = new System.Windows.Forms.CheckBox();
            this.checkBoxEthI = new System.Windows.Forms.CheckBox();
            this.checkBoxEsm = new System.Windows.Forms.CheckBox();
            this.checkBoxEthWorker = new System.Windows.Forms.CheckBox();
            this.comboBoxEthProtocol = new System.Windows.Forms.ComboBox();
            this.checkBoxSolo = new System.Windows.Forms.CheckBox();
            this.comboBoxEpool = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGPUSettings = new System.Windows.Forms.TabPage();
            this.checkBoxGPU_FORCE_64BIT_PTR0 = new System.Windows.Forms.CheckBox();
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxShowWindow = new System.Windows.Forms.CheckBox();
            this.checkBoxGPU_MAX_HEAP_SIZE100 = new System.Windows.Forms.CheckBox();
            this.checkBoxGPU_USE_SYNC_OBJECTS1 = new System.Windows.Forms.CheckBox();
            this.checkBoxGPU_MAX_ALLOC_PERCENT100 = new System.Windows.Forms.CheckBox();
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100 = new System.Windows.Forms.CheckBox();
            this.tabPageCustomCommand.SuspendLayout();
            this.tabPageCoins.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGPUSettings.SuspendLayout();
            this.tabPageOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDefaults
            // 
            this.buttonDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDefaults.Location = new System.Drawing.Point(1, 381);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new System.Drawing.Size(137, 25);
            this.buttonDefaults.TabIndex = 0;
            this.buttonDefaults.Text = "RestoreDefaults";
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new System.EventHandler(this.buttonDefaults_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(262, 381);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 25);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(362, 381);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 25);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomCommand
            // 
            this.tabPageCustomCommand.Controls.Add(this.textBoxCustomCommand);
            this.tabPageCustomCommand.Controls.Add(this.checkBoxCustomCommand);
            this.tabPageCustomCommand.Controls.Add(this.buttonCustomCommand);
            this.tabPageCustomCommand.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomCommand.Name = "tabPageCustomCommand";
            this.tabPageCustomCommand.Size = new System.Drawing.Size(458, 346);
            this.tabPageCustomCommand.TabIndex = 2;
            this.tabPageCustomCommand.Text = "Custom command";
            this.tabPageCustomCommand.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomCommand
            // 
            this.textBoxCustomCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomCommand.Location = new System.Drawing.Point(7, 38);
            this.textBoxCustomCommand.Multiline = true;
            this.textBoxCustomCommand.Name = "textBoxCustomCommand";
            this.textBoxCustomCommand.Size = new System.Drawing.Size(441, 305);
            this.textBoxCustomCommand.TabIndex = 4;
            this.textBoxCustomCommand.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxCustomCommand
            // 
            this.checkBoxCustomCommand.AutoSize = true;
            this.checkBoxCustomCommand.Location = new System.Drawing.Point(7, 15);
            this.checkBoxCustomCommand.Name = "checkBoxCustomCommand";
            this.checkBoxCustomCommand.Size = new System.Drawing.Size(127, 17);
            this.checkBoxCustomCommand.TabIndex = 3;
            this.checkBoxCustomCommand.Text = "UseCustomCommand";
            this.checkBoxCustomCommand.UseVisualStyleBackColor = true;
            this.checkBoxCustomCommand.CheckedChanged += new System.EventHandler(this.checkBoxCustomCommand_CheckedChanged);
            // 
            // buttonCustomCommand
            // 
            this.buttonCustomCommand.Location = new System.Drawing.Point(154, 7);
            this.buttonCustomCommand.Name = "buttonCustomCommand";
            this.buttonCustomCommand.Size = new System.Drawing.Size(207, 25);
            this.buttonCustomCommand.TabIndex = 2;
            this.buttonCustomCommand.Text = "Generate";
            this.buttonCustomCommand.UseVisualStyleBackColor = true;
            this.buttonCustomCommand.Click += new System.EventHandler(this.buttonCustomCommand_Click);
            // 
            // tabPageCoins
            // 
            this.tabPageCoins.Controls.Add(this.checkBoxEpsw);
            this.tabPageCoins.Controls.Add(this.checkBoxAllCoins);
            this.tabPageCoins.Controls.Add(this.textBoxAllCoins);
            this.tabPageCoins.Controls.Add(this.textBoxDcrt);
            this.tabPageCoins.Controls.Add(this.textBoxDcri);
            this.tabPageCoins.Controls.Add(this.textBoxDPsw);
            this.tabPageCoins.Controls.Add(this.textBoxDwal);
            this.tabPageCoins.Controls.Add(this.textBoxEtht);
            this.tabPageCoins.Controls.Add(this.textBoxETHA);
            this.tabPageCoins.Controls.Add(this.textBoxEthi);
            this.tabPageCoins.Controls.Add(this.textBoxEthWorker);
            this.tabPageCoins.Controls.Add(this.textBoxEpsw);
            this.tabPageCoins.Controls.Add(this.checkBoxAllPools);
            this.tabPageCoins.Controls.Add(this.comboBoxDcoin);
            this.tabPageCoins.Controls.Add(this.checkBoxDcoin);
            this.tabPageCoins.Controls.Add(this.checkBoxDcrt);
            this.tabPageCoins.Controls.Add(this.checkBoxDcri);
            this.tabPageCoins.Controls.Add(this.checkBoxDpsw);
            this.tabPageCoins.Controls.Add(this.labelDWal);
            this.tabPageCoins.Controls.Add(this.comboBoxDPool);
            this.tabPageCoins.Controls.Add(this.labelDpool);
            this.tabPageCoins.Controls.Add(this.checkBoxMode);
            this.tabPageCoins.Controls.Add(this.checkBoxErate);
            this.tabPageCoins.Controls.Add(this.checkBoxEstale);
            this.tabPageCoins.Controls.Add(this.checkBoxEtha);
            this.tabPageCoins.Controls.Add(this.checkBoxEthI);
            this.tabPageCoins.Controls.Add(this.checkBoxEsm);
            this.tabPageCoins.Controls.Add(this.checkBoxEthWorker);
            this.tabPageCoins.Controls.Add(this.comboBoxEthProtocol);
            this.tabPageCoins.Controls.Add(this.checkBoxSolo);
            this.tabPageCoins.Controls.Add(this.comboBoxEpool);
            this.tabPageCoins.Controls.Add(this.label1);
            this.tabPageCoins.Location = new System.Drawing.Point(4, 22);
            this.tabPageCoins.Name = "tabPageCoins";
            this.tabPageCoins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCoins.Size = new System.Drawing.Size(458, 346);
            this.tabPageCoins.TabIndex = 0;
            this.tabPageCoins.Text = "Coins";
            this.tabPageCoins.UseVisualStyleBackColor = true;
            // 
            // checkBoxEpsw
            // 
            this.checkBoxEpsw.AutoSize = true;
            this.checkBoxEpsw.Location = new System.Drawing.Point(11, 58);
            this.checkBoxEpsw.Name = "checkBoxEpsw";
            this.checkBoxEpsw.Size = new System.Drawing.Size(51, 17);
            this.checkBoxEpsw.TabIndex = 39;
            this.checkBoxEpsw.Text = "epsw";
            this.checkBoxEpsw.UseVisualStyleBackColor = true;
            this.checkBoxEpsw.CheckedChanged += new System.EventHandler(this.checkBoxEpsw_CheckedChanged);
            // 
            // checkBoxAllCoins
            // 
            this.checkBoxAllCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAllCoins.AutoSize = true;
            this.checkBoxAllCoins.Location = new System.Drawing.Point(270, 32);
            this.checkBoxAllCoins.Name = "checkBoxAllCoins";
            this.checkBoxAllCoins.Size = new System.Drawing.Size(61, 17);
            this.checkBoxAllCoins.TabIndex = 38;
            this.checkBoxAllCoins.Text = "allcoins";
            this.checkBoxAllCoins.UseVisualStyleBackColor = true;
            this.checkBoxAllCoins.CheckedChanged += new System.EventHandler(this.checkBoxAllCoins_CheckedChanged);
            // 
            // textBoxAllCoins
            // 
            this.textBoxAllCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAllCoins.Location = new System.Drawing.Point(356, 29);
            this.textBoxAllCoins.Name = "textBoxAllCoins";
            this.textBoxAllCoins.Size = new System.Drawing.Size(92, 20);
            this.textBoxAllCoins.TabIndex = 37;
            this.textBoxAllCoins.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxDcrt
            // 
            this.textBoxDcrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDcrt.Location = new System.Drawing.Point(101, 246);
            this.textBoxDcrt.Name = "textBoxDcrt";
            this.textBoxDcrt.Size = new System.Drawing.Size(92, 20);
            this.textBoxDcrt.TabIndex = 32;
            this.textBoxDcrt.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxDcri
            // 
            this.textBoxDcri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDcri.Location = new System.Drawing.Point(356, 220);
            this.textBoxDcri.Name = "textBoxDcri";
            this.textBoxDcri.Size = new System.Drawing.Size(92, 20);
            this.textBoxDcri.TabIndex = 30;
            this.textBoxDcri.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxDPsw
            // 
            this.textBoxDPsw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDPsw.Location = new System.Drawing.Point(101, 220);
            this.textBoxDPsw.Name = "textBoxDPsw";
            this.textBoxDPsw.Size = new System.Drawing.Size(163, 20);
            this.textBoxDPsw.TabIndex = 29;
            this.textBoxDPsw.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxDwal
            // 
            this.textBoxDwal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDwal.Location = new System.Drawing.Point(101, 188);
            this.textBoxDwal.Name = "textBoxDwal";
            this.textBoxDwal.Size = new System.Drawing.Size(347, 20);
            this.textBoxDwal.TabIndex = 27;
            this.textBoxDwal.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxEtht
            // 
            this.textBoxEtht.Location = new System.Drawing.Point(101, 29);
            this.textBoxEtht.Name = "textBoxEtht";
            this.textBoxEtht.Size = new System.Drawing.Size(64, 20);
            this.textBoxEtht.TabIndex = 22;
            this.textBoxEtht.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxETHA
            // 
            this.textBoxETHA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxETHA.Location = new System.Drawing.Point(101, 109);
            this.textBoxETHA.Name = "textBoxETHA";
            this.textBoxETHA.Size = new System.Drawing.Size(163, 20);
            this.textBoxETHA.TabIndex = 19;
            this.textBoxETHA.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxEthi
            // 
            this.textBoxEthi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthi.Location = new System.Drawing.Point(356, 81);
            this.textBoxEthi.Name = "textBoxEthi";
            this.textBoxEthi.Size = new System.Drawing.Size(92, 20);
            this.textBoxEthi.TabIndex = 15;
            this.textBoxEthi.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxEthWorker
            // 
            this.textBoxEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWorker.Location = new System.Drawing.Point(356, 55);
            this.textBoxEthWorker.Name = "textBoxEthWorker";
            this.textBoxEthWorker.Size = new System.Drawing.Size(92, 20);
            this.textBoxEthWorker.TabIndex = 6;
            this.textBoxEthWorker.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // textBoxEpsw
            // 
            this.textBoxEpsw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpsw.Location = new System.Drawing.Point(101, 55);
            this.textBoxEpsw.Name = "textBoxEpsw";
            this.textBoxEpsw.Size = new System.Drawing.Size(163, 20);
            this.textBoxEpsw.TabIndex = 4;
            this.textBoxEpsw.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxAllPools
            // 
            this.checkBoxAllPools.AutoSize = true;
            this.checkBoxAllPools.Location = new System.Drawing.Point(201, 31);
            this.checkBoxAllPools.Name = "checkBoxAllPools";
            this.checkBoxAllPools.Size = new System.Drawing.Size(61, 17);
            this.checkBoxAllPools.TabIndex = 36;
            this.checkBoxAllPools.Text = "allpools";
            this.checkBoxAllPools.UseVisualStyleBackColor = true;
            this.checkBoxAllPools.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // comboBoxDcoin
            // 
            this.comboBoxDcoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDcoin.FormattingEnabled = true;
            this.comboBoxDcoin.Location = new System.Drawing.Point(356, 249);
            this.comboBoxDcoin.Name = "comboBoxDcoin";
            this.comboBoxDcoin.Size = new System.Drawing.Size(92, 21);
            this.comboBoxDcoin.TabIndex = 35;
            this.comboBoxDcoin.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxDcoin
            // 
            this.checkBoxDcoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDcoin.AutoSize = true;
            this.checkBoxDcoin.Location = new System.Drawing.Point(270, 249);
            this.checkBoxDcoin.Name = "checkBoxDcoin";
            this.checkBoxDcoin.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDcoin.TabIndex = 34;
            this.checkBoxDcoin.Text = "dcoin";
            this.checkBoxDcoin.UseVisualStyleBackColor = true;
            this.checkBoxDcoin.CheckedChanged += new System.EventHandler(this.checkBoxDcoin_CheckedChanged);
            // 
            // checkBoxDcrt
            // 
            this.checkBoxDcrt.AutoSize = true;
            this.checkBoxDcrt.Location = new System.Drawing.Point(11, 250);
            this.checkBoxDcrt.Name = "checkBoxDcrt";
            this.checkBoxDcrt.Size = new System.Drawing.Size(44, 17);
            this.checkBoxDcrt.TabIndex = 33;
            this.checkBoxDcrt.Text = "dcrt";
            this.checkBoxDcrt.UseVisualStyleBackColor = true;
            this.checkBoxDcrt.CheckedChanged += new System.EventHandler(this.checkBoxDcrt_CheckedChanged);
            // 
            // checkBoxDcri
            // 
            this.checkBoxDcri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDcri.AutoSize = true;
            this.checkBoxDcri.Location = new System.Drawing.Point(269, 224);
            this.checkBoxDcri.Name = "checkBoxDcri";
            this.checkBoxDcri.Size = new System.Drawing.Size(43, 17);
            this.checkBoxDcri.TabIndex = 31;
            this.checkBoxDcri.Text = "dcri";
            this.checkBoxDcri.UseVisualStyleBackColor = true;
            this.checkBoxDcri.CheckedChanged += new System.EventHandler(this.checkBoxDcri_CheckedChanged);
            // 
            // checkBoxDpsw
            // 
            this.checkBoxDpsw.AutoSize = true;
            this.checkBoxDpsw.Location = new System.Drawing.Point(11, 223);
            this.checkBoxDpsw.Name = "checkBoxDpsw";
            this.checkBoxDpsw.Size = new System.Drawing.Size(51, 17);
            this.checkBoxDpsw.TabIndex = 28;
            this.checkBoxDpsw.Text = "dpsw";
            this.checkBoxDpsw.UseVisualStyleBackColor = true;
            this.checkBoxDpsw.CheckedChanged += new System.EventHandler(this.checkBoxDpsw_CheckedChanged);
            // 
            // labelDWal
            // 
            this.labelDWal.AutoSize = true;
            this.labelDWal.Location = new System.Drawing.Point(11, 195);
            this.labelDWal.Name = "labelDWal";
            this.labelDWal.Size = new System.Drawing.Size(29, 13);
            this.labelDWal.TabIndex = 26;
            this.labelDWal.Text = "dwal";
            // 
            // comboBoxDPool
            // 
            this.comboBoxDPool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDPool.FormattingEnabled = true;
            this.comboBoxDPool.Location = new System.Drawing.Point(101, 161);
            this.comboBoxDPool.Name = "comboBoxDPool";
            this.comboBoxDPool.Size = new System.Drawing.Size(347, 21);
            this.comboBoxDPool.TabIndex = 25;
            this.comboBoxDPool.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // labelDpool
            // 
            this.labelDpool.AutoSize = true;
            this.labelDpool.Location = new System.Drawing.Point(11, 169);
            this.labelDpool.Name = "labelDpool";
            this.labelDpool.Size = new System.Drawing.Size(33, 13);
            this.labelDpool.TabIndex = 24;
            this.labelDpool.Text = "dpool";
            // 
            // checkBoxMode
            // 
            this.checkBoxMode.AutoSize = true;
            this.checkBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMode.Location = new System.Drawing.Point(11, 138);
            this.checkBoxMode.Name = "checkBoxMode";
            this.checkBoxMode.Size = new System.Drawing.Size(97, 17);
            this.checkBoxMode.TabIndex = 23;
            this.checkBoxMode.Text = "Second coin";
            this.checkBoxMode.UseVisualStyleBackColor = true;
            this.checkBoxMode.CheckedChanged += new System.EventHandler(this.checkBoxMode_CheckedChanged);
            // 
            // checkBoxErate
            // 
            this.checkBoxErate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxErate.AutoSize = true;
            this.checkBoxErate.Location = new System.Drawing.Point(357, 111);
            this.checkBoxErate.Name = "checkBoxErate";
            this.checkBoxErate.Size = new System.Drawing.Size(50, 17);
            this.checkBoxErate.TabIndex = 21;
            this.checkBoxErate.Text = "erate";
            this.checkBoxErate.UseVisualStyleBackColor = true;
            this.checkBoxErate.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxEstale
            // 
            this.checkBoxEstale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEstale.AutoSize = true;
            this.checkBoxEstale.Location = new System.Drawing.Point(269, 111);
            this.checkBoxEstale.Name = "checkBoxEstale";
            this.checkBoxEstale.Size = new System.Drawing.Size(54, 17);
            this.checkBoxEstale.TabIndex = 20;
            this.checkBoxEstale.Text = "estale";
            this.checkBoxEstale.UseVisualStyleBackColor = true;
            this.checkBoxEstale.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxEtha
            // 
            this.checkBoxEtha.AutoSize = true;
            this.checkBoxEtha.Location = new System.Drawing.Point(11, 112);
            this.checkBoxEtha.Name = "checkBoxEtha";
            this.checkBoxEtha.Size = new System.Drawing.Size(47, 17);
            this.checkBoxEtha.TabIndex = 18;
            this.checkBoxEtha.Text = "etha";
            this.checkBoxEtha.UseVisualStyleBackColor = true;
            this.checkBoxEtha.CheckedChanged += new System.EventHandler(this.checkBoxEtha_CheckedChanged);
            // 
            // checkBoxEthI
            // 
            this.checkBoxEthI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEthI.AutoSize = true;
            this.checkBoxEthI.Location = new System.Drawing.Point(269, 85);
            this.checkBoxEthI.Name = "checkBoxEthI";
            this.checkBoxEthI.Size = new System.Drawing.Size(43, 17);
            this.checkBoxEthI.TabIndex = 16;
            this.checkBoxEthI.Text = "ethi";
            this.checkBoxEthI.UseVisualStyleBackColor = true;
            this.checkBoxEthI.CheckedChanged += new System.EventHandler(this.checkBoxEthI_CheckedChanged);
            // 
            // checkBoxEsm
            // 
            this.checkBoxEsm.AutoSize = true;
            this.checkBoxEsm.Location = new System.Drawing.Point(11, 85);
            this.checkBoxEsm.Name = "checkBoxEsm";
            this.checkBoxEsm.Size = new System.Drawing.Size(45, 17);
            this.checkBoxEsm.TabIndex = 10;
            this.checkBoxEsm.Text = "esm";
            this.checkBoxEsm.UseVisualStyleBackColor = true;
            this.checkBoxEsm.CheckedChanged += new System.EventHandler(this.checkBoxEsm_CheckedChanged);
            // 
            // checkBoxEthWorker
            // 
            this.checkBoxEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEthWorker.AutoSize = true;
            this.checkBoxEthWorker.Location = new System.Drawing.Point(268, 58);
            this.checkBoxEthWorker.Name = "checkBoxEthWorker";
            this.checkBoxEthWorker.Size = new System.Drawing.Size(61, 17);
            this.checkBoxEthWorker.TabIndex = 9;
            this.checkBoxEthWorker.Text = "Worker";
            this.checkBoxEthWorker.UseVisualStyleBackColor = true;
            this.checkBoxEthWorker.CheckedChanged += new System.EventHandler(this.checkBoxEthWorker_CheckedChanged);
            // 
            // comboBoxEthProtocol
            // 
            this.comboBoxEthProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEthProtocol.DisplayMember = "value";
            this.comboBoxEthProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEthProtocol.FormattingEnabled = true;
            this.comboBoxEthProtocol.Location = new System.Drawing.Point(101, 81);
            this.comboBoxEthProtocol.Name = "comboBoxEthProtocol";
            this.comboBoxEthProtocol.Size = new System.Drawing.Size(163, 21);
            this.comboBoxEthProtocol.TabIndex = 8;
            this.comboBoxEthProtocol.ValueMember = "key";
            this.comboBoxEthProtocol.SelectedIndexChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            this.comboBoxEthProtocol.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxSolo
            // 
            this.checkBoxSolo.AutoSize = true;
            this.checkBoxSolo.Location = new System.Drawing.Point(11, 32);
            this.checkBoxSolo.Name = "checkBoxSolo";
            this.checkBoxSolo.Size = new System.Drawing.Size(55, 17);
            this.checkBoxSolo.TabIndex = 2;
            this.checkBoxSolo.Text = "SOLO";
            this.checkBoxSolo.UseVisualStyleBackColor = true;
            this.checkBoxSolo.CheckedChanged += new System.EventHandler(this.checkBoxSolo_CheckedChanged);
            // 
            // comboBoxEpool
            // 
            this.comboBoxEpool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEpool.FormattingEnabled = true;
            this.comboBoxEpool.Location = new System.Drawing.Point(101, 4);
            this.comboBoxEpool.Name = "comboBoxEpool";
            this.comboBoxEpool.Size = new System.Drawing.Size(347, 21);
            this.comboBoxEpool.TabIndex = 1;
            this.comboBoxEpool.TextChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "epool";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCoins);
            this.tabControl1.Controls.Add(this.tabPageCustomCommand);
            this.tabControl1.Controls.Add(this.tabPageGPUSettings);
            this.tabControl1.Controls.Add(this.tabPageOther);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 372);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageGPUSettings
            // 
            this.tabPageGPUSettings.Controls.Add(this.checkBoxGPU_SINGLE_ALLOC_PERCENT100);
            this.tabPageGPUSettings.Controls.Add(this.checkBoxGPU_MAX_ALLOC_PERCENT100);
            this.tabPageGPUSettings.Controls.Add(this.checkBoxGPU_USE_SYNC_OBJECTS1);
            this.tabPageGPUSettings.Controls.Add(this.checkBoxGPU_MAX_HEAP_SIZE100);
            this.tabPageGPUSettings.Controls.Add(this.checkBoxGPU_FORCE_64BIT_PTR0);
            this.tabPageGPUSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageGPUSettings.Name = "tabPageGPUSettings";
            this.tabPageGPUSettings.Size = new System.Drawing.Size(458, 346);
            this.tabPageGPUSettings.TabIndex = 3;
            this.tabPageGPUSettings.Text = "GPUSettings";
            this.tabPageGPUSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxGPU_FORCE_64BIT_PTR0
            // 
            this.checkBoxGPU_FORCE_64BIT_PTR0.AutoSize = true;
            this.checkBoxGPU_FORCE_64BIT_PTR0.Location = new System.Drawing.Point(12, 14);
            this.checkBoxGPU_FORCE_64BIT_PTR0.Name = "checkBoxGPU_FORCE_64BIT_PTR0";
            this.checkBoxGPU_FORCE_64BIT_PTR0.Size = new System.Drawing.Size(163, 17);
            this.checkBoxGPU_FORCE_64BIT_PTR0.TabIndex = 0;
            this.checkBoxGPU_FORCE_64BIT_PTR0.Text = "GPU_FORCE_64BIT_PTR 0";
            this.checkBoxGPU_FORCE_64BIT_PTR0.UseVisualStyleBackColor = true;
            this.checkBoxGPU_FORCE_64BIT_PTR0.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // tabPageOther
            // 
            this.tabPageOther.Controls.Add(this.checkBox3);
            this.tabPageOther.Controls.Add(this.checkBoxShowWindow);
            this.tabPageOther.Location = new System.Drawing.Point(4, 22);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Size = new System.Drawing.Size(458, 346);
            this.tabPageOther.TabIndex = 4;
            this.tabPageOther.Text = "Other settings";
            this.tabPageOther.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 36);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(96, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Restart if close";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowWindow
            // 
            this.checkBoxShowWindow.AutoSize = true;
            this.checkBoxShowWindow.Location = new System.Drawing.Point(7, 13);
            this.checkBoxShowWindow.Name = "checkBoxShowWindow";
            this.checkBoxShowWindow.Size = new System.Drawing.Size(120, 17);
            this.checkBoxShowWindow.TabIndex = 0;
            this.checkBoxShowWindow.Text = "Show miner window";
            this.checkBoxShowWindow.UseVisualStyleBackColor = true;
            this.checkBoxShowWindow.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxGPU_MAX_HEAP_SIZE100
            // 
            this.checkBoxGPU_MAX_HEAP_SIZE100.AutoSize = true;
            this.checkBoxGPU_MAX_HEAP_SIZE100.Location = new System.Drawing.Point(12, 37);
            this.checkBoxGPU_MAX_HEAP_SIZE100.Name = "checkBoxGPU_MAX_HEAP_SIZE100";
            this.checkBoxGPU_MAX_HEAP_SIZE100.Size = new System.Drawing.Size(164, 17);
            this.checkBoxGPU_MAX_HEAP_SIZE100.TabIndex = 1;
            this.checkBoxGPU_MAX_HEAP_SIZE100.Text = "GPU_MAX_HEAP_SIZE 100";
            this.checkBoxGPU_MAX_HEAP_SIZE100.UseVisualStyleBackColor = true;
            this.checkBoxGPU_MAX_HEAP_SIZE100.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxGPU_USE_SYNC_OBJECTS1
            // 
            this.checkBoxGPU_USE_SYNC_OBJECTS1.AutoSize = true;
            this.checkBoxGPU_USE_SYNC_OBJECTS1.Location = new System.Drawing.Point(12, 60);
            this.checkBoxGPU_USE_SYNC_OBJECTS1.Name = "checkBoxGPU_USE_SYNC_OBJECTS1";
            this.checkBoxGPU_USE_SYNC_OBJECTS1.Size = new System.Drawing.Size(175, 17);
            this.checkBoxGPU_USE_SYNC_OBJECTS1.TabIndex = 2;
            this.checkBoxGPU_USE_SYNC_OBJECTS1.Text = "GPU_USE_SYNC_OBJECTS 1";
            this.checkBoxGPU_USE_SYNC_OBJECTS1.UseVisualStyleBackColor = true;
            this.checkBoxGPU_USE_SYNC_OBJECTS1.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxGPU_MAX_ALLOC_PERCENT100
            // 
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.AutoSize = true;
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.Location = new System.Drawing.Point(12, 83);
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.Name = "checkBoxGPU_MAX_ALLOC_PERCENT100";
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.Size = new System.Drawing.Size(196, 17);
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.TabIndex = 3;
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.Text = "GPU_MAX_ALLOC_PERCENT 100";
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.UseVisualStyleBackColor = true;
            this.checkBoxGPU_MAX_ALLOC_PERCENT100.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // checkBoxGPU_SINGLE_ALLOC_PERCENT100
            // 
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.AutoSize = true;
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.Location = new System.Drawing.Point(12, 106);
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.Name = "checkBoxGPU_SINGLE_ALLOC_PERCENT100";
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.Size = new System.Drawing.Size(212, 17);
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.TabIndex = 4;
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.Text = "GPU_SINGLE_ALLOC_PERCENT 100";
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.UseVisualStyleBackColor = true;
            this.checkBoxGPU_SINGLE_ALLOC_PERCENT100.CheckedChanged += new System.EventHandler(this.textBoxCustomCommand_TextChanged);
            // 
            // dlgClaymorConfig
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(465, 416);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonDefaults);
            this.Name = "dlgClaymorConfig";
            this.Text = "dlgClaymorConfig";
            this.tabPageCustomCommand.ResumeLayout(false);
            this.tabPageCustomCommand.PerformLayout();
            this.tabPageCoins.ResumeLayout(false);
            this.tabPageCoins.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGPUSettings.ResumeLayout(false);
            this.tabPageGPUSettings.PerformLayout();
            this.tabPageOther.ResumeLayout(false);
            this.tabPageOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabPage tabPageCustomCommand;
        private System.Windows.Forms.TextBox textBoxCustomCommand;
        private System.Windows.Forms.CheckBox checkBoxCustomCommand;
        private System.Windows.Forms.Button buttonCustomCommand;
        private System.Windows.Forms.TabPage tabPageCoins;
        private System.Windows.Forms.CheckBox checkBoxAllCoins;
        private System.Windows.Forms.TextBox textBoxAllCoins;
        private System.Windows.Forms.TextBox textBoxDcrt;
        private System.Windows.Forms.TextBox textBoxDcri;
        private System.Windows.Forms.TextBox textBoxDPsw;
        private System.Windows.Forms.TextBox textBoxDwal;
        private System.Windows.Forms.TextBox textBoxEtht;
        private System.Windows.Forms.TextBox textBoxETHA;
        private System.Windows.Forms.TextBox textBoxEthi;
        private System.Windows.Forms.TextBox textBoxEthWorker;
        private System.Windows.Forms.TextBox textBoxEpsw;
        private System.Windows.Forms.CheckBox checkBoxAllPools;
        private System.Windows.Forms.ComboBox comboBoxDcoin;
        private System.Windows.Forms.CheckBox checkBoxDcoin;
        private System.Windows.Forms.CheckBox checkBoxDcrt;
        private System.Windows.Forms.CheckBox checkBoxDcri;
        private System.Windows.Forms.CheckBox checkBoxDpsw;
        private System.Windows.Forms.Label labelDWal;
        private System.Windows.Forms.ComboBox comboBoxDPool;
        private System.Windows.Forms.Label labelDpool;
        private System.Windows.Forms.CheckBox checkBoxMode;
        private System.Windows.Forms.CheckBox checkBoxErate;
        private System.Windows.Forms.CheckBox checkBoxEstale;
        private System.Windows.Forms.CheckBox checkBoxEtha;
        private System.Windows.Forms.CheckBox checkBoxEthI;
        private System.Windows.Forms.CheckBox checkBoxEsm;
        private System.Windows.Forms.CheckBox checkBoxEthWorker;
        private System.Windows.Forms.ComboBox comboBoxEthProtocol;
        private System.Windows.Forms.CheckBox checkBoxSolo;
        private System.Windows.Forms.ComboBox comboBoxEpool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox checkBoxEpsw;
        private System.Windows.Forms.TabPage tabPageGPUSettings;
        private System.Windows.Forms.CheckBox checkBoxGPU_FORCE_64BIT_PTR0;
        private System.Windows.Forms.TabPage tabPageOther;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBoxShowWindow;
        private System.Windows.Forms.CheckBox checkBoxGPU_SINGLE_ALLOC_PERCENT100;
        private System.Windows.Forms.CheckBox checkBoxGPU_MAX_ALLOC_PERCENT100;
        private System.Windows.Forms.CheckBox checkBoxGPU_USE_SYNC_OBJECTS1;
        private System.Windows.Forms.CheckBox checkBoxGPU_MAX_HEAP_SIZE100;
    }
}