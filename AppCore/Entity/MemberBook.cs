using System;
namespace AppCore.Entity
{
	public class MemberBook
	{
		public int MemberId { get; set; }
		public Member Members { get; set; }
		public int BookId { get; set; }
		public Book Books { get; set; }
	}
}

