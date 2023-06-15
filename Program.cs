using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
//using StockManager.Data;
using Radzen;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

//-------------------------------------------------------//
var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Contexto>(options =>options.UseSqlite(ConStr));
builder.Services.AddScoped<ProductosBLL>();
builder.Services.AddScoped<CategoriasBLL>();
builder.Services.AddScoped<CatalogosBLL>();
builder.Services.AddScoped<ClientesBLL>();
builder.Services.AddScoped<ComprasBLL>();
builder.Services.AddScoped<InventariosBLL>();
builder.Services.AddScoped<ProveedoresBLL>();
builder.Services.AddScoped<UbicacionesBLL>();
//-------------------------------------------------------//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
