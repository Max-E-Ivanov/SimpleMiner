namespace SimpleMiner.Claymor
{
    partial class ucClaymorMiner
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
            this.textBoxEthWallet = new System.Windows.Forms.TextBox();
            this.labelEthWallet = new System.Windows.Forms.Label();
            this.linkLabelCreateEthWallet = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEthPools = new System.Windows.Forms.ComboBox();
            this.labelEthWorker = new System.Windows.Forms.Label();
            this.textBoxEthWorker = new System.Windows.Forms.TextBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxEthWallet
            // 
            this.textBoxEthWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWallet.Location = new System.Drawing.Point(72, 6);
            this.textBoxEthWallet.Name = "textBoxEthWallet";
            this.textBoxEthWallet.Size = new System.Drawing.Size(432, 20);
            this.textBoxEthWallet.TabIndex = 0;
            this.textBoxEthWallet.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // labelEthWallet
            // 
            this.labelEthWallet.AutoSize = true;
            this.labelEthWallet.Location = new System.Drawing.Point(3, 9);
            this.labelEthWallet.Name = "labelEthWallet";
            this.labelEthWallet.Size = new System.Drawing.Size(52, 13);
            this.labelEthWallet.TabIndex = 1;
            this.labelEthWallet.Text = "ethWallet";
            // 
            // linkLabelCreateEthWallet
            // 
            this.linkLabelCreateEthWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCreateEthWallet.AutoSize = true;
            this.linkLabelCreateEthWallet.Location = new System.Drawing.Point(512, 9);
            this.linkLabelCreateEthWallet.Name = "linkLabelCreateEthWallet";
            this.linkLabelCreateEthWallet.Size = new System.Drawing.Size(91, 13);
            this.linkLabelCreateEthWallet.TabIndex = 2;
            this.linkLabelCreateEthWallet.TabStop = true;
            this.linkLabelCreateEthWallet.Text = "Create new wallet";
            this.linkLabelCreateEthWallet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateEthWallet_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ethPool";
            // 
            // comboBoxEthPools
            // 
            this.comboBoxEthPools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEthPools.FormattingEnabled = true;
            this.comboBoxEthPools.Location = new System.Drawing.Point(72, 32);
            this.comboBoxEthPools.Name = "comboBoxEthPools";
            this.comboBoxEthPools.Size = new System.Drawing.Size(354, 21);
            this.comboBoxEthPools.TabIndex = 4;
            this.comboBoxEthPools.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // labelEthWorker
            // 
            this.labelEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEthWorker.AutoSize = true;
            this.labelEthWorker.Location = new System.Drawing.Point(439, 36);
            this.labelEthWorker.Name = "labelEthWorker";
            this.labelEthWorker.Size = new System.Drawing.Size(57, 13);
            this.labelEthWorker.TabIndex = 5;
            this.labelEthWorker.Text = "ethWorker";
            // 
            // textBoxEthWorker
            // 
            this.textBoxEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWorker.Location = new System.Drawing.Point(503, 33);
            this.textBoxEthWorker.Name = "textBoxEthWorker";
            this.textBoxEthWorker.Size = new System.Drawing.Size(100, 20);
            this.textBoxEthWorker.TabIndex = 6;
            this.textBoxEthWorker.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfig.Location = new System.Drawing.Point(617, 3);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(50, 50);
            this.buttonConfig.TabIndex = 7;
            this.buttonConfig.UseVisualStyleBackColor = true;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartStop.Location = new System.Drawing.Point(673, 3);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(50, 50);
            this.buttonStartStop.TabIndex = 8;
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(0, 59);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(723, 437);
            this.textBoxOutput.TabIndex = 9;
            // 
            // ucClaymorMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.textBoxEthWorker);
            this.Controls.Add(this.labelEthWorker);
            this.Controls.Add(this.comboBoxEthPools);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelCreateEthWallet);
            this.Controls.Add(this.labelEthWallet);
            this.Controls.Add(this.textBoxEthWallet);
            this.Name = "ucClaymorMiner";
            this.Size = new System.Drawing.Size(726, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEthWallet;
        private System.Windows.Forms.Label labelEthWallet;
        private System.Windows.Forms.LinkLabel linkLabelCreateEthWallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEthPools;
        private System.Windows.Forms.Label labelEthWorker;
        private System.Windows.Forms.TextBox textBoxEthWorker;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}
