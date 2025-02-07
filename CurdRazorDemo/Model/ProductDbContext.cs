using Microsoft.EntityFrameworkCore;

namespace CurdRazorDemo.Model
{
    public class ProductDbContext :DbContext
    {
        public DbSet<Product>Products { get; set; }


        //creating constructor 
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }


    }
}
