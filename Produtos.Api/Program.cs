using Produtos.Api.Controllers;
using Produtos.Api.Settings;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Ioc();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.AddProdutosControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
//app.UseAuthentication();
//app.UseAuthorization();

if (Debugger.IsAttached)
    app.Run();
else
    app.Run("http://0.0.0.0:443");