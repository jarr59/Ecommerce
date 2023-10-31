using Ecommerce.CommonClass;
using Ecommerce.Interfaces;

namespace Ecommerce.Products.Interfaces;

public interface IProductRepo : IBaseRepo<Product>
{
    /// <summary>
    /// Devuelve una paginacion de productos filtrados
    /// </summary>
    /// <param name="AccountId">Cuenta</param>
    /// <param name="ProductIds">Listado de ids de productos</param>
    /// <param name="Name">Nombre de producto</param>
    /// <param name="IsActive">Estado de producto</param>
    /// <param name="Brands">Listado de marcas</param>
    /// <returns></returns>
    Task<Pagination<Product>> GetPagination(string accountId,
                                            List<string> productIds,
                                            string? name,
                                            bool? isActive,
                                            List<string> brands,
                                            int page, 
                                            int itemsPerPage);
}
