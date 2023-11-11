using Ecommcerce.Web.Admin;
using Ecommcerce.Web.Admin.Store;
using Ecommerce.Products;
using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddFluxor(o => 
{
    o.ScanAssemblies(typeof(DummyMarker).Assembly);

#if DEBUG
    o.UseReduxDevTools();
#endif
});


builder.Services.AddRefitClient<IProductSdk>()
                .ConfigureHttpClient(x => x.BaseAddress = new Uri("https://localhost:7001/"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
