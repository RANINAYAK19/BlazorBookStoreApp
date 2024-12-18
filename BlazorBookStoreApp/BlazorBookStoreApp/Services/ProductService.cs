using Microsoft.EntityFrameworkCore;
using BlazorBookStoreApp.Data;
using BlazorBookStoreApp.Models;

namespace BlazorBookStoreApp.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
