using System.Collections.Generic;
using LivrariaApi.Models.Livros;

namespace LivrariaApi.Models.Pedidos
{
    public class Carrinho
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public List<Livro> Livros { get; set; }
    }
}