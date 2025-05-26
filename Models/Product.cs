using System;
namespace ProductApi.models
{ 

	public class Prouct
	{
		public int Id {  get; set; } //table primary key
		public string Name { get; set; }
		public decimal Price { get; set; }
	}
}


}