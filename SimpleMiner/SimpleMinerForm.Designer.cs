namespace SimpleMiner
{
    partial class SimpleMinerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleMinerForm));
            this.tabControlMiners = new System.Windows.Forms.TabControl();
            this.imageListForTabs = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tabControlMiners
            // 
            this.tabControlMiners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMiners.Location = new System.Drawing.Point(0, 0);
            this.tabControlMiners.Name = "tabControlMiners";
            this.tabControlMiners.SelectedIndex = 0;
            this.tabControlMiners.Size = new System.Drawing.Size(722, 329);
            this.tabControlMiners.TabIndex = 0;
            // 
            // imageListForTabs
            // 
            this.imageListForTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListForTabs.ImageStream")));
            this.imageListForTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListForTabs.Images.SetKeyName(0, "About.jpg");
            this.imageListForTabs.Images.SetKeyName(1, "ethereum.png");
            this.imageListForTabs.Images.SetKeyName(2, "s_settings.png");
            this.imageListForTabs.Images.SetKeyName(3, "zcash.png");
            // 
            // SimpleMinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 329);
            this.Controls.Add(this.tabControlMiners);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleMinerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMiners;
        private System.Windows.Forms.ImageList imageListForTabs;
    }
}

