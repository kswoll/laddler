using System.Collections.Generic;

namespace Laddler.Api.Database
{
    public class DbMilestone
    {
		public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        public List<DbDimensionMilestone> DimensionMilestones { get; set; }
    }
}