using Shop_Auto.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Shop_Auto.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) : base(options)
        {
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
