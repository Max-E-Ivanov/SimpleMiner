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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEthereum = new System.Windows.Forms.TabPage();
            this.checkBoxAllPools = new System.Windows.Forms.CheckBox();
            this.checkBoxEthI = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBoxAMDAsm = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxAMDAlg = new System.Windows.Forms.CheckBox();
            this.checkBoxEthProtocol = new System.Windows.Forms.CheckBox();
            this.checkBoxEthWorker = new System.Windows.Forms.CheckBox();
            this.comboBoxEthProtocol = new System.Windows.Forms.ComboBox();
            this.textBoxEthWorker = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEthPsw = new System.Windows.Forms.Label();
            this.checkBoxSolo = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSecondCoin = new System.Windows.Forms.TabPage();
            this.tabPageCustomCommand = new System.Windows.Forms.TabPage();
            this.textBoxCustomCommand = new System.Windows.Forms.TextBox();
            this.checkBoxCustomCommand = new System.Windows.Forms.CheckBox();
            this.buttonCustomCommand = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEthereum.SuspendLayout();
            this.tabPageCustomCommand.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEthereum);
            this.tabControl1.Controls.Add(this.tabPageSecondCoin);
            this.tabControl1.Controls.Add(this.tabPageCustomCommand);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 372);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageEthereum
            // 
            this.tabPageEthereum.Controls.Add(this.checkBoxAllPools);
            this.tabPageEthereum.Controls.Add(this.checkBoxEthI);
            this.tabPageEthereum.Controls.Add(this.textBox4);
            this.tabPageEthereum.Controls.Add(this.textBox3);
            this.tabPageEthereum.Controls.Add(this.checkBoxAMDAsm);
            this.tabPageEthereum.Controls.Add(this.textBox2);
            this.tabPageEthereum.Controls.Add(this.checkBoxAMDAlg);
            this.tabPageEthereum.Controls.Add(this.checkBoxEthProtocol);
            this.tabPageEthereum.Controls.Add(this.checkBoxEthWorker);
            this.tabPageEthereum.Controls.Add(this.comboBoxEthProtocol);
            this.tabPageEthereum.Controls.Add(this.textBoxEthWorker);
            this.tabPageEthereum.Controls.Add(this.textBox1);
            this.tabPageEthereum.Controls.Add(this.labelEthPsw);
            this.tabPageEthereum.Controls.Add(this.checkBoxSolo);
            this.tabPageEthereum.Controls.Add(this.comboBox1);
            this.tabPageEthereum.Controls.Add(this.label1);
            this.tabPageEthereum.Location = new System.Drawing.Point(4, 22);
            this.tabPageEthereum.Name = "tabPageEthereum";
            this.tabPageEthereum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEthereum.Size = new System.Drawing.Size(458, 346);
            this.tabPageEthereum.TabIndex = 0;
            this.tabPageEthereum.Text = "Ethereum";
            this.tabPageEthereum.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllPools
            // 
            this.checkBoxAllPools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAllPools.AutoSize = true;
            this.checkBoxAllPools.Location = new System.Drawing.Point(356, 8);
            this.checkBoxAllPools.Name = "checkBoxAllPools";
            this.checkBoxAllPools.Size = new System.Drawing.Size(63, 17);
            this.checkBoxAllPools.TabIndex = 17;
            this.checkBoxAllPools.Text = "AllPools";
            this.checkBoxAllPools.UseVisualStyleBackColor = true;
            // 
            // checkBoxEthI
            // 
            this.checkBoxEthI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEthI.AutoSize = true;
            this.checkBoxEthI.Location = new System.Drawing.Point(268, 61);
            this.checkBoxEthI.Name = "checkBoxEthI";
            this.checkBoxEthI.Size = new System.Drawing.Size(63, 17);
            this.checkBoxEthI.TabIndex = 16;
            this.checkBoxEthI.Text = "Intensiv";
            this.checkBoxEthI.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(356, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(268, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 14;
            // 
            // checkBoxAMDAsm
            // 
            this.checkBoxAMDAsm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAMDAsm.AutoSize = true;
            this.checkBoxAMDAsm.Location = new System.Drawing.Point(161, 86);
            this.checkBoxAMDAsm.Name = "checkBoxAMDAsm";
            this.checkBoxAMDAsm.Size = new System.Drawing.Size(70, 17);
            this.checkBoxAMDAsm.TabIndex = 13;
            this.checkBoxAMDAsm.Text = "AMDAsm";
            this.checkBoxAMDAsm.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(101, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 12;
            // 
            // checkBoxAMDAlg
            // 
            this.checkBoxAMDAlg.AutoSize = true;
            this.checkBoxAMDAlg.Location = new System.Drawing.Point(14, 87);
            this.checkBoxAMDAlg.Name = "checkBoxAMDAlg";
            this.checkBoxAMDAlg.Size = new System.Drawing.Size(65, 17);
            this.checkBoxAMDAlg.TabIndex = 11;
            this.checkBoxAMDAlg.Text = "AMDAlg";
            this.checkBoxAMDAlg.UseVisualStyleBackColor = true;
            // 
            // checkBoxEthProtocol
            // 
            this.checkBoxEthProtocol.AutoSize = true;
            this.checkBoxEthProtocol.Location = new System.Drawing.Point(14, 61);
            this.checkBoxEthProtocol.Name = "checkBoxEthProtocol";
            this.checkBoxEthProtocol.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEthProtocol.TabIndex = 10;
            this.checkBoxEthProtocol.Text = "Protocol";
            this.checkBoxEthProtocol.UseVisualStyleBackColor = true;
            // 
            // checkBoxEthWorker
            // 
            this.checkBoxEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEthWorker.AutoSize = true;
            this.checkBoxEthWorker.Location = new System.Drawing.Point(270, 34);
            this.checkBoxEthWorker.Name = "checkBoxEthWorker";
            this.checkBoxEthWorker.Size = new System.Drawing.Size(61, 17);
            this.checkBoxEthWorker.TabIndex = 9;
            this.checkBoxEthWorker.Text = "Worker";
            this.checkBoxEthWorker.UseVisualStyleBackColor = true;
            // 
            // comboBoxEthProtocol
            // 
            this.comboBoxEthProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEthProtocol.FormattingEnabled = true;
            this.comboBoxEthProtocol.Location = new System.Drawing.Point(101, 57);
            this.comboBoxEthProtocol.Name = "comboBoxEthProtocol";
            this.comboBoxEthProtocol.Size = new System.Drawing.Size(163, 21);
            this.comboBoxEthProtocol.TabIndex = 8;
            // 
            // textBoxEthWorker
            // 
            this.textBoxEthWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEthWorker.Location = new System.Drawing.Point(356, 31);
            this.textBoxEthWorker.Name = "textBoxEthWorker";
            this.textBoxEthWorker.Size = new System.Drawing.Size(92, 20);
            this.textBoxEthWorker.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(101, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 4;
            // 
            // labelEthPsw
            // 
            this.labelEthPsw.AutoSize = true;
            this.labelEthPsw.Location = new System.Drawing.Point(11, 38);
            this.labelEthPsw.Name = "labelEthPsw";
            this.labelEthPsw.Size = new System.Drawing.Size(65, 13);
            this.labelEthPsw.TabIndex = 3;
            this.labelEthPsw.Text = "labelEthPsw";
            // 
            // checkBoxSolo
            // 
            this.checkBoxSolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSolo.AutoSize = true;
            this.checkBoxSolo.Location = new System.Drawing.Point(270, 8);
            this.checkBoxSolo.Name = "checkBoxSolo";
            this.checkBoxSolo.Size = new System.Drawing.Size(55, 17);
            this.checkBoxSolo.TabIndex = 2;
            this.checkBoxSolo.Text = "SOLO";
            this.checkBoxSolo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "labelEthPool";
            // 
            // tabPageSecondCoin
            // 
            this.tabPageSecondCoin.Location = new System.Drawing.Point(4, 22);
            this.tabPageSecondCoin.Name = "tabPageSecondCoin";
            this.tabPageSecondCoin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSecondCoin.Size = new System.Drawing.Size(458, 346);
            this.tabPageSecondCoin.TabIndex = 1;
            this.tabPageSecondCoin.Text = "Second coin";
            this.tabPageSecondCoin.UseVisualStyleBackColor = true;
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
            this.tabPageCustomCommand.Text = "Other";
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
            this.tabControl1.ResumeLayout(false);
            this.tabPageEthereum.ResumeLayout(false);
            this.tabPageEthereum.PerformLayout();
            this.tabPageCustomCommand.ResumeLayout(false);
            this.tabPageCustomCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEthereum;
        private System.Windows.Forms.CheckBox checkBoxAllPools;
        private System.Windows.Forms.CheckBox checkBoxEthI;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBoxAMDAsm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxAMDAlg;
        private System.Windows.Forms.CheckBox checkBoxEthProtocol;
        private System.Windows.Forms.CheckBox checkBoxEthWorker;
        private System.Windows.Forms.ComboBox comboBoxEthProtocol;
        private System.Windows.Forms.TextBox textBoxEthWorker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEthPsw;
        private System.Windows.Forms.CheckBox checkBoxSolo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSecondCoin;
        private System.Windows.Forms.TabPage tabPageCustomCommand;
        private System.Windows.Forms.TextBox textBoxCustomCommand;
        private System.Windows.Forms.CheckBox checkBoxCustomCommand;
        private System.Windows.Forms.Button buttonCustomCommand;
    }
}