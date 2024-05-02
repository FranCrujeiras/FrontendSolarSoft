using FrontBlazor.Components;
using FrontBlazor.Components.Extensions;
using FrontBlazor.Components.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<ITerrenoService, TerrenoService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7060/api/Terreno/");
});

//Cuidado con añadir todo esto después del Builder.Build, si se añade después, no se cargan!!
builder.Services.AddHttpClient<IPanelService, PanelService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7060/api/Paneles/");
});

builder.Services.AddHttpClient<I_InversorService, InversorService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7060/api/Inversores/");
});

builder.Services.AddHttpClient<IBateriaService, BateriaService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7060/api/Baterias/");
});

builder.Services.AddBlazorBootstrap();
builder.Services.AddSingleton<ObjectTransporter>();
//Los HttpClient, van siempre antes de esto
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
