using ButcherShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ButcherShop.Data
{
    public class CategoryService
    {
        private readonly ButcherShopContext _context;

        public CategoryService(ButcherShopContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> LoadCategoryAsync()
        {
            return await _context.Categories.OrderBy(_ => _.SortOrder).ToListAsync();
        }
    }
}
