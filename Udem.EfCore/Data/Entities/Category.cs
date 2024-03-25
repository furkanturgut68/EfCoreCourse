using System.Collections.Generic;

namespace Udem.EfCore.Data.Entities
{
    public class Category
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

    }
}
