using System;
using NewLetsPet.Domain.Stock;
using NewLetsPet.Repositories.Interfaces;

namespace NewLetsPet.Repositories
{
	public class ProductRepository : IProductRepository
    {
		public ProductRepository()
		{
		}

		public List<Product> GetProducts()
		{
			return new List<Product>();
		}
	}
}

