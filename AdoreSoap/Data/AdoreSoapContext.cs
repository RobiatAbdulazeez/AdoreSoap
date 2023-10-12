using Microsoft.EntityFrameworkCore;
using AdoreSoap.Models;

namespace AdoreSoap.Data
{
    public class AdoreSoapContext : DbContext
    {
        public AdoreSoapContext(DbContextOptions<AdoreSoapContext> options)
                   : base(options)
        {

        }

        public DbSet<Adore> Adore { get; set; }

    }
}
