using EstadoCuenta.Application.Configuration;
using EstadoCuenta.Infrastructure.Configuration;
using EstadoCuenta.Infrastructure.Data;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.Configure<RequestLocalizationOptions>(options =>
//{
//    options.DefaultRequestCulture = new RequestCulture("en-US"); // Ejemplo de cultura española
//    options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-US") }; // Añadir las culturas soportadas
//    options.SupportedUICultures = new List<CultureInfo> { new CultureInfo("en-US") }; // Añadir las culturas de la interfaz de usuario soportadas
//});

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureService();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EstadoCuentaConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
