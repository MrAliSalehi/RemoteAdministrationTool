using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RemoteAdministrationTool.Admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_rdp_Click(object sender, EventArgs e)
        {

            new frmPromptRdpConnection().ShowDialog();
        }

        public void ChangeAccess(bool status)
        {
            try
            {
                var key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, Environment.MachineName);
                key = key.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", true);
                if (status)
                {
                    key.SetValue("fDenyTSConnections", 0, RegistryValueKind.DWord);
                    MessageBox.Show("Remote Desktop is now ENABLED");
                }
                else
                {
                    key.SetValue("fDenyTSConnections", 1, RegistryValueKind.DWord);
                    MessageBox.Show("Remote Desktop is now DISABLED");
                }
                key.Flush();
                if (key != null)
                    key.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}");
            }
        }

        public bool CheckAccess()
        {
            var key = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, Environment.MachineName);
            key = key.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", true);
            var val = key.GetValue("fDenyTSConnections");
            var state = (int)val != 0;
            return state;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (CheckAccess())
            {
                ts_disablerdp.Enabled = true;
                ts_enablerdp.Enabled = false;
            }
            else
            {
                ts_disablerdp.Enabled = false;
                ts_enablerdp.Enabled = true;
            }
        }

        private void ts_enablerdp_Click(object sender, EventArgs e)
        {
            ChangeAccess(true);
            ts_disablerdp.Enabled = true;
            ts_enablerdp.Enabled = false;
        }

        private void ts_disablerdp_Click(object sender, EventArgs e)
        {
            ChangeAccess(false);
            ts_disablerdp.Enabled = false;
            ts_enablerdp.Enabled = true;
        }
    }
}
