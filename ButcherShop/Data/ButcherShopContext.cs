using ButcherShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ButcherShop.Data
{
    public class ButcherShopContext : DbContext
    {
        public ButcherShopContext(DbContextOptions<ButcherShopContext> options) : base(options)
        {
            Debug.WriteLine($"{ContextId} context created.");
        }

        public DbSet<Category>? Categories { get; set; }

        /// <summary>
        /// Dispose pattern.
        /// </summary>
        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        /// <summary>
        /// Dispose pattern.
        /// </summary>
        /// <returns>A <see cref="ValueTask"/></returns>
        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }
    }
}
