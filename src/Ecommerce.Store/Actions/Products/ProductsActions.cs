using Ecommerce.CommonClass;
using Ecommerce.Products;
using Ecommerce.Store.Actions.Products.Inputs;
using Ecommerce.Store.Effects.Products;

namespace Ecommerce.Store.Actions.Products
{
    internal class ProductsActions(ICustomSenderAction CustomSenderAction) : IProductsActions
    {
        public async Task<Pagination<ProductOutput>?> GetProducts(GetProductsFilters filters)
        {
            GetProductsQuery GetProducts = new(filters);

            return await CustomSenderAction.Send(GetProducts);
        }
    }
}
