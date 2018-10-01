namespace Laddler.Api.Database
{
    public class DbUser
    {
        public int Id { get; set; }
		public int PersonId { get; set; }
		public string PasswordHash { get; set; }

		public DbPerson Person { get; set; }
    }
}