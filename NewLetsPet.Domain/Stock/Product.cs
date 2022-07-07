using System;
using NewLetsPet.Domain.Common.Enums;

namespace NewLetsPet.Domain.Stock
{
	public class Product
	{
        public long Id { get; set; }
        public Guid ProductCode { get; set; }
        public Category Category { get; set; }
        //public Usage Usage { get; private set; }
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public double Price { get; private set; }
        public int TotalVolume { get; private set; }
        public DateTime ExpirationDate { get; set; }
        public Species Species { get; set; }

        public Product()
		{
		}
	}
}

