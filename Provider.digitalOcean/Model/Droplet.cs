using System;
using System.Collections.Generic;

namespace Provider.digitalOcean.Model
{
    public class Droplet
    {
        public int id { get; set; }
        public string name { get; set; }
        public int memory { get; set; }
        public int vcpus { get; set; }
        public int disk { get; set; }
        public bool locked { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public List<string> features { get; set; }
        public List<int> backup_ids { get; set; }
        public List<int> snapshot_ids { get; set; }
        public List<Image> images { get; set; }
        public List<int> volumes_ids { get; set; }
    }
}