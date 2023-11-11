using Ecommcerce.Web.Admin.Store.Actions;
using Ecommcerce.Web.Admin.Store.Helpers;
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
                                          productIds: action.FiltersData.ProductIds,
                                          name: action.FiltersData.Name,
                                          isActive: CommonHelper.ConvertStateSelectionToBool(action.FiltersData.StateSelectionOptions),
                                          brands: action.FiltersData.Brands,
                                          page: action.FiltersData.Page < 1 ? 1 : action.FiltersData.Page,
                                          itemsPerPage: action.FiltersData.ItemsPerPage);

        dispatcher.Dispatch(new EndGetProductsPaginated(products));
    }
}
