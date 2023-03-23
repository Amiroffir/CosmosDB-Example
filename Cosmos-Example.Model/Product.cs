using Newtonsoft.Json;
using System.Data.SqlTypes;

namespace Cosmos_Example.Model
{
	public class Product
	{
		[JsonProperty(PropertyName = "id")]
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public int SupplierID { get; set; }
		public int CategoryID { get; set; }
		public string QuantityPerUnit { get; set; }
		public decimal? UnitPrice { get; set; }
		public int? UnitsInStock { get; set; }
		public int? UnitsOnOrder { get; set; }
		public int ReorderLevel { get; set; }
		public bool Discontinued { get; set; }

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}

	}

}
