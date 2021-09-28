
namespace RemoteAdministrationTool.Admin
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rdp = new System.Windows.Forms.ToolStripMenuItem();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_enablerdp = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_disablerdp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolsToolStripMenuItem
            // 
            this.connectionToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteConnectToolStripMenuItem});
            this.connectionToolsToolStripMenuItem.Name = "connectionToolsToolStripMenuItem";
            this.connectionToolsToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.connectionToolsToolStripMenuItem.Text = "Connection-Tools";
            // 
            // remoteConnectToolStripMenuItem
            // 
            this.remoteConnectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_rdp,
            this.permissionsToolStripMenuItem});
            this.remoteConnectToolStripMenuItem.Name = "remoteConnectToolStripMenuItem";
            this.remoteConnectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.remoteConnectToolStripMenuItem.Text = "Remote-Connect";
            // 
            // btn_rdp
            // 
            this.btn_rdp.Name = "btn_rdp";
            this.btn_rdp.Size = new System.Drawing.Size(180, 22);
            this.btn_rdp.Text = "RDP";
            this.btn_rdp.Click += new System.EventHandler(this.btn_rdp_Click);
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_enablerdp,
            this.ts_disablerdp});
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permissionsToolStripMenuItem.Text = "Permissions";
            // 
            // ts_enablerdp
            // 
            this.ts_enablerdp.Name = "ts_enablerdp";
            this.ts_enablerdp.Size = new System.Drawing.Size(180, 22);
            this.ts_enablerdp.Text = "Enable";
            this.ts_enablerdp.Click += new System.EventHandler(this.ts_enablerdp_Click);
            // 
            // ts_disablerdp
            // 
            this.ts_disablerdp.Name = "ts_disablerdp";
            this.ts_disablerdp.Size = new System.Drawing.Size(180, 22);
            this.ts_disablerdp.Text = "Disable";
            this.ts_disablerdp.Click += new System.EventHandler(this.ts_disablerdp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 235);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "RA-Tools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_rdp;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_enablerdp;
        private System.Windows.Forms.ToolStripMenuItem ts_disablerdp;
    }
}

