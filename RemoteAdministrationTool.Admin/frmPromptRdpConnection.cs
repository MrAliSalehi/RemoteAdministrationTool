using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RemoteAdministrationTool.Admin.Classes.Extensions;
using RemoteAdministrationTool.Admin.Models;

namespace RemoteAdministrationTool.Admin
{
    public partial class frmPromptRdpConnection : Form
    {
        private readonly Regex ipRegex = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");

        public frmPromptRdpConnection()
        {
            InitializeComponent();
        }

        private void frmPromptRdpConnection_Load(object sender, EventArgs e)
        {
            btn_done.Enabled = false;
        }
        private void tb_ip_TextChanged(object sender, EventArgs e)
        {
            var tryParsePort = int.TryParse(tb_port.Text, out var _port);
            if (string.IsNullOrEmpty(tb_ip.Text) ||  string.IsNullOrEmpty(tb_port.Text) || tryParsePort is false) return;
            if (ipRegex.IsMatch(tb_ip.Text) && _port.IsWithin(1, 65535))
            {
                btn_done.Enabled = true;
            }
            else
            {
                btn_done.Enabled = false;
            }
        }
        private void tb_port_TextChanged(object sender, EventArgs e)
        {
            var tryParsePort = int.TryParse(tb_port.Text, out var _port);
            if (string.IsNullOrEmpty(tb_ip.Text) || string.IsNullOrEmpty(tb_port.Text) || tryParsePort is false) return;
            if (ipRegex.IsMatch(tb_ip.Text) && _port.IsWithin(1, 65535))
            {
                btn_done.Enabled = true;
            }
            else
            {
                btn_done.Enabled = false;
            }
        }
        private void btn_done_Click(object sender, EventArgs e)
        {
            var model = new RdpConnectionModel()
            { IpAddress = tb_ip.Text, Port = int.Parse(tb_port.Text), User = tb_user.Text, Pass = tb_pass.Text };
            new frmRemoteRDP(model).Show();
            this.Hide();
        }

    }
}
