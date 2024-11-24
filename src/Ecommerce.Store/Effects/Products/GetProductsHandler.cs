using Ecommerce.CommonClass;
using Ecommerce.Products;
using MediatR;

namespace Ecommerce.Store.Effects.Products
{
    internal class GetProductsHandler(IProductSdk ProductSdk) :
                   IRequestHandler<GetProductsQuery, Pagination<ProductOutput>>
    {
        public async Task<Pagination<ProductOutput>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await ProductSdk.GetProducts(accountId: request.Filters.AccountId,
                                                productIds: request.Filters.ProductIds,
                                                name: request.Filters.Name,
                                                isActive: request.Filters.IsActive,
                                                brands: request.Filters.Brands,
                                                page: request.Filters.Page,
                                                itemsPerPage: request.Filters.ItemsPerPage);
        }
    }
}