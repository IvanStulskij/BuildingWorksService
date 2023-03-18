using BuildingWorks.UI.BlazorWebAssembly.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5000/api/v1/"/*builder.HostEnvironment.BaseAddress*/) });
builder.Services.ConfigureServices();

await builder.Build().RunAsync();
