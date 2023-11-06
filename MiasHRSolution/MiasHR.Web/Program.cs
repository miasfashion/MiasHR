global using Microsoft.AspNetCore.Components.Authorization;
using MiasHR.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddTelerikBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, MiasAuthStateProvider>();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
