namespace RemoteAdministrationTool.Admin.Models
{
    public class RdpConnectionModel
    {
        public int Port { get; set; }
        public string IpAddress { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }
}