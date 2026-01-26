using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UrlShortening.Web;
using UrlShortening.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(service =>
{
    IConfiguration configuration = service.GetRequiredService<IConfiguration>();
    string? baseUrl = configuration["ApiOptions:BaseUrl"];

    return new HttpClient
    {
        BaseAddress = new Uri(baseUrl!)
    };
});

builder.Services.AddScoped<CodeService>();

await builder.Build().RunAsync();
