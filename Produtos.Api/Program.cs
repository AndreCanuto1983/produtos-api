using Produtos.Api.Controllers;
using Produtos.Api.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Ioc();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.AddProdutosControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.Run(/*"https://0.0.0.0:8081"*/);