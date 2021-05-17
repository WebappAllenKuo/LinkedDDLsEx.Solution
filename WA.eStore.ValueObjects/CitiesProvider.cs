using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WA.eStore.ValueObjects
{
	public abstract class CitiesProvider
	{
		public abstract IEnumerable<City> GetCities();
		// public abstract IEnumerable<Village> GetVillages(int cityId);
		public abstract IEnumerable<Village> GetVillages(City city);
		
	}
}
