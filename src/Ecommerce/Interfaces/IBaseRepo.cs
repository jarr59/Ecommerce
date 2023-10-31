namespace Ecommerce.Interfaces;

public interface IBaseRepo<T> where T : class
{
    Task SaveChangesAsync();

    /// <summary>
    /// Devuelve un listado de <see cref="T"/>
    /// </summary>
    /// <param name="entityIds"></param>
    /// <returns></returns>
    Task<List<T>> GetByIds(IEnumerable<string> entityIds, string accountId);


    /// <summary>
    /// Crea un listado de la entity <see cref="T"/>
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>
    Task Create(List<T> entities);
}
