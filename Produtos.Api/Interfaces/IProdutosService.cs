using Produtos.Api.Models;

namespace Produtos.Api.Interfaces
{
    public interface IProdutosService
    {
        ICollection<ProdutosModel> BuscarTodosProdutos();
        ProdutosModel BuscarProdutosPorId(int id);
    }
}
