using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCore.Entity
{
	public class Member
	{
		
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Addresss Address { get; set; }
		public List<MemberBook> MemberBooks { get; set; }
	}
}

