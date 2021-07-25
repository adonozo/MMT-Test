using Microsoft.EntityFrameworkCore;
using MMT.Shop.Models;

namespace MMT.Shop.DataSql
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}