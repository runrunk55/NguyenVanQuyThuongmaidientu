global using NguyenVanQuyThuongmaidientu.Shared;
global using System.Net.Http.Json;
global using NguyenVanQuyThuongmaidientu.Client.Services.ProductService;
global using NguyenVanQuyThuongmaidientu.Client.Services.CategoryService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NguyenVanQuyThuongmaidientu.Client;
using NguyenVanQuyThuongmaidientu.Client.Services.CartService;
using NguyenVanQuyThuongmaidientu.Client.Services.PaymentService;
using NguyenVanQuyThuongmaidientu.Server.Services.PaymentService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<CartService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();


await builder.Build().RunAsync();
