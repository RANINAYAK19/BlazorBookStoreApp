using Microsoft.EntityFrameworkCore;
using BlazorBookStoreApp.Data;
using BlazorBookStoreApp.Models;

namespace BlazorBookStoreApp.Services
{
    public class DataService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        // Inject IServiceScopeFactory into the constructor
        public DataService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        // Fetch Orders data
        public async Task<List<Order>> GetOrdersAsync()
        {
            //await Task.Delay(10000);
            using (var scope = _serviceScopeFactory.CreateScope()) // Create a scope for DbContext
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>(); // Get DbContext instance
                return await context.Orders.Include(o => o.Customer).ToListAsync();
            }
        }

        // Fetch Customers data
        public async Task<List<Customer>> GetCustomersAsync()
        {
            using (var scope = _serviceScopeFactory.CreateScope()) // Create a scope for DbContext
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>(); // Get DbContext instance
                return await context.Customers.ToListAsync().ConfigureAwait(false);
            }
        }
    }
}
