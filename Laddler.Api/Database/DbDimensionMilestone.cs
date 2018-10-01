namespace Laddler.Api.Database
{
    public class DbDimensionMilestone
    {
        public int Id { get; set; }
        public int DimensionId { get; set; }
        public int MilestoneId { get; set; }
		public string Description { get; set; }

        public DbDimension Dimension { get; set; }
        public DbMilestone Milestone { get; set; }
    }
}