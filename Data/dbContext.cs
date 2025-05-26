using Microsoft.EntityFrameworkCore;
using ProductApi.Models;

namespace ProductApi.data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options){}
        public DbSet<Product> Products { get; set; } //database table
    }
}