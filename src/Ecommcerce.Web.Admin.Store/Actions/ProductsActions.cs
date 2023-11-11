using Ecommerce.CommonClass;
using Ecommerce.Enums;
using Ecommerce.Products;

namespace Ecommcerce.Web.Admin.Store.Actions;

/// <summary>
/// Inicia el seteo de los filtros en el state
/// </summary>
public record SetNewFilters(FiltersData FiltersData);

/// <summary>
/// Accion para obtener un listado de productos paginados
/// </summary>
public record StartGetProductsPaginated(FiltersData FiltersData);

/// <summary>
/// Accion que se despacha al terminar de obtener los productos paginados
/// </summary>
public record EndGetProductsPaginated(Pagination<ProductOutput> Pagination);


/// <summary>
/// 
/// </summary>
/// <param name="ProductIds">Listado de ids de productos</param>
/// <param name="Name">Nombre de producto</param>
/// <param name="StateSelectionOptions">Estado de producto</param>
/// <param name="Brands">Listado de marcas</param>
/// <param name="Page">Pagina a buscar</param>
/// <param name="ItemsPerPage">Items por pagina</param>
public record FiltersData(IEnumerable<string>? ProductIds,
                          string? Name,
                          StateSelectionOptions StateSelectionOptions,
                          IEnumerable<string>? Brands,
                          int Page,
                          int ItemsPerPage);

