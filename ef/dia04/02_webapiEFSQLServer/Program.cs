using Microsoft.EntityFrameworkCore;
using _02_webapiEFSQLServer.Models;
using _02_webapiEFSQLServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<LojaContext> (
    opcoes => {
        opcoes.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        opcoes.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
    }
);

builder.Services.AddScoped<IProdutoRepo, ProdutoRepoService>();
builder.Services.AddScoped<IPedidoRepo, PedidoRepoService>();
builder.Services.AddScoped<IClienteRepo, ClienteRepoService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
