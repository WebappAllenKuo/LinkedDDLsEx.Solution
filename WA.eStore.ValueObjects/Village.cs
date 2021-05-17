namespace WA.eStore.ValueObjects
{
	public class Village
	{
		public int Id { get; set; }
		public string VillageName { get; set; }
		public string ZipCode { get; set; }

		public Village(int id, string villageName, string zipCode)
		{
			Id = id;
			VillageName = villageName;
			ZipCode = zipCode;
		}

		public override string ToString()
		{
			return this.VillageName;
		}
	}
}