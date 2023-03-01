using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blazor_onchange;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.RegisterCustomElement<blazor_onchange.Pages.Index>("app-element");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
