using Microsoft.AspNetCore.Mvc;
using Produtos.Api.Interfaces;

namespace Produtos.Api.Controllers
{
    public static class ProdutosControllers
    {
        public static void AddProdutosControllers(this WebApplication app)
        {
            var produtos = app.MapGroup("/produtos").WithTags("Produtos");

            produtos.MapGet("/", async ([FromServices] IProdutosService _service) =>
            {
                var lista = _service.BuscarTodosProdutos();
                return Results.Ok(lista);
            });

            produtos.MapGet("/{id}", async ([FromServices] IProdutosService _service, [FromRoute] int id) =>
            {
                var item = _service.BuscarProdutosPorId(id);
                return Results.Ok(item);
            });
        }
    }
}
