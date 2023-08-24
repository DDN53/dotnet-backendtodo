using System.ComponentModel.DataAnnotations;

namespace webapi99.Models
{
    public class Mobile
    {
        [Key]
        public int Id { get; set; }
        public long Number { get; set; }
        //public TimeSpan KeepAliveInterval { get; set; }
       // public System.Collections.Generic.IList<string> AllowedOrigins { get; }

    }
}
