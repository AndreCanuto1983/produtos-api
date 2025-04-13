using Produtos.Api.Interfaces;
using Produtos.Api.Models;

namespace Produtos.Api.Services
{
    public class ProdutosService : IProdutosService
    {
        private readonly IList<ProdutosModel> _produtos;

        public ProdutosService()
        {
            _produtos =
            [
                new ProdutosModel()
                {
                    Id = 1,
                    Marca = "BYD",
                    Ano = "2025",
                    Modelo = "Shark",
                    Descricao = "Completo",
                    Ativo = true,
                    Custo = 230000.00M,
                    Preco = 379800.00M,
                    Estoque = 10
                },
                new ProdutosModel()
                {
                    Id = 2,
                    Marca = "Toyota",
                    Ano = "2025",
                    Modelo = "Corolla Cross",
                    Descricao = "Taxas exclusivas para os 20 primeiros clientes",
                    Ativo = true,
                    Custo = 100000M,
                    Preco = 143990.99M,
                    Estoque = 25
                },
                new ProdutosModel()
                {
                    Id = 3,
                    Marca = "Honda",
                    Ano = "2025",
                    Modelo = "Hrv Touring",
                    Descricao = "",
                    Ativo = true,
                    Custo = 130521.65M,
                    Preco = 195000.00M,
                    Estoque = 30
                },
                new ProdutosModel()
                {
                    Id = 4,
                    Marca = "Gwm",
                    Ano = "2025",
                    Modelo = "Haval H6",
                    Descricao = "",
                    Ativo = true,
                    Custo = 200000M,
                    Preco = 252124.23M,
                    Estoque = 20
                },
            ];
        }

        public ICollection<ProdutosModel> BuscarTodosProdutos()
        {
            return _produtos;
        }

        public ProdutosModel BuscarProdutosPorId(int id)
        {
            return _produtos.FirstOrDefault(a => a.Id == id);
        }
    }
}
