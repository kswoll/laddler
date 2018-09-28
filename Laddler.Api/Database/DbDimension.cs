using System.Collections.Generic;

namespace Laddler.Api.Database
{
    public class DbDimension
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<DbDimensionMilestone> DimensionMilestones { get; set; }
    }
}