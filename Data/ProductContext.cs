using System.Data.Entity;
using Case.Models;

namespace Case.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext")
        {
 
        }
        public DbSet<Product> Products { get; set; }
    }
}