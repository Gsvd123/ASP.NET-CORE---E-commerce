using ServiceContracts;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IProductService, ProductService>();


var app = builder.Build();

app.UseStaticFiles();   

app.UseRouting();

app.MapControllers();

app.Run();
