using Microsoft.EntityFrameworkCore;

namespace Laddler.Api.Database
{
    public class LaddlerDb : DbContext
    {
        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbPerson> Persons { get; set; }
        public DbSet<DbDimension> Dimensions { get; set; }
        public DbSet<DbDimensionGroup> DimensionGroups { get; set; }
        public DbSet<DbDimensionMilestone> DimensionMilestones { get; set; }
        public DbSet<DbLadder> Ladders { get; set; }
        public DbSet<DbLevel> Levels { get; set; }
        public DbSet<DbMilestone> Milestones { get; set; }
        public DbSet<DbPersonDimension> PersonDimensions { get; set; }
        public DbSet<DbPersonLadder> PersonLadders { get; set; }

        public LaddlerDb(DbContextOptions options) : base(options)
        {
        }
    }
}