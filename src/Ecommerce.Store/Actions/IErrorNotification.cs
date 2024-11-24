using Refit;

namespace Ecommerce.Store.Actions
{
    public interface IErrorNotification
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task Send(ApiException ex);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task Send(Exception ex);
    }
}
