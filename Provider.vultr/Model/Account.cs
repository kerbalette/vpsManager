using System;
using System.Text.Json.Serialization;

namespace vultr.Model
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public int PendingCharges { get; set; }
        public DateTime LastPaymentDate { get; set; }
        public decimal LastPaymentAmount { get; set; }
    }
}