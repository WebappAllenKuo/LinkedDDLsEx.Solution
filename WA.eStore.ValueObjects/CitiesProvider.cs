using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WA.eStore.ValueObjects
{
	public abstract class CitiesProvider
	{
		public abstract List<City> GetCities();
		// public abstract IEnumerable<Village> GetVillages(int cityId);
		public abstract List<Village> GetVillages(City city);
		
	}
}
