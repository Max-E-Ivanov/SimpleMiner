namespace SimpleMiner.BaseForm
{
    partial class ucBaseUserControl
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
            this.toolTipManager = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // toolTipManager
            // 
            this.toolTipManager.IsBalloon = true;
            this.toolTipManager.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ucBaseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucBaseUserControl";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ToolTip toolTipManager;
    }
}
