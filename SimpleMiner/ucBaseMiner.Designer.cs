namespace SimpleMiner
{
    partial class ucBaseMiner
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
            this.components = new System.ComponentModel.Container();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.toolTipManager = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelParams = new System.Windows.Forms.Label();
            this.textBoxParams = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripRestartLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripRestartCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.toolStripClientTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMeTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripClientTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMeTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(43, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(603, 20);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenFile.Location = new System.Drawing.Point(652, 1);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(33, 23);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "...";
            this.toolTipManager.SetToolTip(this.buttonOpenFile, "OpenFile");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(691, 1);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(74, 23);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run!";
            this.toolTipManager.SetToolTip(this.buttonRun, "OpenFile");
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(771, 1);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(74, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.toolTipManager.SetToolTip(this.buttonStop, "OpenFile");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(0, 6);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Path";
            // 
            // labelParams
            // 
            this.labelParams.AutoSize = true;
            this.labelParams.Location = new System.Drawing.Point(0, 32);
            this.labelParams.Name = "labelParams";
            this.labelParams.Size = new System.Drawing.Size(42, 13);
            this.labelParams.TabIndex = 6;
            this.labelParams.Text = "Params";
            // 
            // textBoxParams
            // 
            this.textBoxParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxParams.Location = new System.Drawing.Point(43, 29);
            this.textBoxParams.Name = "textBoxParams";
            this.textBoxParams.Size = new System.Drawing.Size(722, 20);
            this.textBoxParams.TabIndex = 5;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(0, 55);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(845, 343);
            this.textBoxOutput.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripRestartLabel,
            this.toolStripRestartCnt,
            this.toolStripClientTimeLabel,
            this.toolStripClientTime,
            this.toolStripMeTimeLabel,
            this.toolStripMeTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(852, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatus.Text = "IDLE";
            // 
            // toolStripRestartLabel
            // 
            this.toolStripRestartLabel.Name = "toolStripRestartLabel";
            this.toolStripRestartLabel.Size = new System.Drawing.Size(48, 17);
            this.toolStripRestartLabel.Text = "Restarts";
            // 
            // toolStripRestartCnt
            // 
            this.toolStripRestartCnt.Name = "toolStripRestartCnt";
            this.toolStripRestartCnt.Size = new System.Drawing.Size(13, 17);
            this.toolStripRestartCnt.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxRestart
            // 
            this.checkBoxRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRestart.AutoSize = true;
            this.checkBoxRestart.Location = new System.Drawing.Point(771, 31);
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.Size = new System.Drawing.Size(60, 17);
            this.checkBoxRestart.TabIndex = 9;
            this.checkBoxRestart.Text = "Restart";
            this.checkBoxRestart.UseVisualStyleBackColor = true;
            // 
            // toolStripClientTimeLabel
            // 
            this.toolStripClientTimeLabel.Name = "toolStripClientTimeLabel";
            this.toolStripClientTimeLabel.Size = new System.Drawing.Size(55, 17);
            this.toolStripClientTimeLabel.Text = "ForClient";
            // 
            // toolStripMeTimeLabel
            // 
            this.toolStripMeTimeLabel.Name = "toolStripMeTimeLabel";
            this.toolStripMeTimeLabel.Size = new System.Drawing.Size(41, 17);
            this.toolStripMeTimeLabel.Text = "ForMe";
            // 
            // toolStripClientTime
            // 
            this.toolStripClientTime.Name = "toolStripClientTime";
            this.toolStripClientTime.Size = new System.Drawing.Size(34, 17);
            this.toolStripClientTime.Text = "00:00";
            // 
            // toolStripMeTime
            // 
            this.toolStripMeTime.Name = "toolStripMeTime";
            this.toolStripMeTime.Size = new System.Drawing.Size(34, 17);
            this.toolStripMeTime.Text = "00:00";
            // 
            // ucBaseMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxRestart);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelParams);
            this.Controls.Add(this.textBoxParams);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxPath);
            this.Name = "ucBaseMiner";
            this.Size = new System.Drawing.Size(852, 426);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ToolTip toolTipManager;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelParams;
        private System.Windows.Forms.TextBox textBoxParams;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRestartLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRestartCnt;
        private System.Windows.Forms.CheckBox checkBoxRestart;
        private System.Windows.Forms.ToolStripStatusLabel toolStripClientTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripClientTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMeTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMeTime;
    }
}
