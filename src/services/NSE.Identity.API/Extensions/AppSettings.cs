namespace NSE.Identity.API.Extensions
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int HoursExpires { get; set; }
        public string Issuer { get; set; }
        public string ValidAudience { get; set; }
    }
}
