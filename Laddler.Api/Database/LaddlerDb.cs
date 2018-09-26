using Microsoft.EntityFrameworkCore;

namespace Laddler.Api.Database
{
    public class LaddlerDb : DbContext
    {
        public DbSet<DbUser> Users { get; set; }

        public LaddlerDb(DbContextOptions options) : base(options)
        {
        }
    }
}