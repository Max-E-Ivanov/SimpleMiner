namespace SimpleMiner
{
    partial class ucClaymorMiner1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucClaymorMiner));
            this.labelEthWallet = new System.Windows.Forms.Label();
            this.textBoxEthWallet = new System.Windows.Forms.TextBox();
            this.linkLabelCreateEthWallet = new System.Windows.Forms.LinkLabel();
            this.labelPool = new System.Windows.Forms.Label();
            this.comboBoxEthPools = new System.Windows.Forms.ComboBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelWorker = new System.Windows.Forms.Label();
            this.textBoxEthWorker = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEthWallet
            // 
            this.labelEthWallet.AutoSize = true;
            this.labelEthWallet.Location = new System.Drawing.Point(0, 10);
            this.labelEthWallet.Name = "labelEthWallet";
            this.labelEthWallet.Size = new System.Drawing.Size(37, 13);
            this.labelEthWallet.TabIndex = 10;
            this.labelEthWallet.Text = "Wallet";
            // 
            // textBoxEthWallet
            // 
            this.textBoxEthWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWallet.Location = new System.Drawing.Point(43, 7);
            this.textBoxEthWallet.Name = "textBoxEthWallet";
            this.textBoxEthWallet.Size = new System.Drawing.Size(471, 20);
            this.textBoxEthWallet.TabIndex = 11;
            this.textBoxEthWallet.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // linkLabelCreateEthWallet
            // 
            this.linkLabelCreateEthWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCreateEthWallet.AutoSize = true;
            this.linkLabelCreateEthWallet.Location = new System.Drawing.Point(520, 10);
            this.linkLabelCreateEthWallet.Name = "linkLabelCreateEthWallet";
            this.linkLabelCreateEthWallet.Size = new System.Drawing.Size(163, 13);
            this.linkLabelCreateEthWallet.TabIndex = 12;
            this.linkLabelCreateEthWallet.TabStop = true;
            this.linkLabelCreateEthWallet.Text = "Have no wallet? Create just now!";
            // 
            // labelPool
            // 
            this.labelPool.AutoSize = true;
            this.labelPool.Location = new System.Drawing.Point(3, 36);
            this.labelPool.Name = "labelPool";
            this.labelPool.Size = new System.Drawing.Size(28, 13);
            this.labelPool.TabIndex = 13;
            this.labelPool.Text = "Pool";
            // 
            // comboBoxEthPools
            // 
            this.comboBoxEthPools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEthPools.FormattingEnabled = true;
            this.comboBoxEthPools.Location = new System.Drawing.Point(43, 33);
            this.comboBoxEthPools.Name = "comboBoxEthPools";
            this.comboBoxEthPools.Size = new System.Drawing.Size(471, 21);
            this.comboBoxEthPools.TabIndex = 14;
            this.comboBoxEthPools.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartStop.AutoEllipsis = true;
            this.buttonStartStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartStop.Image")));
            this.buttonStartStop.Location = new System.Drawing.Point(777, 0);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(55, 55);
            this.buttonStartStop.TabIndex = 15;
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelWorker
            // 
            this.labelWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(520, 35);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(42, 13);
            this.labelWorker.TabIndex = 16;
            this.labelWorker.Text = "Worker";
            // 
            // textBoxEthWorker
            // 
            this.textBoxEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWorker.Location = new System.Drawing.Point(568, 33);
            this.textBoxEthWorker.Name = "textBoxEthWorker";
            this.textBoxEthWorker.Size = new System.Drawing.Size(142, 20);
            this.textBoxEthWorker.TabIndex = 17;
            this.textBoxEthWorker.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.AutoEllipsis = true;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(716, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(55, 55);
            this.buttonSettings.TabIndex = 18;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // ucClaymorMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.textBoxEthWorker);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.comboBoxEthPools);
            this.Controls.Add(this.labelPool);
            this.Controls.Add(this.linkLabelCreateEthWallet);
            this.Controls.Add(this.textBoxEthWallet);
            this.Controls.Add(this.labelEthWallet);
            this.Name = "ucClaymorMiner";
            this.Size = new System.Drawing.Size(832, 430);
            this.Controls.SetChildIndex(this.labelEthWallet, 0);
            this.Controls.SetChildIndex(this.textBoxEthWallet, 0);
            this.Controls.SetChildIndex(this.linkLabelCreateEthWallet, 0);
            this.Controls.SetChildIndex(this.labelPool, 0);
            this.Controls.SetChildIndex(this.comboBoxEthPools, 0);
            this.Controls.SetChildIndex(this.buttonStartStop, 0);
            this.Controls.SetChildIndex(this.labelWorker, 0);
            this.Controls.SetChildIndex(this.textBoxEthWorker, 0);
            this.Controls.SetChildIndex(this.buttonSettings, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEthWallet;
        private System.Windows.Forms.TextBox textBoxEthWallet;
        private System.Windows.Forms.LinkLabel linkLabelCreateEthWallet;
        private System.Windows.Forms.Label labelPool;
        private System.Windows.Forms.ComboBox comboBoxEthPools;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.TextBox textBoxEthWorker;
        private System.Windows.Forms.Button buttonSettings;
    }
}
