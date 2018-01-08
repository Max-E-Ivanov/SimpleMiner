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
            this.tabControlMiners = new System.Windows.Forms.TabControl();
            this.tabPageOptions = new System.Windows.Forms.TabPage();
            this.tabControlMiners.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMiners
            // 
            this.tabControlMiners.Controls.Add(this.tabPageOptions);
            this.tabControlMiners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMiners.Location = new System.Drawing.Point(0, 0);
            this.tabControlMiners.Name = "tabControlMiners";
            this.tabControlMiners.SelectedIndex = 0;
            this.tabControlMiners.Size = new System.Drawing.Size(722, 329);
            this.tabControlMiners.TabIndex = 0;
            // 
            // tabPageOptions
            // 
            this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.tabPageOptions.Name = "tabPageOptions";
            this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOptions.Size = new System.Drawing.Size(714, 303);
            this.tabPageOptions.TabIndex = 1;
            this.tabPageOptions.Text = "Options";
            this.tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // SimpleMinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 329);
            this.Controls.Add(this.tabControlMiners);
            this.Name = "SimpleMinerForm";
            this.Text = "Form1";
            this.tabControlMiners.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMiners;
        private System.Windows.Forms.TabPage tabPageOptions;
    }
}

