using Ecommcerce.Web.Admin.Store.Actions;
using Ecommcerce.Web.Admin.Store.States;
using Fluxor;

namespace Ecommcerce.Web.Admin.Store.Reducers
{
    public static class ProductsReducers
    {
        [ReducerMethod]
        public static ProductsState OnStartGetProductsPaginated(ProductsState state, StartGetProductsPaginated action)
        {
            ProductFiltersState productFiltersState = state.FiltersState with
            {
                ProductIds = action.ProductIds,
                Name = action.Name,
                IsActive = action.IsActive,
                Brands = action.Brands,
                Page = action.Page,
                ItemsPerPage = action.ItemsPerPage,
                ShowLoader = true
            };

            return state with
            {
                FiltersState = productFiltersState
            };
        }

        [ReducerMethod]
        public static ProductsState OnEndGetProductsPaginated(ProductsState state, EndGetProductsPaginated action)
        {
            ProductFiltersState productFiltersState = state.FiltersState with
            {
                ShowLoader = false,
                Pagination = action.Pagination
            };

            return state with
            {
                FiltersState = productFiltersState
            };
        }
    }
}
