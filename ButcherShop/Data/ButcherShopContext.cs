using ButcherShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ButcherShop.Data
{
    public class ButcherShopContext : DbContext
    {
        public ButcherShopContext(DbContextOptions<ButcherShopContext> options): base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
