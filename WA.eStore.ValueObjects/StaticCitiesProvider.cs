using System.Collections.Generic;
using System.Linq;

namespace WA.eStore.ValueObjects
{
	public class StaticCitiesProvider :CitiesProvider
	{
		private static List<City> cities = null;
		
		static StaticCitiesProvider()
		{
			cities = new List<City>
			{
				new City(1,
					"台北", 
					new List<Village>
					{
						new Village( 1,"大安區","100"),
						new Village( 2,"中正區","110"),
					}
				),
				new City(2,
					"台中",
					new List<Village>
					{
						new Village( 1,"北區","500"),
						new Village( 2,"南區","510"),
					}
				),
			};
		}


		public override List<City> GetCities()
		{
			return StaticCitiesProvider.cities.OrderBy(x => x.Id).ToList();
		}

		public override List<Village> GetVillages(City city)
		{
			return StaticCitiesProvider.cities
				.FirstOrDefault(x => x.Id == city.Id)
				?.Villages;
		}
	}
}