namespace Laddler.Api.Database
{
	public class DbPersonLadder
	{
		public int Id { get; set; }
		public int PersonId { get; set; }
		public int LadderId { get; set; }

		public DbPerson Person { get; set; }
		public DbLadder Ladder { get; set; }
	}
}