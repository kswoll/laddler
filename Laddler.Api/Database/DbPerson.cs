using System.Collections.Generic;

namespace Laddler.Api.Database
{
	public class DbPerson
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public List<DbPersonLadder> PersonLadders { get; set; }
	}
}