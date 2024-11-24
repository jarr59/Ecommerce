using Ecommerce.Store.Effects;

namespace Ecommerce.Store.Actions
{
    public interface ICustomSenderAction
    {
        /// <summary>
        /// 
        /// </summary>
        Task<TResponse?> Send<TResponse>(ICustomRequest<TResponse> request);
    }
}
