using Ecommerce.Store.Actions;
using Ecommerce.Store.Actions.Products;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Store
{
    public static class ServiceCollection
    {
        public static void AddStore(this IServiceCollection services)
        {
            services.AddMediatR(e => 
            {
                e.RegisterServicesFromAssembly(typeof(ServiceCollection).Assembly);
            });

            services.AddScoped<ICustomSenderAction, CustomSenderAction>();

            services.AddScoped<IProductsActions, ProductsActions>();
        }
    }
}
