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
            this.labelEthPool = new System.Windows.Forms.Label();
            this.comboBoxEthPools = new System.Windows.Forms.ComboBox();
            this.labelEthWorker = new System.Windows.Forms.Label();
            this.textBoxEthWorker = new System.Windows.Forms.TextBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxCustomCommand = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEthWallet
            // 
            this.textBoxEthWallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWallet.Location = new System.Drawing.Point(74, 3);
            this.textBoxEthWallet.Name = "textBoxEthWallet";
            this.textBoxEthWallet.Size = new System.Drawing.Size(409, 20);
            this.textBoxEthWallet.TabIndex = 0;
            this.textBoxEthWallet.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // labelEthWallet
            // 
            this.labelEthWallet.AutoSize = true;
            this.labelEthWallet.Location = new System.Drawing.Point(5, 6);
            this.labelEthWallet.Name = "labelEthWallet";
            this.labelEthWallet.Size = new System.Drawing.Size(52, 13);
            this.labelEthWallet.TabIndex = 1;
            this.labelEthWallet.Text = "ethWallet";
            // 
            // linkLabelCreateEthWallet
            // 
            this.linkLabelCreateEthWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCreateEthWallet.AutoSize = true;
            this.linkLabelCreateEthWallet.Location = new System.Drawing.Point(495, 6);
            this.linkLabelCreateEthWallet.Name = "linkLabelCreateEthWallet";
            this.linkLabelCreateEthWallet.Size = new System.Drawing.Size(91, 13);
            this.linkLabelCreateEthWallet.TabIndex = 2;
            this.linkLabelCreateEthWallet.TabStop = true;
            this.linkLabelCreateEthWallet.Text = "Create new wallet";
            this.linkLabelCreateEthWallet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateEthWallet_LinkClicked);
            // 
            // labelEthPool
            // 
            this.labelEthPool.AutoSize = true;
            this.labelEthPool.Location = new System.Drawing.Point(5, 33);
            this.labelEthPool.Name = "labelEthPool";
            this.labelEthPool.Size = new System.Drawing.Size(43, 13);
            this.labelEthPool.TabIndex = 3;
            this.labelEthPool.Text = "ethPool";
            // 
            // comboBoxEthPools
            // 
            this.comboBoxEthPools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEthPools.FormattingEnabled = true;
            this.comboBoxEthPools.Location = new System.Drawing.Point(74, 29);
            this.comboBoxEthPools.Name = "comboBoxEthPools";
            this.comboBoxEthPools.Size = new System.Drawing.Size(334, 21);
            this.comboBoxEthPools.TabIndex = 4;
            this.comboBoxEthPools.TextChanged += new System.EventHandler(this.textBoxEthWallet_TextChanged);
            // 
            // labelEthWorker
            // 
            this.labelEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEthWorker.AutoSize = true;
            this.labelEthWorker.Location = new System.Drawing.Point(426, 33);
            this.labelEthWorker.Name = "labelEthWorker";
            this.labelEthWorker.Size = new System.Drawing.Size(57, 13);
            this.labelEthWorker.TabIndex = 5;
            this.labelEthWorker.Text = "ethWorker";
            // 
            // textBoxEthWorker
            // 
            this.textBoxEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWorker.Location = new System.Drawing.Point(498, 29);
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
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
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
            this.textBoxOutput.BackColor = System.Drawing.Color.Black;
            this.textBoxOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput.ForeColor = System.Drawing.Color.Lime;
            this.textBoxOutput.Location = new System.Drawing.Point(0, 69);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(723, 427);
            this.textBoxOutput.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 63);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxEthWallet);
            this.tabPage1.Controls.Add(this.labelEthWallet);
            this.tabPage1.Controls.Add(this.linkLabelCreateEthWallet);
            this.tabPage1.Controls.Add(this.labelEthPool);
            this.tabPage1.Controls.Add(this.textBoxEthWorker);
            this.tabPage1.Controls.Add(this.comboBoxEthPools);
            this.tabPage1.Controls.Add(this.labelEthWorker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 37);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxCustomCommand);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 27);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomCommand
            // 
            this.textBoxCustomCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCustomCommand.Location = new System.Drawing.Point(3, 3);
            this.textBoxCustomCommand.Multiline = true;
            this.textBoxCustomCommand.Name = "textBoxCustomCommand";
            this.textBoxCustomCommand.ReadOnly = true;
            this.textBoxCustomCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCustomCommand.Size = new System.Drawing.Size(598, 21);
            this.textBoxCustomCommand.TabIndex = 0;
            // 
            // ucClaymorMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.buttonConfig);
            this.Name = "ucClaymorMiner";
            this.Size = new System.Drawing.Size(726, 499);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEthWallet;
        private System.Windows.Forms.Label labelEthWallet;
        private System.Windows.Forms.LinkLabel linkLabelCreateEthWallet;
        private System.Windows.Forms.Label labelEthPool;
        private System.Windows.Forms.ComboBox comboBoxEthPools;
        private System.Windows.Forms.Label labelEthWorker;
        private System.Windows.Forms.TextBox textBoxEthWorker;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxCustomCommand;
    }
}
