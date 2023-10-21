using Ecommerce.Products.Interfaces;

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

        public async Task Update(List<Product> products)
        {
            await _productContext.Products.AddRangeAsync(products);
        }
    }
}
