using System;
namespace AppCore.Entity
{
	public class City
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Addresss> Addressses { get; set; }
		public Province Province { get; set; }
		public int ProvinceId { get; set; }
	}
}

