using Ecommerce.Enums;
using Fluxor;

namespace Ecommcerce.Web.Admin.Store.States
{
    /// <summary>
    /// Representa el state de productos
    /// </summary>
    public record ProductsState(ProductFiltersState? FiltersState);

    /// <summary>
    /// State que representa los ultimos filtros seleccionados
    /// </summary>
    public record ProductFiltersState(IEnumerable<string>? ProductIds,
                                      string? Name,
                                      StateSelectionOptions StateSelection,
                                      IEnumerable<string>? Brands,
                                      int Page,
                                      int ItemsPerPage);

    [FeatureState]
    public class ProductsStateFeatureState : Feature<ProductsState>
    {
        public override string GetName() => nameof(ProductsState);

        protected override ProductsState GetInitialState() =>
            new(FiltersState: null);
    }
}
