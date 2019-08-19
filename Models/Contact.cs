

namespace ThunderApi.Models
{
    public class Contact
    {
        public long Id { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }
        
        public string phone { get; set; }
        public string email  { get; set; }

        public string addresses { get; set; }
    }
}
