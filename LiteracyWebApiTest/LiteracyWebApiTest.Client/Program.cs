using Blazored.LocalStorage;
using LiteracyWebApiTest.Client.BFFService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF1cXmhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEFjW31ZcndQTmRZVUJwVg==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthenticationStateProvider, BffAuthenticationStateProvider>();

builder.Services.AddTransient<AntiforgeryHandler>();
builder.Services.AddHttpClient("backend", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<AntiforgeryHandler>();

builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("backend"));

builder.Services.AddSyncfusionBlazor();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredLocalStorageAsSingleton();

await builder.Build().RunAsync();
