namespace Provider.digitalOcean.Model
{
    public class Account
    {
        public int droplet_limit { get; set; }
        public int floating_ip_limit { get; set; }
        public string email { get; set; }
        public string uuid { get; set; }
        public bool email_verified { get; set; }
        public string status { get; set; }
        public string status_message { get; set; }
    }
}