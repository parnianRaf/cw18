using System;
namespace AppCore.Entity
{
	public class Province
	{
		public int Id { get; set; }
		public string ProvinceName { get; set; }
		public List<City> Cities { get; set; }
	}
}

