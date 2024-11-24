using Ecommerce.Products;
using Ecommerce.Web.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using Refit;
using Ecommerce.Web.Views;
using Ecommerce.Store;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddFluentUIComponents();

builder.Services.AddStore();

builder.Services.AddViews();

builder.Services.AddRefitClient<IProductSdk>()
    .ConfigureHttpClient(e => e.BaseAddress = new Uri("https://localhost:7001/"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddAdditionalAssemblies([ typeof(Ecommerce.Web.Views._Imports).Assembly ])
    .AddInteractiveServerRenderMode();

app.Run();
