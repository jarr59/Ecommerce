using Ecommerce.CommonClass;
using Ecommerce.Products;

namespace Ecommcerce.Web.Admin.Store.Actions;

/// <summary>
/// Accion para obtener un listado de productos paginados
/// </summary>
/// <param name="ProductIds">Listado de ids de productos</param>
/// <param name="Name">Nombre de producto</param>
/// <param name="IsActive">Estado de producto</param>
/// <param name="Brands">Listado de marcas</param>
/// <param name="Page">Pagina a buscar</param>
/// <param name="ItemsPerPage">Items por pagina</param>
public record StartGetProductsPaginated(List<string>? ProductIds,
                                        string? Name,
                                        bool? IsActive,
                                        List<string>? Brands,
                                        int Page,
                                        int ItemsPerPage);

/// <summary>
/// Accion que se despacha al terminar de obtener los productos paginados
/// </summary>
public record EndGetProductsPaginated(Pagination<ProductOutput> Pagination);