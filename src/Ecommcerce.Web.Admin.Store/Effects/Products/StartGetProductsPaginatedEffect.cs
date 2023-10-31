using Ecommcerce.Web.Admin.Store.Actions;
using Ecommerce.CommonClass;
using Ecommerce.Products;
using Fluxor;

namespace Ecommcerce.Web.Admin.Store.Effects.Products;

class StartGetProductsPaginatedEffect : Effect<StartGetProductsPaginated>
{
    readonly IProductSdk _productSdk;

    public StartGetProductsPaginatedEffect(IProductSdk productSdk)
    {
        _productSdk = productSdk;
    }

    public override async Task HandleAsync(StartGetProductsPaginated action, IDispatcher dispatcher)
    {
        Pagination<ProductOutput> products = 
            await _productSdk.GetProducts(accountId: "test",
                                          productIds: action.ProductIds,
                                          name: action.Name,
                                          isActive: action.IsActive,
                                          brands: action.Brands,
                                          page: action.Page,
                                          itemsPerPage: action.ItemsPerPage);

        dispatcher.Dispatch(new EndGetProductsPaginated(products));
    }
}
