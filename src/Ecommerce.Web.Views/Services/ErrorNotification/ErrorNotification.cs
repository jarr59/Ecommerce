using Ecommerce.Store.Actions;
using Refit;

namespace Ecommerce.Web.Views.Services.ErrorNotification
{
    internal class ErrorNotification : IErrorNotification
    {
        public Task Send(ApiException ex)
        {
            throw new NotImplementedException();
        }

        public Task Send(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
