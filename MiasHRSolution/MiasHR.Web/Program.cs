global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
global using Blazored.SessionStorage;

using MiasHR.Web;
using MiasHR.Web.Services;
using MiasHR.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
if (builder.HostEnvironment.Environment == "Production")
{
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api.miasfashion.com:8080/") }); 
}
else
{
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7211/") });
}
builder.Services.AddMudServices();
builder.Services.AddTelerikBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, MiasAuthStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IDayTimeOffRequestService, DayTimeOffRequestService>();
builder.Services.AddScoped<IEmployeeInfoRequestService, EmployeeInfoRequestService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();

await builder.Build().RunAsync();
