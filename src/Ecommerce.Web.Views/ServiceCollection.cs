using Ecommerce.Store.Actions;
using Ecommerce.Web.Views.Services.ErrorNotification;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Web.Views
{
    public static class ServiceCollection
    {
        public static void AddViews(this IServiceCollection services)
        {
            services.AddScoped<IErrorNotification, ErrorNotification>();
        }
    }
}
