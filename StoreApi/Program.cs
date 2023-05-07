using Microsoft.EntityFrameworkCore;
using StoreApi;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StoreContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.MapGet("/products", async () =>
{
    using var storeContext = new StoreContext();

    var products = await storeContext.Products.ToListAsync();

    return products;
});

app.Run();

