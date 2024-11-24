using Ecommerce.Store.Effects;
using MediatR;
using Refit;

namespace Ecommerce.Store.Actions
{
    internal class CustomSenderAction(IMediator Mediator,
                                      IErrorNotification ErrorNotification) : ICustomSenderAction
    {
        public async Task<TResponse?> Send<TResponse>(ICustomRequest<TResponse> request)
        {
            try
            {
                return await Mediator.Send(request);
            }
            catch (ApiException ex)
            {
                await ErrorNotification.Send(ex);
            }
            catch (Exception ex)
            {
                await ErrorNotification.Send(ex);
            }
            return default;
        }
    }
}
