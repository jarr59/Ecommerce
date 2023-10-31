using Ecommerce.CommonClass;
using MediatR;

namespace Ecommerce.Products.Queries;

/// <summary>
/// Obtiene un listado de productos paginados y filtrados
/// </summary>
/// <param name="AccountId">Cuenta</param>
/// <param name="ProductIds">Listado de ids de productos</param>
/// <param name="Name">Nombre de producto</param>
/// <param name="IsActive">Estado de producto</param>
/// <param name="Brands">Listado de marcas</param>
public record GetProductsPaginated(string AccountId,
                                   List<string>? ProductIds,
                                   string? Name,
                                   bool? IsActive,
                                   List<string>? Brands,
                                   int Page, 
                                   int ItemsPerPage) : IRequest<Pagination<Product>>;
