using EcommerceKernel.Interfaces;

namespace Ecommerce.Products.Interfaces;

public interface IProductRepo : IBaseRepo
{
    /// <summary>
    /// Agrega o actualiza un producto
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    Task Update(List<Product> product);
}
