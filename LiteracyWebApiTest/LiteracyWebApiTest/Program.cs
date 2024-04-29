using Blazored.LocalStorage;
using Duende.Bff.Yarp;
using LiteracyWebApiTest.Client.Features.Home;
using LiteracyWebApiTest.Components;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();

builder.Services.AddBff();

builder.Services.AddReverseProxy().AddBffExtensions()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = "cookie";
        options.DefaultChallengeScheme = "oidc";
        options.DefaultSignOutScheme = "oidc";
    })
    .AddCookie("cookie", options =>
    {
        // host prefixed cookie name
        options.Cookie.Name = "__Host-blazor";

        // strict SameSite handling
        options.Cookie.SameSite = SameSiteMode.Strict;
    })
    .AddOpenIdConnect("oidc", options =>
    {
        options.Authority = builder.Configuration.GetSection("Identity")["Url"];

        options.ClientId = "literacyweb";
        options.ClientSecret = "YF0sfQA5Af2nBm8hKEiy5pRV+D3wSA4Cc1ytat+qbAc=";
        options.ResponseType = "code";

        options.Scope.Clear();
        options.Scope.Add("openid");
        options.Scope.Add("profile");
        options.Scope.Add("email");
        options.Scope.Add("kbiohcapi");
        options.Scope.Add("offline_access");

        options.MapInboundClaims = false;
        options.GetClaimsFromUserInfoEndpoint = true;
        options.SaveTokens = true;
    });

builder.Services.AddUserAccessTokenHttpClient("WebApi", configureClient : httpClient =>
{
    httpClient.BaseAddress = new Uri(builder.Configuration.GetSection("WebApi")["Url"]!);
});
builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebApi"));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();

builder.Services.AddSyncfusionBlazor();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();

var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NAaF1cXmhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEFjW31ZcndQTmRZVUJwVg==");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseStaticFiles();

app.UseRouting();
app.UseAntiforgery();

app.UseAuthentication();
app.UseBff();
app.UseAuthorization();

app.MapBffReverseProxy();
app.MapReverseProxy(proxyApp =>
{
    proxyApp.UseAntiforgeryCheck();
});

app.MapBffManagementEndpoints();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Home).Assembly);

app.Run();
