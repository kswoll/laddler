using System.Collections.Generic;

namespace Laddler.Api.Database
{
    public class DbLadder
    {
        public int Id { get; set; }
        public string Name { get; set; }

		public List<DbPersonLadder> PersonLadders { get; set; }
    }
}