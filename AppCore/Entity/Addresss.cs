using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCore.Entity
{
	public class Addresss
	{
	
		public int Id { get; set; }
		public string AddressDes { get; set; }
		public string? Description { get; set; }
		public Member Member { get; set; }
		public City City { get; set; }
		public int CityId { get; set; }
	}
}

