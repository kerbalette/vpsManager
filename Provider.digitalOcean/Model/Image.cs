using System;
using System.Collections.Generic;

namespace Provider.digitalOcean.Model
{
    public class Image
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string distribution { get; set; }
        public string slug { get; set; }
        public List<string> regions { get; set; }
        public DateTime created_in { get; set; }
        public int min_disk_size { get; set; }
        public float size_gigabytes { get; set; }
        public string description { get; set; }
        public List<string> tags { get; set; }
        public string status { get; set; }
        public string error_message { get; set; }
    }
}