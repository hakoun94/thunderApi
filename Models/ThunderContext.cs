using Microsoft.EntityFrameworkCore;

namespace ThunderApi.Models
{
    public class ThunderContext : DbContext
    {
        public ThunderContext(DbContextOptions<ThunderContext> options)
            : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}


