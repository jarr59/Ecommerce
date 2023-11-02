using Ecommerce.CommonClass;
using Refit;

namespace Ecommerce.Products
{
    public interface IProductSdk
    {
        public const string URLBASE = "/api/accounts/{accountId}/products";

        /// <summary>
        /// Devuelve un listado de productos paginados
        /// </summary>
        /// <param name="accountId">Ids de cuenta</param>
        /// <param name="productIds">Ids de productos</param>
        /// <param name="name">Nombre, letra o palabra en el nombre del producto</param>
        /// <param name="isActive">Activo o inactivo</param>
        /// <param name="brands">Ids de marcas</param>
        /// <param name="page">Pagina</param>
        /// <param name="itemsPerPage">Items por pagina</param>
        [Get(URLBASE)]
        Task<Pagination<ProductOutput>> GetProducts(string accountId,
                                                    [Query(CollectionFormat = CollectionFormat.Multi)] IEnumerable<string>? productIds,
                                                    [Query] string? name,
                                                    [Query] bool? isActive,
                                                    [Query(CollectionFormat = CollectionFormat.Multi)] IEnumerable<string>? brands,
                                                    [Query] int page = 1,
                                                    [Query] int itemsPerPage = 10);

        /// <summary>
        /// Actualiza o crea un listado de productos
        /// </summary>
        /// <param name="accountId">Id de cuenta</param>
        /// <param name="input">Lista de productos a actualizar</param>
        /// <returns></returns>
        [Patch(URLBASE)]
        Task<IEnumerable<ProductOutput>> PatchProducts(string accountId,
                                                       [Body] IEnumerable<UpdateProductInput> input);
    }
}
