global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;

using MiasHR.Web;
using MiasHR.Web.Services;
using MiasHR.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//                      policy =>
//                      {
//                          policy.WithOrigins("https://localhost:7187")
//                            .AllowAnyMethod()
//                            .AllowAnyHeader()
//                            .AllowCredentials();
//                      });
//});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7211/") });
builder.Services.AddMudServices();
builder.Services.AddTelerikBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, MiasAuthStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
