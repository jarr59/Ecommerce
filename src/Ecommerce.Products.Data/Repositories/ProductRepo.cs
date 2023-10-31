using Ecommerce.CommonClass;
using Ecommerce.Products.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ecommerce.Products.Data.Repositories
{
    public class ProductRepo : IProductRepo
    {
        readonly ProductContext _productContext;

        public ProductRepo(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public async Task SaveChangesAsync()
        {
            await _productContext.SaveChangesAsync();
        }

        public async Task Create(List<Product> products)
        {
            await _productContext.Products.AddRangeAsync(products);
        }

        public async Task<List<Product>> GetByIds(IEnumerable<string> entityIds, string accountId)
        {
            return await _productContext.Products.Where(x => entityIds.Contains(x.Id) && x.AccountId == accountId).ToListAsync();
        }

        public async Task<Pagination<Product>> GetPagination(string accountId, List<string> productIds, string? name, bool? isActive, List<string> brands, int page, int itemsPerPage)
        {
            Expression<Func<Product, bool>> expression = x => (x.AccountId == accountId) &&
                                                              (!productIds.Any() || productIds.Contains(x.Id)) &&
                                                              (string.IsNullOrEmpty(name) || x.Name.Contains(name)) &&
                                                              (isActive == null || (isActive == true && x.IsActive == true) || (isActive == false && x.IsActive == false)) &&
                                                              (!brands.Any() || (!string.IsNullOrEmpty(x.Brand) && brands.Contains(x.Brand)));

            IEnumerable<Product> products = await _productContext.Products.Where(expression)
                                                                          .Skip((page - 1) * itemsPerPage)
                                                                          .Take(itemsPerPage)
                                                                          .OrderBy(x => x.Name)
                                                                          .ToListAsync();

            int totalItems = await _productContext.Products.CountAsync();

            return new Pagination<Product>(products, page, itemsPerPage, totalItems);
        }
    }
}
