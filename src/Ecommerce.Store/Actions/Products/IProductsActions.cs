using Ecommerce.CommonClass;
using Ecommerce.Products;
using Ecommerce.Store.Actions.Products.Inputs;

namespace Ecommerce.Store.Actions.Products
{
    public interface IProductsActions
    {
        /// <summary>
        /// Get Products Paginated
        /// </summary>
        Task<Pagination<ProductOutput>?> GetProducts(GetProductsFilters filters);
    }
}
