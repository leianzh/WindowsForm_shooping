using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_shooping
{
	public class Shooping
	{
        public  Product Product { get; set; }
        public int Quantity { get; set; }
       

		public Shooping(Product product, int quantity)
		{
			Product = product;
			Quantity = quantity;
			
		}
		public int SubTotal => Product.Price * Quantity;
	}
}
