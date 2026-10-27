using System.Collections.Generic;

namespace MyApp.Models
{
	public class ProductListViewModel
	{
		public string CategoryName { get; set; }
		public List<Product> Products { get; set; }
	}
}