using Ecommerce.CommonClass;
using Ecommerce.Products;
using Ecommerce.Store.Actions.Products.Inputs;
using MediatR;

namespace Ecommerce.Store.Effects.Products
{
    /// <summary>
    /// GET products by filters
    /// </summary>
    internal record GetProductsQuery(GetProductsFilters Filters) : ICustomRequest<Pagination<ProductOutput>>;
}
