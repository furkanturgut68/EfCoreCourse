using System;
using System.Collections.Generic;

namespace Udem.EfCore.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDateTime { get; set; }

        /////Navigation /////
        public List<SalesHistories> SalesHistories { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
