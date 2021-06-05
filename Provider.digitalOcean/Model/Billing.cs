namespace Provider.digitalOcean.Model
{
    public class Billing
    {
        public string month_to_date_balance { get; set; }
        public string account_balance { get; set; }
        public string month_to_date_usage { get; set; }
        public string generated_at { get; set; }
    }
}