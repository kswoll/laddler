namespace Laddler.Api.Database
{
	public class DbPersonDimension
	{
		public int Id { get; set; }
		public int PersonLadderId { get; set; }

		public DbPersonLadder PersonLadder { get; set; }
		public DbDimensionMilestone DimensionMilestone { get; set; }
	}
}