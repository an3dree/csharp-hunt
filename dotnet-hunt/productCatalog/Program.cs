using Microsoft.EntityFrameworkCore;
using productCatalog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
                  options.UseNpgsql(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/categorias/", async (Categoria categoria, AppDbContext db) =>
{
    db.Categorias.Add(categoria);
    await db.SaveChangesAsync();

    return Results.Created($"/categorias/{categoria.CategoriaId}", categoria);
});

app.MapPost("/produtos/", async (Produto produto, AppDbContext db) =>
{
    db.Produtos.Add(produto);
    await db.SaveChangesAsync();

    return Results.Created($"/produtos/{produto.ProdutoId}", produto);
});


app.MapGet("/categorias/{id:int}", async (int id, AppDbContext db) =>
{
    return await db.Categorias.FindAsync(id)
         is Categoria categoria
                     ? Results.Ok(categoria)
                      : Results.NotFound();
});

app.MapGet("/categorias", async (AppDbContext db) => await db.Categorias
                                                                        .Include(p => p.Produtos)
                                                                        .ToListAsync());
app.MapGet("/produtos", async (AppDbContext db) => await db.Produtos.ToListAsync());

app.MapPut("/categorias/{id:int}", async (int id, Categoria categoria, AppDbContext db) =>
 {
     if (categoria.CategoriaId != id)
     {
         return Results.BadRequest();
     }
     var categoriaDB = await db.Categorias.FindAsync(id);

     if (categoriaDB is null) return Results.NotFound();

     categoriaDB.Nome = categoria.Nome;
     categoriaDB.Descricao = categoria.Descricao;

     await db.SaveChangesAsync();
     return Results.Ok(categoriaDB);
 });

app.MapPut("/produtos/{id:int}", async (int id, Produto produto, AppDbContext db) =>
    {
        if (produto.ProdutoId != id)
        {
            return Results.BadRequest();
        }
        var produtoDB = await db.Produtos.FindAsync(id);

        if (produtoDB is null) return Results.NotFound();

        produtoDB.Nome = produto.Nome;
        produtoDB.Descricao = produto.Descricao;
        produtoDB.Preco = produto.Preco;
        produtoDB.DataCompra = produto.DataCompra;
        produtoDB.Estoque = produto.Estoque;
        produtoDB.ImagemUrl = produto.ImagemUrl;
        produtoDB.CategoriaId = produto.CategoriaId;

        await db.SaveChangesAsync();
        return Results.Ok(produtoDB);
    });

app.MapDelete("/categorias/{id:int}", async (int id, AppDbContext db) =>
{
    var categoria = await db.Categorias.FindAsync(id);

    if (categoria is not null)
    {
        db.Categorias.Remove(categoria);
        await db.SaveChangesAsync();
    }

    return Results.NoContent();

});

app.Run();


