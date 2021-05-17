using System.Collections.Generic;

namespace WA.eStore.ValueObjects
{
	public class City
	{
		public int Id { get; set; }
		public string CityName { get; }
		public List<Village> Villages { get; set; }

		public City(int id, string cityName, List<Village> villages)
		{
			Id = id;
			CityName = cityName;
			Villages = villages;
		}

		public override string ToString()
		{
			return this.CityName;
		}
	}
}