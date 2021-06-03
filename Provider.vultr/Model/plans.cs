namespace vultr.Model
{
    public class plans
    {
        public int id { get; set; }
        public string name { get; set; }
        public int vcpu_count { get; set; }
        public int ram { get; set;  }
        public int disk { get; set; }
        public int bandwidth { get; set; }
        public int monthly_cost { get; set; }
        public string type { get; set; }
        public int disk_count { get; set; }
    }
}