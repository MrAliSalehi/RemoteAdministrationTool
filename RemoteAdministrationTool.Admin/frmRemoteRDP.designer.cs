
namespace RemoteAdministrationTool.Admin
{
    partial class frmRemoteRDP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoteRDP));
            this.remoteScript = new AxMSTSCLib.AxMsRdpClient8NotSafeForScripting();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_newconnect = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.remoteScript)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remoteScript
            // 
            this.remoteScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteScript.Enabled = true;
            this.remoteScript.Location = new System.Drawing.Point(0, 24);
            this.remoteScript.Name = "remoteScript";
            this.remoteScript.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("remoteScript.OcxState")));
            this.remoteScript.Size = new System.Drawing.Size(655, 395);
            this.remoteScript.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_disconnect,
            this.ts_newconnect});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // ts_disconnect
            // 
            this.ts_disconnect.Name = "ts_disconnect";
            this.ts_disconnect.Size = new System.Drawing.Size(180, 22);
            this.ts_disconnect.Text = "Disconnect";
            this.ts_disconnect.Click += new System.EventHandler(this.ts_disconnect_Click);
            // 
            // ts_newconnect
            // 
            this.ts_newconnect.Name = "ts_newconnect";
            this.ts_newconnect.Size = new System.Drawing.Size(180, 22);
            this.ts_newconnect.Text = "New Connection";
            // 
            // frmRemoteRDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 419);
            this.Controls.Add(this.remoteScript);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRemoteRDP";
            this.ShowIcon = false;
            this.Text = "Desktop-";
            this.Load += new System.EventHandler(this.frmRemoteRDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remoteScript)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMSTSCLib.AxMsRdpClient8NotSafeForScripting remoteScript;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_disconnect;
        private System.Windows.Forms.ToolStripMenuItem ts_newconnect;
    }
}