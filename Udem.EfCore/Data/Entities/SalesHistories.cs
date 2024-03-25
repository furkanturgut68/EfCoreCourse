using System.Collections.Generic;

namespace Udem.EfCore.Data.Entities
{
    public class SalesHistories
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
