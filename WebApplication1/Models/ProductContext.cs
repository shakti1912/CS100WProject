using System.Data.Entity;

namespace WebApplication1.Models
{
    public class ProductContext : DbContext 
    {
        public ProductContext() : base("WebApplication1") {
        
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; } 
    
    }
}