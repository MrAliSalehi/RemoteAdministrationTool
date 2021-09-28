using System;
using System.IO.Ports;
using System.Windows.Forms;
using RemoteAdministrationTool.Admin.Models;

namespace RemoteAdministrationTool.Admin
{
    public partial class frmRemoteRDP : Form
    {
        private readonly RdpConnectionModel _rdpModel;
        public frmRemoteRDP(RdpConnectionModel rdpModel)
        {
            _rdpModel = rdpModel;
            InitializeComponent();
        }

        private void frmRemoteRDP_Load(object sender, System.EventArgs e)
        {
            try
            {
                ts_disconnect.Enabled = false;
                ts_newconnect.Enabled = false;
                remoteScript.DesktopWidth = Screen.PrimaryScreen.Bounds.Width;
                remoteScript.DesktopHeight = Screen.PrimaryScreen.Bounds.Height;
                remoteScript.Server = _rdpModel.IpAddress;
                remoteScript.UserName = _rdpModel.User;
                remoteScript.AdvancedSettings2.ClearTextPassword = _rdpModel.Pass;
                remoteScript.AdvancedSettings7.EnableCredSspSupport = true;
                remoteScript.OnConnected += RemoteScript_OnConnected;
                remoteScript.OnDisconnected += RemoteScript_OnDisconnected;
                remoteScript.Connect();
            }
            catch (Exception exception)
            {
                var err = MessageBox.Show(exception.Message, "error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                switch (err)
                {
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                    case DialogResult.Retry:
                        new frmRemoteRDP(_rdpModel).Show();
                        this.Close();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

        }

        private void RemoteScript_OnDisconnected(object sender, AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent e)
        {
            MessageBox.Show("Connection Disposed", "error");
            this.Close();
        }

        private void RemoteScript_OnConnected(object sender, System.EventArgs e)
        {
            ts_disconnect.Enabled = true;
            this.Text = $@"Desktop {_rdpModel.IpAddress}";
        }

        private void ts_disconnect_Click(object sender, EventArgs e)
        {
            if (remoteScript.Connected != 1) return;
            remoteScript.Disconnect();
            this.Close();
        }
    }
}
