using Microsoft.EntityFrameworkCore;
using StoreWebApp.Components;
using StoreWebApp.Models;
using Blazored.LocalStorage;

// Use appsettings.json to configure the application
var configuration_builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add IloginRepository to the services using the MyDbContext
builder.Services.AddScoped<ILoginRepository>(provider => provider.GetRequiredService<MyDbContext>());

// Add IProductRepository to the services using the MyDbContext
builder.Services.AddScoped<IProductRepository>(provider => provider.GetRequiredService<MyDbContext>());

builder.Services.AddBlazoredLocalStorage();


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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