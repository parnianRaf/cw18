using System;
namespace AppCore.Entity
{
	public class Book
	{
		public int Id { get; set; }
		public string BookName { get; set; }
		public List<MemberBook> MemberBooks { get; set; }
		public Genre Genre { get; set; }
		public int GenreId { get; set; }
	}
}

