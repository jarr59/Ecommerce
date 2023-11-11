using Ecommcerce.Web.Admin.Store.Actions;
using Ecommcerce.Web.Admin.Store.States;
using Ecommerce;
using Fluxor;

namespace Ecommcerce.Web.Admin.Store.Reducers
{
    public static class ProductsReducers
    {
        //[ReducerMethod]
        //public static ProductsState OnStartSetProductFiltersInPagination(ProductsState state, StartGetProductsPaginated action)
        //{
        //    StateSelectionOptions selectionOptions =  StateSelectionOptions.All;

        //    switch (action.Filters.IsActive)
        //    {
        //        case null:
        //            selectionOptions = StateSelectionOptions.All;
        //            break;
        //        case true:
        //            selectionOptions = StateSelectionOptions.Active;
        //            break;
        //        case false:
        //            selectionOptions = StateSelectionOptions.Inactive;
        //            break;

        //    }

        //    ProductFiltersState productFiltersState = state.FiltersState with
        //    {
        //        ProductIds = action.Filters.ProductIds,
        //        Name = action.Filters.Name,
        //        StateSelection = selectionOptions,
        //        Brands = action.Filters.Brands,
        //        Page = action.Filters.Page,
        //        ItemsPerPage = action.Filters.ItemsPerPage
        //    };

        //    return state with
        //    {
        //        FiltersState = productFiltersState
        //    };
        //}

        //[ReducerMethod]
        //public static ProductsState OnEndGetProductsPaginated(ProductsState state, EndGetProductsPaginated action)
        //{
        //    ProductFiltersState productFiltersState = state.FiltersState with
        //    {
        //        ShowLoader = false,
        //        Pagination = action.Pagination
        //    };

        //    return state with
        //    {
        //        FiltersState = productFiltersState
        //    };
        //}
    }
}
