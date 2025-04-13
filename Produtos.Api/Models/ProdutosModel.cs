namespace Produtos.Api.Models
{
    public class ProdutosModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
        public decimal Custo { get; set; }
        public decimal Preco { get; set; }
        public decimal Estoque { get; set; }
        public string Foto { get; set; }
        public bool Ativo { get; set; }
    }
}
