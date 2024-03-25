namespace Udem.EfCore.Data.Entities
{
    public class ProductCategory
    {
        public int ProuctId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
